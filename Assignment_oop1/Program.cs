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
        }
    }
}
