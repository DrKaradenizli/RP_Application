using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Car
    {
        public string model { get; set; }
        public int id { get; set; }

        public Car(string model, int id) {
            this.model = model;
            this.id = id;
        }
    }
}
