using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoProjects
{
    class Coffee
    {
        private int strength;
        private string bean;
        private string countryOfOrigin;
       
        

        public Coffee(int strength, string bean, string country)
        {
            this.Strength = strength;
            this.Bean = bean;
            this.CountryOfOrigin = country;
        }


        public int Strength
        {
            get { return strength; }
            set { strength = value; }
        }
        
         public string Bean
        {
            get { return bean; }
            set { bean = value; }
        }
        

        public string CountryOfOrigin
        {
            get { return countryOfOrigin; }
            set { countryOfOrigin = value; }
        }
    }
}
