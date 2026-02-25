using Assignment_oop1.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_oop1
{
    #region Question 1
    #region Question 1 class
    //internal class Person
    //{
    //    public string name;
    //}
    #endregion
    #region Question 1 struct
    //public struct Person2
    //{
    //    public string Name;
    //}
    #endregion

    #endregion
    #region Question 2
    //public class Person3
    //{
    //    public string Name;
    //    private int Age;

    //    public void SetAge(int age)
    //    {
    //        Age = age;
    //    }
    //    public int GetAge()
    //    {
    //        return Age;
    //    }
    //}
    #endregion

    #region Question 5
    public struct SeatL
    {
        public char Row;
        public int Number;

        public SeatL(char _row, int _number)
        {
            Row = _row;
            Number = _number;
        }
        public override string ToString()
        {
            return $"{Row}{Number}";
        }
    }
    public class Ticket
    {
        public string MovieName;
        public TicketType Type;
        public SeatL Seat;
        private double Price;

        public Ticket(string _MovieName, TicketType _type, SeatL _seat, double _price)
        {
            MovieName = _MovieName;
            Type = _type;
            Seat = _seat;
            Price = _price;
        }
        public Ticket(string _MovieName) : this(_MovieName, TicketType.Standard, new SeatL('A', 1), 50)
        {
            
        }
        public double CalcTotal(double taxPercent)
        {
            return Price + (Price * taxPercent / 100);
        }
        public void ApplyDiscount(ref double discountAmount)
        {
            if(discountAmount>0 && discountAmount<= Price)
            {
                Price -= discountAmount;
                discountAmount = 0;
            }
        }
        public void PrintTicket(double taxPercent)
        {
            Console.WriteLine($"Movie : {MovieName}");
            Console.WriteLine($"Type : {Type}");
            Console.WriteLine($"Seat : {Seat}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Total ({taxPercent}% tax) : {CalcTotal(taxPercent)}");
        }
    } 
    #endregion
}