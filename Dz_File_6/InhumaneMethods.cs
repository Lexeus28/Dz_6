using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz_File_6
{
    public abstract class InhumaneMethods
    {
        protected string discription { get; set; }
        protected List <Patients> patient = new List <Patients>();
        protected List <Patients> healedPatient = new List <Patients>();
        protected string sideEffects { get; set; }
        protected float psychologicalDamage { get; set; }
        public string Discription
        {
            get { return discription; }
        }
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
        public string SideEffects
        {
            get { return sideEffects; }
            set { sideEffects = value; }
        }
        public float PsychologicalDamage
        {
            get { return psychologicalDamage; }
            set { psychologicalDamage = value; }
        }
        public virtual double CalculateEffectiveness()
        {
            if (healedPatient.Count == 0)
                return 0;
            return (double)healedPatient.Count / patient.Count() * 100;
        }
    }
    public class PhysicalAbuse: InhumaneMethods
    {
        private int practicingHoursPerMonth { get; set; }
        public int PracticingHoursPerMonth
        {
            get { return practicingHoursPerMonth; }
            set { practicingHoursPerMonth = value; }
        }
        public PhysicalAbuse()
        {
            discription = "Пусто";
            healedPatient = null;
            patient = null;
            sideEffects = "Неизвестно";
            psychologicalDamage = 0;
            practicingHoursPerMonth = 0;
        }
        public PhysicalAbuse(string discription, List<Patients> patient, List<Patients> healedPatient, string sideEffects, float psychologicalDamage, int practicingHoursPerMonth)
        {
            this.discription = discription;
            this.healedPatient = healedPatient;
            this.patient = patient;
            this.sideEffects = sideEffects;
            this.psychologicalDamage = psychologicalDamage;
            this.practicingHoursPerMonth = practicingHoursPerMonth;
        }
    }
    public class RestrictionOfFreedom:InhumaneMethods
    {
        private int singleSessionLen { get; set; }
        public int SingleSessionLen
        {
            get { return singleSessionLen; }
        }
        public RestrictionOfFreedom()
        {
            discription = "Пусто";
            healedPatient = null;
            patient = null;
            sideEffects = "Неизвестно";
            psychologicalDamage = 0;
            singleSessionLen = 0;
        }
        public RestrictionOfFreedom(string discription, List<Patients> patient, List<Patients> healedPatient, string sideEffects, float psychologicalDamage, int singleSessionlen)
        {
            this.discription = discription;
            this.healedPatient = healedPatient;
            this.patient = patient;
            this.sideEffects = sideEffects;
            this.psychologicalDamage = psychologicalDamage;
            this.singleSessionLen = singleSessionLen;
        }
    }
}
