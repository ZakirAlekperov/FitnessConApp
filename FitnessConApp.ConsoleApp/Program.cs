using FitnessConApp.BusinessLogic.Controller;
using FitnessConApp.BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConApp.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас привествует приложение FitnessConApp.");
            Console.WriteLine("Введите имя пользователя");
            
            var name = Console.ReadLine();

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Ввежите дату рождения: ");
            var birthDay =DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Введите вес");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = double.Parse(Console.ReadLine());


            var user = new UserController(name, gender, birthDay, weight, height);

            user.Save();
        }
    }
}
