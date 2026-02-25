using Assignment_oop1.Enum;
using Math_Libirary;
using System.ComponentModel;

namespace Assignment_oop1
{
    #region Studying
    #region oop
    //Makes code organized & reusable
    //Data(Attribute) + Bevaior(Method) =Object
    //4 Pillars in oop 
    //Encapsulation - Abstraction - Inheritance - Polumarphism(Overloading-Overriding)
    #endregion
    #region User Defiened
    //Can't write Data or Method 
    //enum TestEnum
    //{

    //}
    //struct TestStruct
    //{

    //}
    //interface TestInterface
    //{

    //}
    //class TestClass
    //{

    //}
    //Access modifier :public ,internal
    #endregion
    #region Class
    //Is reference type 
    //Can write inside :Field, indexer,properties,constructor,event,methods,constant
    //access modifier default: class itself internal and member is private
    //member access modifier :public,private,internal,private protected,protected internal
    #endregion
    #region Struct
    //Is Value type 
    //Can write inside :Field, indexer,properties,constructor,event,methods,constant
    //member access modifier :public,private,internal,private protected,protected internal
    //the diif between class and struct - struct can't support inhertance , abstraction and part of polymarphism(overriding)
    #region Declaring a variable from struct

    //// Using constructor
    //Point p1 = new Point(3, 4);
    //Console.WriteLine($"p1 = {p1}");
    //Console.WriteLine($"p1.DistanceFromOrigin  = {p1.DistanceFromOrigin()}"); // 5

    //// Without constructor (all fields get default values)
    //Point p2 = new Point();
    //// Default constructor compiler provides a default constructor that initializes all fields to their default values (0 for int, null for reference types, etc.)
    //Console.WriteLine($"p2 = {p2}");

    //Point p3; // Declaring a variable of type Point without initializing it
    //		  //p3.X = 10; // Invalid 

    //Point p4 = new() { X = 10, Y = 20 };
    //Console.WriteLine(p4.DistanceFromOrigin()); // 22.360679774997898
    //Point.GetMessage(); // Struct Point
    #endregion

    #endregion
    #region Enum
    //is value type 
    //Named  constant only
    //member access modifier are public only can't change
    //enum itself is internal
    #endregion
    #region Interfaces
    //Can Write Inside:Method signatures,Properties signatures,Events,Indexers,Static Members,Default implementations,Static Abstract Members
    //Members are public by default — private, protected, internal
    //inteface itself is internal and member is public
    #endregion
    #region Record 
    //Is an immutable reference type
    //Write inside :Fields,Properties,Methods,Constructors,Events,Indexers,Nested Types
    //Members can be: public, private, protected, internal, protected internal, private protected
    //Record itself: internal — Members: private
    //record class :reference type lives in heap (immutable), record struct value type lives in stack (mutable)
    #endregion
    #region Declaring a variable from class
    //Student student01; // Declare a variable of type Student
    //student01 = new Student(); // Create a new instance of the Student class and assign it to the variable
    //student01.Name = "Ahmed"; // Set the Name property of the student01 object
    //student01.Age = 20; // Set the Age property of the student01 object

    //student01.Introduce();
    //Console.WriteLine(student01.GetBirthYear());
    //Student.WelcomeMessage();
    #endregion
    #region Reference Type Behavior

    //Student student01 = new Student("Ahmed", 20);
    //Student student02 = student01; // student02 references the same object as student01
    //Console.WriteLine($"Student01 Name : {student01.Name}"); // Output: Student01 Name : Ahmed
    //Console.WriteLine($"Student02 Name : {student02.Name}"); // Output: Student02 Name : Ahmed
    //student01.Name = "Ali"; // Modifying the Name property through student01 reference
    //Console.WriteLine("After Modifying Name");
    //Console.WriteLine($"Student01 Name : {student01.Name}"); // Output: Student01 Name : Ali
    //Console.WriteLine($"Student02 Name : {student02.Name}"); // Output: Student02 Name : Ali
    #endregion
    #region Value Type Behavior 

