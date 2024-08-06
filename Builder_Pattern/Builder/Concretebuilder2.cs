using Builder_Pattern.Classes;

namespace Builder_Pattern.Builder
{
    public class Concretebuilder2: Builder
    {
        public override void BuildPart1()
        {
            product.Part1 = "Paret_11";
        }

        public override void BuildPart2()
        {
            product.Part2 = "Part_22";
        }
        public override Product Getresult()
        {
            product.Name = "Concretebuilder2";
            return base.Getresult();
        }
    }
}
