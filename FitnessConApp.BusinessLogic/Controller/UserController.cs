using FitnessConApp.BusinessLogic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConApp.BusinessLogic.Controller
{
    /// <summary>
    /// Контроллер пользователя
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера
        /// </summary>
        /// <param name="user">Пользователь приложения</param>
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double height )
        {

            //TODO: Проверки
            var gender = new Gender(genderName);
            User = new User(userName, gender, birthDay, weight, height);
        }
        /// <summary>
        /// Сохранить данные пользователя
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }
        /// <summary>
        /// Получить данные пользователя
        /// </summary>
        /// <returns>Пользователь приложения</returns>
        /// <exception cref="FileLoadException"></exception>
        public UserController()
        {
            var formatter = new BinaryFormatter();
            using(var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                if( formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                //TODO: Что делать, если пользователя не прочитали

            }
        }
    }
}
