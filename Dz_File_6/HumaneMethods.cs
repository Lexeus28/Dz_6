using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dz_File_6
{
    public abstract class HumaneMethods
    {
        protected List <Patients> patient = new List <Patients>();
        protected List <Patients> healedPatient = new List <Patients>();
        public List <Patients> Patient
        {
            get { return patient; }
            set { patient = value; }
        }
        public List <Patients> HealedPatient
        {
            get { return healedPatient; }
            set { healedPatient = value; }
        }
        public abstract void Print();
    }
    public class Psychotherapy : HumaneMethods
    {
        private string discription { get; set; }
        private int practicingHoursPerMonth { get; set; }
        private int singleSessionLen { get; set; }
        public string Discription
        {
            get { return discription; }
        }
        public int PracticingHoursPerMonth
        {
            get { return practicingHoursPerMonth; }
            set { practicingHoursPerMonth = value; }
        }
        public int SingleSessionLen
        {
            get { return singleSessionLen; }
            set { singleSessionLen = value; }
        }
        public Psychotherapy()
        {
            healedPatient = null;
            patient = null;
            discription = "Пусто";
            practicingHoursPerMonth = 0;
            singleSessionLen = 0;
        }
        public Psychotherapy(string discription,List<Patients> healedPatient, List<Patients> patient, int practicingHoursPerMonth, int singleSessionLen)
        {
            this.discription = discription;
            this.healedPatient = healedPatient;
            this.patient = patient;
            this.practicingHoursPerMonth = practicingHoursPerMonth;
            this.singleSessionLen = singleSessionLen;
        }
        public override void Print()
        {
            Console.WriteLine($"Описание: {discription}\nПациенты: {patient}\nВылеченные пациенты: {healedPatient}\nЧасов применения за месяц: {practicingHoursPerMonth}\nДлина одной сессии в минутах: {singleSessionLen}\n");
        }
    }
    public class DrugTreatment:HumaneMethods
    {
        private string drugDiscription { get; set; }
        private string sideEffects { get; set; }
        private int drugsInStock  { get; set; }
        private decimal singleDrugPrice { get; set; }
        public string DrugDiscription
        {
            get { return drugDiscription; }
        }
        public string SideEffects
        {
            get { return sideEffects; }
            set { sideEffects = value; }
        }
        public int DrugsInStock
        {
            get { return drugsInStock; }
            set { drugsInStock = value;  }
        }
        public decimal SingleDrugPrice
        {
            get { return singleDrugPrice; }
            set { singleDrugPrice = value; }
        }
        public DrugTreatment()
        {
            drugDiscription = "Пусто";
            healedPatient = null;
            patient = null;
            sideEffects = "Неизвестно";
            drugsInStock = 0;
            SingleDrugPrice = 0;
        }
        public DrugTreatment(string drugDiscription, List<Patients> patient, List<Patients> healedPatient, string sideEffects, int drugsInStock, decimal singleDrugPrice)
        {
            this.drugDiscription = drugDiscription;
            this.healedPatient = healedPatient;
            this.patient = patient;
            this.sideEffects = sideEffects;
            this.drugsInStock = drugsInStock;
            this.singleDrugPrice = singleDrugPrice;
        }
        public override void Print()
        {
            Console.WriteLine($"Описание препарата: {drugDiscription}\nПациенты: {patient}\nВылеченные пациенты: {healedPatient}\nПобочные эффекты: {sideEffects}\nЗапасы препарата: {drugsInStock}\nЦена одной единицы препарата: {singleDrugPrice}");
        }
        public decimal CalculateTotalStockValue()
        {
            return drugsInStock * singleDrugPrice;
        }
    }
}