    //Point p01 = new Point(10, 20);
    //Point p02 = p01;  // Creates a COPY!
    //Console.WriteLine($"p01 = {p01}"); // Output: p01 = (10, 20)
    //Console.WriteLine($"p02 = {p02}"); // Output: p02 = (10, 20)
    //p02.X = 100;
    //Console.WriteLine("After Change p02.X = 100");
    //Console.WriteLine($"p01 = {p01}"); // Output: p01 = (10, 20)
    //Console.WriteLine($"p02 = {p02}"); // Output: p02 = (100, 20)
    #endregion
    #region Class Library 

    //int result =  MathHelper.Add(10, 20);

    //string validEmail = "aliaa@gmail.com";
    //string invalidEmail = "aliaagmail.com";
    //Console.WriteLine(ValidationHelper.IsValidEmail(validEmail));
    //Console.WriteLine(ValidationHelper.IsValidEmail(invalidEmail));

    #endregion
    #region Access Modifiers 

    //Employee emp = new Employee("Mohamed", "10", 5000);
    //emp.Name = "Ahmed Ali"; // Accessing public property
    // //emp.employeeId = "20"; // invalid - Cannot access internal field outside of its assembly
    // //emp.salary = 6000; // invalid - Cannot access private field outside of the Employee class
    //string result =  emp.GetSalaryInfo(); // Accessing public method that internally accesses private field
    //Console.WriteLine(result);

    #endregion

#endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            #region class (refernce type)
            //Person p1 = new Person();
            //p1.name = "Mona";
            //Person p2 = p1;
            //Console.WriteLine(p1.name);
            //Console.WriteLine(p2.name);
            //Console.WriteLine("======================");
            //p2.name = "Alaa";
            //Console.WriteLine(p1.name);
            //Console.WriteLine(p2.name);
            #endregion
            #region Struct (Value type)
            //Person2 P1 = new Person2();
            //P1.Name = "Eman";
            //Person2 P2 = P1;
            //Console.WriteLine(P1.Name);
            //Console.WriteLine(P2.Name);
            //Console.WriteLine("=============================");
            //P2.Name = "Myar";
            //Console.WriteLine(P1.Name);
            //Console.WriteLine(P2.Name);
            #endregion
            #endregion
            #region Question 2
            //Public can access in any place in my project 
            //private can access only in their scope can't see outside just in their class
            //Person3 p3 = new Person3();
            //p3.Name = "Mona";
            //p3.Age = 20; //err
            //p3.SetAge(23);
            //Console.WriteLine("Name is "+ p3.Name +", Age ="+ p3.GetAge());
            #endregion
            #region Qustion 3
            #region Liberary
            //Console.WriteLine(LibiraryHelper.Sum(10, 20));
            //Console.WriteLine(LibiraryHelper.Substraction(20, 10));
            //Console.WriteLine(LibiraryHelper.Multiply(2, 3));
            #endregion
            #endregion
            #region Question 4
            //What is a class library?
            // is a separate project that contains reusable classes, but has no Main method and cannot run on its own. It compiles into a .dll file
            ////Why do we use class libraries?
            //Reusable write once, use in many projects , Organization — Separate concerns into different assemblies, Maintenance — fix a bug once, all projects benefit
            #endregion
            #region Question 5
            //Console.Write("Enter Movie Name : ");
            //string movie=Console.ReadLine();

            //Console.Write("Enter Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): ");
            //int typeI = int.Parse(Console.ReadLine());
            //TicketType type =(TicketType) typeI;

            //Console.Write("Enter Seat Row (A,B,C,....) : ");
            //char row=char.Parse(Console.ReadLine());

            //Console.Write("Enter Seat Number : ");
            //int number=int.Parse(Console.ReadLine());

            //Console.Write("Enter Price : ");
            //double price =double.Parse(Console.ReadLine());

            //Console.Write("Enter Discount Amount: ");
            //double discount = double.Parse(Console.ReadLine());
            //Console.WriteLine("====Ticket Info====");
            //SeatL seat = new SeatL(row, number);
            //Ticket ticket = new Ticket(movie, type, seat, price);
            //ticket.PrintTicket(14);
            //Console.WriteLine("\n===== After Discount =====");
            //Console.WriteLine($"Discount before: {discount}");
            //ticket.ApplyDiscount(ref discount);
            //Console.WriteLine($"Discount after: {discount}");
            //ticket.PrintTicket(14);
            #endregion


        }
    }
}
