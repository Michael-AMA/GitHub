using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introDemo
{
    class DrinksMachine
    {
        public DrinksMachine(string loc, string make, string model)
        {
            this.Location = loc;
            this.Make = make;
            this.Model = model;
        }
        // private member variables
        private string _location;

        public string Location
        {
            get { return _location; }
            set { _location = value; }
        }
        private string _make;

        public string Make1
        {
            get { return _make; }
            set { _make = value; }
        }
        private string _model;

        public string Model1
        {
            get { return _model; }
            set { _model = value; }
        }

        private int age;
        private string make;

        // public properties
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }

        // auto-implemented property
        public string Model { get; set; }

        // Contructors
        public DrinksMachine(int age)
        {
            this.Age = age;
        }
        public DrinksMachine(string make, string model)
        {
            this.Make = make;
            this.Model = model;
        }
        public DrinksMachine(int age, string make, string model)
        {
            this.Age = age;
            this.Make = make;
            this.Model = model;
        }
    }
}
