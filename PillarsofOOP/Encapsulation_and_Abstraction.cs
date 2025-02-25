using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsofOOP
{
    // LaptopTemplate class is abstaract class 
    abstract class LaptopTemplate
    {
        // LaptopDetails : This method is public abstact and this method is void so it is nothing to return 
        // This method is abstact method so we cannot give body of this method and this is abstaract method so child class must be implement this method
        public abstract void LaptopDetails();
    }

    // Laptop class is inherit (extends) LaptopTemplate (that is abstract class)
    class Laptop : LaptopTemplate
    {
        // variable brand is string and it hase private access modifier 
        private string brand;
        // variable model is string and it hase private access modifier
        private string model;

        // properties to access the private field
        public string Brand
        {
            // getter method so we can get value of brand from out of the class 
            get { return brand; }
            // setter method so we can set value of brand from out of the class
            set { brand = value; }
        }
        // properties to access the private 
        public string Model
        {
            // getter method so we can get value of model from out of the class 
            get { return model; }
            // setter method so we can set value of model from out of the class
            set { model = value; }
        }

        // LaptopDetais : this method is overrid from abstract class LaptopTemplate and we must have to give implementation of this method
        public override void LaptopDetails()
        { 
            // this statments is printing Brand and Model to Console
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Model: " + Model);
        }

        // MotherBoardInfo : this method is Private method  so we only can use this method in same class
        private void MotherBoardInfo()
        {
            Console.WriteLine("MotherBoard Information");
        }
    }
}
