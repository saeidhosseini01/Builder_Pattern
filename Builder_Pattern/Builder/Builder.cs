using Builder_Pattern.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder
{
    public abstract class Builder
    {
        protected Product product;
        public Builder(Product product)
        {
            this.product = product;
        }
        public abstract void BuilderPart1();
        public abstract void BuilderPart2();
        public virtual Product Getresult()
        {
            return product;
        }
    }
}
