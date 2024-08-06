using Builder_Pattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder
{
    public class Concretebuilder1 : Builder
    {
        public override void BuildPart1()
        {
            product.Part1 = "Paret_1";
        }

        public override void BuildPart2()
        {
            product.Part2 = "Part_2";
        }
        public override Product Getresult()
        {
            product.Name = "Concretebuilder1";
            return base.Getresult();
        }
    }
}
