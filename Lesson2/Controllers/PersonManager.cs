using Lesson2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Controllers {

    public class PersonManager {
        //Коллеция моделей
        public List<Person> People { get; private set; }

        public PersonManager(List<Person> people) {
            People = people;
        }


        /// <summary>
        /// Группировка по возрастанию
        /// </summary>
        /// <param name="func">метод для сортировки</param>
        /// <returns>Отсортированную коллецию по возрастанию</returns>
        public IEnumerable<Person> OrderByAscending(Func<Person,object> func) {
            return People.OrderBy(func);
        }
        /// <summary>
        /// Группировка по возрастанию
        /// </summary>
        /// <param name="func">метод для сортировки</param>
        /// <returns>Отсортированную коллецию по убыванию</returns>
        public IEnumerable<Person> OrderByDescending(Func<Person, object> func) {
            return People.OrderByDescending(func);
        }
        /// <summary>
        /// Группировка
        /// </summary>
        /// <param name="func">метод группировки</param>
        /// <returns>объект образовавшихся групп после группировки</returns>
        public PersonGroups GroupBy(Func<Person,object> func) {
           return new PersonGroups(People.GroupBy(func));
        }


        public void DisplayCollection(IEnumerable<Person> people,string message) {
            Console.WriteLine($"\n{message}\n");
            foreach (var item in people)
                Console.WriteLine(item);
            
        }

        public void DisplayGroups(PersonGroups data, string message) {
            Console.WriteLine($"\n{message}\n");

            int counter = 1;
            foreach (var item in data.Groups)
            {
                DisplayCollection(item, $"Group {counter}");
                ++counter;
            }

        }
    }

}
