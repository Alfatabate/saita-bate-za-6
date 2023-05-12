using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Date
{
    public class Cat
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public int BreedId { set; get; }
        public Breed Breeds { get; set; }
    }
}
