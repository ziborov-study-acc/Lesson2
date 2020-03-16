using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models {
    public class Tasks {

        /// <summary>
        /// Метод поиска факториала
        /// </summary>
        /// <param name="num">Число для поиска факториала</param>
        /// <returns>Факториал числа num</returns>
        public int FactorialTask(int num) {
            return Enumerable.Range(1, num).Aggregate((x, y) => x * y);
        }
        /// <summary>
        /// Метод поиска числа Фибоначчи
        /// </summary>
        /// <param name="num">Число для поиска</param>
        /// <returns>число фибоначчи для num</returns>
        public long FibonacciTask(int num) {
            return (num == 0||num==1)?num:FibonacciTask(num-1)+FibonacciTask(num - 2);
        }

        /// <summary>
        /// Задание 4. Группировка по чётности
        /// </summary>
        /// <param name="array">Массив чисел</param>
        /// <returns>ОБъект групп чисел (чётные, нечётные)</returns>
        public GroupData SortTask(int[] array) {
            var groups = array.GroupBy(x => x % 2 == 0);
            return new GroupData(groups.ElementAt(1), groups.ElementAt(0));
        }

        /// <summary>
        /// Метод поиска числа Фибоначчи (LinQ)
        /// </summary>
        /// <param name="num">Число для поиска</param>
        /// <returns>число фибоначчи для num</returns>
        //public long FibonacciTask(int num) {
        //    return Enumerable.Range(1, num).Skip(2).Aggregate(new { Current = 1, Prev = 1 }, (x, index) => new { Current = x.Prev + x.Current, Prev = x.Current }).Current;
        //}


    }

}
