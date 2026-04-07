using Models;
using Data;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class ServiceService
    {
        private IRepository<Service> _repository;

        public ServiceService(IRepository<Service> repository)
        {
            _repository = repository;
        }

        public List<Service> GetAll(string nameFilter = "")
        {
            var services = _repository.GetAll();

            if (!string.IsNullOrEmpty(nameFilter))
                services = services.Where(s => s.Name.Contains(nameFilter)).ToList();

            return services;
        }

        public void Add(Service service)
        {
            if (string.IsNullOrEmpty(service.Name))
                throw new System.Exception("Name required");

            if (service.Price <= 0)
                throw new System.Exception("Price must be > 0");

            _repository.Add(service);
            _repository.Save();
        }

        public Service GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Update(Service service)
        {
            _repository.Update(service);
            _repository.Save();
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
            _repository.Save();
        }
    }
}