using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты_и_события_homework_20._02._2023
{
    delegate void Delegate();

    class Event {
        public event Delegate ev;
        public void EventPrint() { 
            ev?.Invoke();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Event e = new Event();

            CreditCard card = new CreditCard();
            card.Enter();

            e.ev += new Delegate(card.Add);
            e.ev += new Delegate(card.ChangePin);
            e.EventPrint();


        }
    }
}
