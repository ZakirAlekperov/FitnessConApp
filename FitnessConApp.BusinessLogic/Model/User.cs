﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessConApp.BusinessLogic.Model
{
    /// <summary>
    /// Пользователь
    /// </summary>
    public class User
    {

        #region Свойства
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get;}
        /// <summary>
        /// Пол
        /// </summary>
        public Gender Gender { get;}

        /// <summary>
        /// Дата рождения
        /// </summary>
        public DateTime BirthDate { get;}

        /// <summary>
        /// Вес
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Рост
        /// </summary>
        public double Height {  get; set; }
        #endregion

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="name">Имя пользователя.</param>
        /// <param name="gender">Пол.</param>
        /// <param name="birthDate">Дата рождения.</param>
        /// <param name="weight">Вес.</param>
        /// <param name="height">Рост.</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height) 
        {
            #region Проверка условий
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым.", nameof(name));
            }
            if (gender == null)
            {
                throw new ArgumentNullException("Пол не может быть пустым.", nameof(gender)); ;
            }
            if(birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now)
            {
                throw new ArgumentException("Невозможная дата рождения.", nameof(birthDate));
            }
            if(weight <= 0)
            {
                throw new ArgumentException("Невозможный вес. Вес не может быть отрицательным.", nameof(weight));
            }
            if(height <= 0)
            {
                throw new ArgumentException("Невозможный рост, рост не может быть отрицательным.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }
    }
}