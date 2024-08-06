using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Classes
{
    public class Product
    {
        public string Part1 { get; set; }
        public string Part2 { get; set; }
        public string Name { get; set; }

        public void Displayinfo()
        {
            Console.WriteLine($"this Part1 {Part1}");
            Console.WriteLine($"this Part2 {Part2}");
            Console.WriteLine($"this Name {Name}");
        }
    }
}
