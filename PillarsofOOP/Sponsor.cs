using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PillarsofOOP
{
    class Sponsor
    {
        //owner is define with protected modifier and it is string data type 
        //owner is protected so we can access this in same class and in child class
        protected string owner = "Rakuteen";

    }

    // Team class inherite Sponsor class so that Team class can access all properties of Sponsor (exclude private properties)
    class Team : Sponsor
    {
        // teamName has Private access-moddifier so we can only access this in same class
        private string teamName = "panthers";

        // Here we define custrustor so we can initialize fields 
        public Team(string teamName)
        {
            this.teamName = teamName;
        }
        // printInfo : this method is prublic and return string using this method we can get information of owner and teamName
        public string printInfo()
        { 
            // method is returning string
            return "owner : " + owner + ", teamName : " + teamName;
        }
    }
}
