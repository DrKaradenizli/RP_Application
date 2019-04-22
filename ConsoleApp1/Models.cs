using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Models
    {
        public string modelName { get; set; }
        public float consumption { get; set; }

        public Models(string modelName, float consumption) {
            this.modelName = modelName;
            this.consumption = consumption;
        }
    }
}
