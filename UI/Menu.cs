using Services;
using Models;

namespace UI
{
    public class Menu
    {
        private ServiceService _service;

        public Menu(ServiceService service)
        {
            _service = service;
        }

        public void Show()
        {
            while (true)
            {
                Console.WriteLine("\n--- BARBERSHOP MENU ---");
                Console.WriteLine("1. List services");
                Console.WriteLine("2. Add service");
                Console.WriteLine("3. Find by ID");
                Console.WriteLine("4. Update");
                Console.WriteLine("5. Delete");
                Console.WriteLine("0. Exit");

                var choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        case "1":
                            foreach (var s in _service.List())
                                Console.WriteLine($"{s.Id} - {s.Name} - {s.Price}€");
                            break;

                        case "2":
                            Console.Write("Name: ");
                            var name = Console.ReadLine();

                            Console.Write("Price: ");
                            var price = double.Parse(Console.ReadLine());

                            Console.Write("Duration: ");
                            var duration = int.Parse(Console.ReadLine());

                            _service.Add(new Service
                            {
                                Id = new Random().Next(1000),
                                Name = name,
                                Price = price,
                                Duration = duration
                            });
                            break;

                        case "3":
                            Console.Write("ID: ");
                            var id = int.Parse(Console.ReadLine());
                            var result = _service.GetById(id);
                            Console.WriteLine(result?.Name ?? "Not found");
                            break;

                        case "4":
                            Console.Write("ID: ");
                            var uid = int.Parse(Console.ReadLine());

                            Console.Write("New Name: ");
                            var newName = Console.ReadLine();

                            Console.Write("New Price: ");
                            var newPrice = double.Parse(Console.ReadLine());

                            Console.Write("New Duration: ");
                            var newDuration = int.Parse(Console.ReadLine());

                            _service.Update(new Service
                            {
                                Id = uid,
                                Name = newName,
                                Price = newPrice,
                                Duration = newDuration
                            });
                            break;

                        case "5":
                            Console.Write("ID: ");
                            var did = int.Parse(Console.ReadLine());
                            _service.Delete(did);
                            break;

                        case "0":
                            return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}