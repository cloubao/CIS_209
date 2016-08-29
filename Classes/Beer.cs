using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    class Beer
    {
        // Attributes
        private double alcoholContent;

        public void setAlcoholContent(double value)
        {
            this.alcoholContent = value;
        }

        public double getAlcoholContent()
        {
            return this.alcoholContent;
        }

    }
}
