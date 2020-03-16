using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2.Models {
    public class PersonGroups {
        public List<List<Person>> Groups { get; private set; }

        public PersonGroups(IEnumerable<IEnumerable<Person>> groups) {
            Groups = new List<List<Person>>();

            foreach (var item in groups)
                Groups.Add(item.ToList());
        }
    }
}
