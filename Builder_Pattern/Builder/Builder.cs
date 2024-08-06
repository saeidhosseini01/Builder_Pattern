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
        public Builder()
        {
            this.product =new Product();
        }
        public abstract void BuildPart1();
        public abstract void BuildPart2();
        public virtual Product Getresult()
        {
            return product;
        }
    }
}
