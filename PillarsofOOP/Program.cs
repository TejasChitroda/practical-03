namespace PillarsofOOP
{
    // This is the main classs that containing Main method
    class Program
    {
        public static void Main()
        {
            // Here we are creating instance of Team class so we can access non-static properties of Team class using this object
            Team t = new Team("Pantehrs");

            // Here we log the t.printInfo() that is return string and log it into console
            Console.WriteLine(t.printInfo());

            // Here we are creating instance of Bird class so we can access non-static properties of Bird class using this object
            Bird myBird = new Bird();

            // Here we want to create referace of child class and object of parent class that is not allowed in csharp so it will give error
            // Duck myDuck = new Bird();
            
            // Here we are calling Voice() Method of Bird class
            myBird.Voice();

            // Here we want to call voice() method oof Duck class but we can't use because referace of child class and object of parent class that is not allowed in csharp so it will give error
            //myDuck.Voice();

            // Here we are creating instance of Laptop class so we can access non-static properties of Laptop class using this object
            Laptop l = new Laptop();
            // Here we are assign value of Brand 
            l.Brand = "Lenovo";
            // Here we are assign value of Model
            l.Model = "lenovo_model_0123";

            // here we are calling LaptopDetails() method (this method is public so we can access here)
            l.LaptopDetails();

            // MotherBoardInfo() this method is private so we can't use this method in this class
            //l.MotherBoardInfo();


        }
    }
}