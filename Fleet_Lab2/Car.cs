using System;
using System.Collections.Generic;
using System.Text;

namespace Fleet_Lab2
{
    public class Car
    {
        //Fields
        private String make;
        private String model;
        private String registration;
        private double engineSize;


        //Properties
        public String Make { get; set; }
        public String Model { get; set; }
        public String Registration { get; set; }
        public double EngineSize { get; set; }

        //Constructor
        public Car(String make, String model, String registration, double engineSize)
        {
            Make = make;
            Model = model;
            Registration = registration;
            EngineSize = engineSize;
        }


        //Overriding ToString
        public override string ToString()
        {
            return String.Format("Car Details \nMake: {0} \nModel: {1} \nRegistration: {2} \nEngineSize: {3}", Make, Model, Registration, EngineSize);
        }



    }
}
