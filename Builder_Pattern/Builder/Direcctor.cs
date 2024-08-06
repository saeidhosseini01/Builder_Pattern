using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder
{
    public class Direcctor
    {
        private Builder builder;
        public void SetBuilder( Builder builder )
        {
              this.builder=builder;
        }
        public void Constract()
        {
            builder.BuildPart1();
            builder.BuildPart2();
        }
    }
}
