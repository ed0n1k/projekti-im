using Services;
using Data;
using Models;
using UI;

class Program
{
    static void Main()
    {
        var repo = new FileRepository<Service>("services.csv");
        var service = new ServiceService(repo);

        var menu = new Menu(service);
        menu.Show();
    }
}