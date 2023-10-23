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

            var userController = new UserController(name);

            Console.WriteLine(userController.CurrentUser);
            if(userController.IsNewUser)
            {
                Console.Write("Введите пол: ");
                var gender = Console.ReadLine();
                DateTime birthDate = ParseBirthDate();
                double weight = ParseDouble("вес");
                double height = ParseDouble("рост");

                userController.SetNewUserData(gender, birthDate, weight, height);
            }
            Console.ReadLine();
        }

        private static double ParseDouble(string name) 
        {
            do
            {
                Console.Write($"Введите {name}: ");
                if (Double.TryParse(Console.ReadLine(), out double value))
                {
                    return value;
                }
                else
                {
                    Console.WriteLine($"Неверный формат");
                }
            } while (true);
        }

        private static DateTime ParseBirthDate()
        {
            do
            {
                Console.Write("Введите дату рождения в формате (dd.MM.yyyy):  ");
                if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
                {
                    return birthDate;
                }
                else
                {
                    Console.WriteLine("Некорректная дата рождения");
                }
            } while (true);
        }
    }
}
