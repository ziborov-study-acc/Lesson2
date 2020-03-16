using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Helpers {
    /// <summary>
    /// Класс методов/делегатов для сортировки/группировки
    /// </summary>
    public class PesonMethods {

        /// <summary>
        /// Метод для сортировки/группировкипо возрасту
        /// </summary>
        /// <param name="person">объект модели</param>
        /// <returns>возраст</returns>
        public object OrderByAge(Person person) {
            return person.Age;
        }

        /// <summary>
        /// Метод для сортировки/группировки по имени
        /// </summary>
        /// <param name="person">объект модели</param>
        /// <returns>Имя</returns>
        public object OrderByName(Person person) {
            return person.Name;
        }
        /// <summary>
        /// Метод для сортировки/группировки по фамилии
        /// </summary>
        /// <param name="person">объект модели</param>
        /// <returns>Фамилию</returns>
        public object OrderBySurname(Person person) {
            return person.Surname;
        }

        //public Func<Person, object> OrderByAge = person => person.Age;
        //public Func<Person, object> OrderByName = person => person.Name;
        //public Func<Person, object> OrderBySurname = person => person.Surname;
    }
}
