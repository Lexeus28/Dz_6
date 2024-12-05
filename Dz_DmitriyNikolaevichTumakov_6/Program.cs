using Dz_DmitriyNikolaevichTumakov_6;
using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Security.Principal;
namespace Tumakov
{
    class Program
    {
        static void Main()
        {
            Upr_7_1_2_3();
            Dz_7_1();
        }
        static void Upr_7_1_2_3()
        {
            Console.WriteLine(@"Упражнение 7.1 Создать класс счет в банке с закрытыми полями: номер счета, баланс, тип
            банковского счета (использовать перечислимый тип из упр. 3.1). Предусмотреть методы для
            вывести информацию об объекте класса на печать.");
            Console.WriteLine(@"Упражнение 7.2 Изменить класс счет в банке из упражнения 7.1 таким образом, чтобы
            номер счета генерировался сам и был уникальным. Для этого надо создать в классе
            статическую переменную и метод, который увеличивает значение этого переменной.");
            Console.WriteLine(@"Упражнение 7.3 Добавить в класс счет в банке два метода: снять со счета и положить на
            счет. Метод снять со счета проверяет, возможно ли снять запрашиваемую сумму, и в случае
            доступа к данным – заполнения и чтения. Создать объект класса, заполнить его поля и
            положительного результата изменяет баланс.");
            Bank_account account = new Bank_account();
                account.NumInput(account.UniqueNum());
                account.BalInput("56789");
                account.TypeInput("сберегательный");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nВыберите операцию:\n1.Пополнить\n2.Снять\n3.Отобразить счёт");
                switch (Console.ReadLine())
                {
                    case "1":account.Deposit(); account.Print(); break;
                    case "2": account.Withdraw(); account.Print(); break;
                    case "3": account.Print(); break;
                    default: flag = false; break;
                }
            }
        }
        static void Dz_7_1()
        {
            Console.WriteLine(@"Домашнее задание 7.1 Реализовать класс для описания здания (уникальный номер здания,
            высота, этажность, количество квартир, подъездов). Поля сделать закрытыми,
            предусмотреть методы для заполнения полей и получения значений полей для печати.
            Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
            квартир на этаже и т.д. Предусмотреть возможность, чтобы уникальный номер здания
            генерировался программно. Для этого в классе предусмотреть статическое поле, которое бы
            хранило последний использованный номер здания, и предусмотреть метод, который
            увеличивал бы значение этого поля.");
            bool flag = true;
            while (flag)
            {
                Building building = new Building();
                        building.IdInput(building.UniqueId());
                        Console.WriteLine("\nВведите высоту здания");
                        building.HeightInput(Console.ReadLine()!);
                        Console.WriteLine("Введите количество этажей");
                        building.FloorsInput(Console.ReadLine()!);
                        Console.WriteLine("Введите количество квартир");
                        building.ApartmentsInput(Console.ReadLine()!);
                        Console.WriteLine("Введите количество подъездов");
                        building.EntrancesInput(Console.ReadLine()!);
                        building.Print();
                        building.FloorHeight();
                        building.EntranceApartments();
                        building.FloorApartments();
                
            }

        }
    }
}