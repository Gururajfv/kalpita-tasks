/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vehicle_details;

namespace Vehicle_details
{
    public class Vehicle  // create class
    {
        int id;
        string type;
        string name;
        string color;

        public void run()
        {
           Console.WriteLine("Vehicle is running");
            
        }

       
    }

}

public class VehicleTest
{
    *//*public static void Main(string[] args)
    {
        Vehicle Honda = new Vehicle();
        Honda.run();
        Vehicle Benz = new Vehicle();
        Benz.run();
        Console.ReadLine();


    }*//*
}

*/

using BasicOOPSConcepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicOOPSConcepts
{
    public class student  // Creating class
    {
        int id;
        string name;
        string address;
        string result;

        public void saveDetails(int id, string name, string address, string result) // method/function with parameters
        {
            Console.WriteLine("saveDetails() started");
            this.id = id;
            this.name = name;
            this.address = address;
            this.result = result; // value initialization.
            Console.WriteLine("Successfully details saved...");
        }



        public void getDetails() // method/function without parameter.
        {
            Console.WriteLine("getDetails() started");
            Console.WriteLine("student ID is {0}", id);
            Console.WriteLine("Name of student is {0}", name);
            Console.WriteLine("Address of student is " +address);
            Console.WriteLine("Result of the sudent " + result);
            Console.WriteLine("Details were displayed...");
        }

    }
}
class ObjectCreation
{
    static void Main()
    {
        student shri = new student();
        shri.saveDetails(111, "shri", "Bengalore", "pass");
        shri.getDetails();
        Console.ReadLine();
    }
}