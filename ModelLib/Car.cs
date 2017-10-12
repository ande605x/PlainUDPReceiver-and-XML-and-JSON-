using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLib
{
    public class Car
    {
        private string model;
        private string color;
        private string regNo;

        public string Model
        {
            get { return model; }
            set { model = value; }
        }


        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public string RegNo
        {
            get { return regNo; }
            set { regNo = value; }
        }


        public Car(string model, string color, string regNo)
        {
            this.model = model;
            this.color = color;
            this.regNo = regNo;
        }

        public Car()
        {

        }

        public override string ToString()
        {
            return $"{nameof(model)}: {model}, {nameof(color)}: {color}, {nameof(regNo)}: {regNo}";
        }
    }
}
