using Dz_File_6;
using System;
namespace Dz_6
{
    class program
    {
        static void Main()
        {
            Creative_Task();
        }
        static void Creative_Task()
        {
            Patients.AddPatient(new Patients { Id = "0007", Name = "Джон", Surname = "Доу", Gender = "Мужчина", Age = 46, Illness = "Психопатия", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "1975", Name = "Рэндл", Surname = "МакМёрфи", Gender = "Мужчина", Age = 35, Illness = "Антисоциальное расстройство личности", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "0234", Name = "Нина", Surname = "Сайерс", Gender = "Женщина", Age = 27, Illness = "Анорексия", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "0312", Name = "Тайлер", Surname = "Дёрден", Gender = "Мужчина", Age = 34, Illness = "Диссоциативное расстройство личности", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "0456", Name = "Джек", Surname = "Торранс", Gender = "Мужчина", Age = 42, Illness = "Психоз", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "0921", Name = "Элеонор", Surname = "Вэнс", Gender = "Женщина", Age = 32, Illness = "Посттравматическое стрессовое расстройство (ПТСР)", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "1214", Name = "Кларисса", Surname = "Старлинг", Gender = "Женщина", Age = 28, Illness = "Тревожное расстройство", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "1876", Name = "Ганнибал", Surname = "Лектер", Gender = "Мужчина", Age = 52, Illness = "Нарциссическое расстройство личности", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "2458", Name = "Милдред", Surname = "Рэтчед", Gender = "Женщина", Age = 45, Illness = "Садистическое расстройство личности", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "3267", Name = "Энни", Surname = "Уилкс", Gender = "Женщина", Age = 39, Illness = "Обсессивно-компульсивное расстройство", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "4123", Name = "Джокер", Surname = "Неизвестно", Gender = "Мужчина", Age = 37, Illness = "Шизоаффективное расстройство", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "5789", Name = "Ренфилд", Surname = "Неизвестно", Gender = "Мужчина", Age = 29, Illness = "Мания", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "6892", Name = "Эстер", Surname = "Коулман", Gender = "Женщина", Age = 33, Illness = "Диссоциативное расстройство идентичности", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "7514", Name = "Сьюзен", Surname = "Кейн", Gender = "Женщина", Age = 30, Illness = "Параноидальное расстройство личности", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "8888", Name = "Макс", Surname = "Кэди", Gender = "Мужчина", Age = 49, Illness = "Психопатия", Status = "Не вылечен" });
            Patients.AddPatient(new Patients { Id = "9901", Name = "Эндрю", Surname = "Лайдис", Gender = "Мужчина", Age = 43, Illness = "Шизофрения", Status = "Не вылечен" });
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nВыберите действие:\n1.Добавить пациента\n2Показать всех пациентов.");
                switch (Console.ReadLine())
                {
                    case "1": Patients.AddPatient();break;
                    case "2": Patients.DisplayPatients();break;
                }

            }
        }
    }
}