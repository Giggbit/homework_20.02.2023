using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Делегаты_и_события_homework_20._02._2023
{
    internal class CreditCard
    {
        private string number;
        private string Fio;
        private string date;
        private int pin;
        private int limit_on_credit;
        private int sum;

        public CreditCard() { }
        public CreditCard(string number, string fio, string date, int pin, int limit_on_credit, int sum) {
            this.number = number;
            Fio = fio;
            this.date = date;
            this.pin = pin;
            this.limit_on_credit = limit_on_credit;
            this.sum = sum;
        }

        public void Enter() {
            Console.Write("Enter number card: ");
            number = Console.ReadLine();
            Console.Write("Enter your FIO: ");
            Fio = Console.ReadLine();
            Console.Write("Enter card expiry date: ");
            date = Console.ReadLine();
            Console.Write("Enter pin-code: ");
            pin = Console.Read();
            Console.Write("Enter limite on credit: ");
            limit_on_credit = Console.Read();
            Console.Write("Enter the amount of money: ");
            sum = Console.Read();
        }
        public void Print() {
            Console.WriteLine($"\nNumber card: {number}");
            Console.WriteLine($"Your FIO: {Fio}");
            Console.WriteLine($"Card expiry date: {date}");
            Console.WriteLine($"Pin-code: {pin}");
            Console.WriteLine($"Limite on credit: {limit_on_credit}");
            Console.WriteLine($"The amount of money: {sum}");
        }

        public void Add() {
            int num = 0;
            Console.Write("Top up your account: ");
            num = Console.Read();
            sum += num;
        }
        public void Spend() {
            int num = 0;
            Console.Write("Enter sum to spend: ");
            num = Console.Read();
            sum -= num;
        }
        public void ChangePin() {
            Console.Write("Enter new pin-code: ");
            pin = 0;
            pin = Console.Read();
        }

    }
}
