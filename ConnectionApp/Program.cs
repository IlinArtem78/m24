// See https://aka.ms/new-console-template for more information
using ClassLibrary1;
using Ado_net;
using System.IO;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;
class Program
{
  static Manager manager; 
 public static void Main(string[] args)
    {
        var manager = new Manager();
        string command;
        manager.Connect();
        switch (command)
        {
            case
            nameof(Commands.add):
                {
                    Add();
                    break;
                }

            case
            nameof(Commands.delete):
                {
                    Delete();
                    break;
                }
            case
            nameof(Commands.update):
                {
                    Update();
                    break;
                }
            case
            nameof(Commands.show):
                {
                    manager.ShowData();
                    break;
                }
                while (command != nameof(Commands.stop)) ;
        }

        manager.Disconnect();

        Console.ReadKey();
        
        
    }

    static void Update()
    {
        Console.WriteLine("Введите логин для обновления:");

        var login = Console.ReadLine();

        Console.WriteLine("Введите имя для обновления:");
        var name = Console.ReadLine();

        var count = manager.UpdateUserByLogin(login, name);

        Console.WriteLine("Строк обновлено" + count);

        manager.ShowData();
    }

    static void Add()
    {
        Console.WriteLine("Введите логин для добавления:");

        var login = Console.ReadLine();

        Console.WriteLine("Введите имя для добавления:");
        var name = Console.ReadLine();

        manager.AddUser(name, login);

        manager.ShowData();
    }

    static void Delete()
    {
        Console.WriteLine("Введите логин для удаления:");

        var count = manager.DeleteUserByLogin(Console.ReadLine());

        Console.WriteLine("Количество удаленных строк " + count);

        manager.ShowData();
    }

    public enum Commands
    {
        stop,
        add,
        delete,
        update,
        show
    }

}

