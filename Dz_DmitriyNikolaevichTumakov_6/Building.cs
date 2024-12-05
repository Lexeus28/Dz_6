using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Dz_DmitriyNikolaevichTumakov_6
{
    public class Building
    {
        private string id;
        private float height;
        private int floors;
        private int apartmentAmount;
        private int entranceAmount;
        private static int unique = 0;
        public string UniqueId()
        {
            unique += 1;
            return $"{unique:D4}";

        }
        public void Print()
        {
            Console.WriteLine($"\nуникальный номер здания: {id}\nвысота: {height}\nэтажность: {floors}\nколичество квартир: {apartmentAmount}\nколичество подъездов: {entranceAmount}");
        }
        public void FloorHeight()
        {
            try
            {
                Console.WriteLine($"Высота этажа: {height / floors}");
            }
            catch (DivideByZeroException)
            {
                 Console.WriteLine("\nОшибка: Деление на ноль");
            }
        }
        public void FloorApartments()
        {
            try
            {
                Console.WriteLine($"Количество квартир на этаже: {apartmentAmount / floors}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nОшибка: Деление на ноль");
            }
        }
        public void EntranceApartments()
        {
            try
            {
                Console.WriteLine($"Количество квартир в подъезде: {apartmentAmount / entranceAmount}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nОшибка: Деление на ноль");
            }
        }
        public string IdInput(string inp)
        {
            id = inp;
            return id;
        }
        public float HeightInput(string inp)
        {
            float visota;
            while (!float.TryParse(inp, out visota))
            {
                Console.WriteLine("\nВысота должна состоять из цифр. Повторите попытку.");
            }
            height = visota;
            return height;
        }
        public int FloorsInput(string inp)
        {
            int etag;
            while (!int.TryParse(inp, out etag))
            {
                Console.WriteLine("\nЭтаж принимает только целочисленные значения. Повторите попытку.");
            }
            floors = etag;
            return floors;
        }
        public int ApartmentsInput(string inp)
        {
            int hata;
            while (!int.TryParse(inp, out hata))
            {
                Console.WriteLine("\nКоличество квартир должно быть целочисленным. Повторите попытку.");
            }
            apartmentAmount = hata;
            return apartmentAmount;
        }
        public int EntrancesInput(string inp)
        {
            int podjezd;
            while (!int.TryParse(inp, out podjezd))
            {
                Console.WriteLine("\nКоличество подъездов должно быть целочисленным. Повторите попытку.");
            }
            entranceAmount = podjezd;
            return entranceAmount;
        }
    }
}
