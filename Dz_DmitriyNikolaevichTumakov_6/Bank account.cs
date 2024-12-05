using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static Dz_DmitriyNikolaevichTumakov_6.Bank_account;

namespace Dz_DmitriyNikolaevichTumakov_6
{
     public class Bank_account
    {
        private string number;
        private decimal balance;
        private Account type;
        private static List<string> numbers = new List<string>();
        public string UniqueNum()
        {
            string newNumber;
            do
            {
                Random rand = new Random();
                int[] rand_numbers = new int[20];
                for (int i = 0; i < rand_numbers.Length; i++)
                {
                    rand_numbers[i] = rand.Next(0, 9);
                }
                newNumber = string.Join("", rand_numbers);
            }
            while (numbers.Contains(newNumber));
            numbers.Add(newNumber);
            return newNumber;

        }
        public void Print()
        {
            Console.WriteLine($"\nНомер счёта: {number}\nбаланс: {balance}\nТип банковского счёта: {type}");
        }
        static bool IsAllDigit(string n)
        {
            foreach (char c in n)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public string NumInput(string inp)
        {
            while (!(inp.Length == 20 && IsAllDigit(inp)))
            {
                Console.WriteLine("\nНомер счёта должен состоять из 20 цифр, а не того, что вы ввели. Попробуйте ещё раз.");
            }
            number = inp;
            return number;
        }
        public decimal BalInput(string inp)
        {
            decimal bal;
            while (!decimal.TryParse(inp, out bal))
            {
                Console.WriteLine("\nНеверный формат данных. Повторите попытку.");
            }
            balance = bal;
            return balance;
        }
        public Account TypeInput (string inp)
        {
            Account tp;
            while (!Enum.TryParse(inp, out tp))
            {
                Console.WriteLine("\nНеверный формат данных. Повторите попытку.");
            }
            type = tp;
            return type;
        }
        public void Deposit()
        {
            Console.WriteLine("\nВведите сумму для пополнения");
            decimal bal;
            while (!decimal.TryParse(Console.ReadLine(), out bal))
            {
                Console.WriteLine("\nНеверный формат данных. Повторите попытку.");
            }
            balance += bal;
        }
        public void Withdraw()
        {
            Console.WriteLine("\nВведите сумму для снятия");
            decimal bal;
            while (!decimal.TryParse(Console.ReadLine(), out bal) || bal>balance)
            {
                Console.WriteLine("\nНеверный формат данных или недостаточно средств. Повторите попытку.");
            }
            balance -= bal;
        }
     }
    public enum Account
    {
        сберегательный,
        текущий
    }
}
