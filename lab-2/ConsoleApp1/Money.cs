using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Money // SRP - class Money has a single responsibility of representing an amount of money.
    {
        private int wholePart;
        private int pennyPart;

        public Money(int wholePart, int fractionalPart)
        {
            this.wholePart = wholePart;
            this.pennyPart = fractionalPart;
        }

        public void ShowSum()
        {
            Console.WriteLine($"{this.wholePart}.{this.pennyPart}");
        }

        public void SetWholePart(int newWholePart)
        {
            this.wholePart = newWholePart;
        }

        public void SetFractionalPart(int newPennyPart)
        {
            this.pennyPart = newPennyPart;
        }
    }
}
