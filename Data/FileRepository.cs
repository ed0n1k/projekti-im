using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Models;

namespace Data
{
    public class FileRepository : IRepository<Service>
    {
        private string filePath = "services.csv";
        private List<Service> services;

        public FileRepository()
        {
            services = GetAll();
        }

        public List<Service> GetAll()
        {
            if (!File.Exists(filePath))
                return new List<Service>();

            return File.ReadAllLines(filePath)
                .Skip(1)
                .Select(line =>
                {
                    var parts = line.Split(',');
                    return new Service
                    {
                        Id = int.Parse(parts[0]),
                        Name = parts[1],
                        Price = double.Parse(parts[2]),
                        Duration = int.Parse(parts[3])
                    };
                }).ToList();
        }

        public Service GetById(int id)
        {
            return services.FirstOrDefault(s => s.Id == id);
        }

        public void Add(Service item)
        {
            services.Add(item);
            Save();
        }

        public void Update(Service item)
        {
            var existing = GetById(item.Id);
            if (existing != null)
            {
                existing.Name = item.Name;
                existing.Price = item.Price;
                existing.Duration = item.Duration;
                Save();
            }
        }

        public void Delete(int id)
        {
            var service = GetById(id);
            if (service != null)
            {
                services.Remove(service);
                Save();
            }
        }

        public void Save()
        {
            var lines = new List<string> { "Id,Name,Price,Duration" };

            lines.AddRange(services.Select(s =>
                $"{s.Id},{s.Name},{s.Price},{s.Duration}"));

            File.WriteAllLines(filePath, lines);
        }
    }
}