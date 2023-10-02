//Запрограмуйте клас Money (об'єкт класу оперує однією валютою) для роботи з грошима.
//У класі мають бути передбачені: поле для зберігання цілої частини грошей (долари, євро, гривні тощо)
//і поле для зберігання копійок (центи, євроценти, копійки тощо)
//Реалізувати методи виведення суми на екран, задання значень частин.
//На базі класу Money створити клас Product для роботи з продуктом або товаром.
//Реалізувати метод, який дозволяє зменшити ціну на задане число.
//Для кожного з класів реалізувати необхідні методи і поля.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace NET_Homework_4_1
{
    public class Money
    {
        public int Whole;
        public double Pennies;
        public double Monies;
        public void SetWhole(int n)
        {
            Whole = n;
        }
        public void SetPennies(int m)
        {
            Pennies = m;
        }
        public void SumMoney()
        {
            Monies = Whole + Pennies / 100;
        }
        public void ShowMoney()
        {
            Console.WriteLine($"{string.Format("{0:0.00}", Monies)}");
        }
    }
}
