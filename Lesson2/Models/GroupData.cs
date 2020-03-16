using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models {
    public class GroupData {
        //Массив чётных
        public int[] Even { get; private set; }
        //Массив нечётных
        public int[] Odd { get; private set; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="evenArr">Коллеция чётных чисел</param>
        /// <param name="oddArr">Коллеция нечётных чисел</param>
        public GroupData(IEnumerable<int> evenArr, IEnumerable<int> oddArr) {
            Even = evenArr.ToArray();
            Odd = oddArr.ToArray();
        }

        public override string ToString() {
            string output = "Чётные элементы\n";
            foreach (var item in Even)
                output += $"{item}\t";

            output += "\nНечётные элементы\n";

            foreach (var item in Odd)
                output += $"{item}\t";

            return output;
        }
    }
}
