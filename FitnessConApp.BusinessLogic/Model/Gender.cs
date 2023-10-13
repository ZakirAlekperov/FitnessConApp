

using System;

namespace FitnessConApp.BusinessLogic.Model
{
    /// <summary>
    /// Пол
    /// </summary>
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Название пола
        /// </summary>
        public string Name { get;}


        /// <summary>
        /// Создать новый пол, сгенерировать исключение, если назване пола пустое или null.
        /// </summary>
        /// <param name="name">Название пола</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Gender(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
