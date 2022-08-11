//class Jabeer
//{
//    public int id = 9008;
//    public void jabeerAli()
//    {
//        Console.WriteLine("Hi INdia");
//    }
//}

//class Gururaj: Jabeer
//{
//   public string Name = "Nishant";
//    double salary = 9000;
//    public void jabeerAli()
//    {
//        Console.WriteLine("Hello Guru");
//    }

//}

//class Sagar
//{
//    public static void Main(string[] args)
//    {
//        Gururaj g = new Gururaj();
//        g.jabeerAli();
//        Console.WriteLine("Student ID is  " +g.id);
//        Console.WriteLine("The name of student is  " +g.Name);
//    }

//}




//class Multi
//{
//    public int id = 9008;
//    public void abc()
//    {
//        Console.WriteLine("Hi India");
//    }
//}

//class Gururaj : Multi
//{
//    public string Name = "Guru";
//    double salary = 9000;
//    public void abc()
//    {
//        Console.WriteLine("Hello Guru");
//    }

//}

//class Mlevel : Gururaj

//{
//    public void abc()
//    {
//        Console.WriteLine("HHHHHHHHHHHHHHHHHHHh");
//    }
//    public string name = "Raj";


//}

//class Sagar
//{
//    public static void Main(string[] args)
//    {
//       Mlevel g=new Mlevel();

//        g.abc();
//        Console.WriteLine("Student ID is  " + g.id);
//        Console.WriteLine("The name of student is  " + g.name);
//    }

//}        multilevel


/*--------------Hierarchy----------*/


//class Food
//{
//    public void Fooddetails()
//    {
//        Console.WriteLine("Fruit and Vegitables name is");
//    }
//}
//class Fruit : Food
//{
//    public string name = "Aplle";

//}

//class Vegitable : Food
//{
//    public string name = "Beans";
//}

//class Eat
//{
//    public static void Main()
//    {
//        Vegitable v = new Vegitable();
//        v.Fooddetails();
//       Console.WriteLine("Vegitable is " +v.name);
//        Fruit f = new Fruit();
//        f.Fooddetails();   
//        Console.WriteLine("Fruit Name is " +f.name);
//    }
//}



/*----------------Run time Polymorphism-----------*/



//class Shape
//{
//    public virtual void Draw()
//    {
//        Console.WriteLine("Shape is");
//    }
//}

//class Ractangel : Shape
//{
//    public override void Draw()
//    {
//        Console.WriteLine("Rectangle Drawn ");
//    }

//}
//class guru
//{

//    static void Main(string[] args)   /* Testing Polymorphism */
//    {


//        Shape s = new Ractangel();   /* Polymorphic Objects */
//        /* creating Array with Different types of Objects */
//        s.Draw();


//    }
//}


/*-----------Compile time Polymorphism-------------*/


//public class Calculate
//{
//    public void AddNumbers(int a, int b)
//    {
//        Console.WriteLine("a + b = {0}", a + b);
//    }
//    public void AddNumbers(int a, int b, int c)
//    {
//        Console.WriteLine("a + b + c = {0}", a + b + c);
//    }
//}
//class Program
//{
//    static void Main(string[] args)
//    {
//        Calculate c = new Calculate();
//        c.AddNumbers(1, 2);
//        c.AddNumbers(1, 2, 3);
//        Console.WriteLine("\nPress Enter Key to Exit..");
//        Console.ReadLine();
//    }
//}


//------------- Abstraction ------------//


//class program
//{
//    abstract class animal
//    {
//        public abstract void eat();
//        public void sound()
//        {
//            Console.WriteLine("dog can sound");
//        }
//    }
//    class dog : animal
//    {
//        public override void eat()
//        {
//            Console.WriteLine("dog can eat");
//        }
//    }
//    static void Main(string[] args)
//    {
//        dog mydog = new dog();
//        animal thePet = mydog;
//        thePet.eat();
//        mydog.sound();
//    }
//}


//-------------Encapsulatiom-----------//


class Encapsulation
{
    private string Name = "Alex";
    public string EmployeeName
    { // Property  
        get
        {
            return Name;
        }
        set
        {
            Name = value;
        }
    }
    static void Main(string[] args)
    {
        string Name2 = string.Empty;
        // use properties  
        Encapsulation e = new Encapsulation();
        Name2 = e.EmployeeName;
        Console.WriteLine("Employee Name: " + Name2);
        Console.ReadLine();
    }
}  


