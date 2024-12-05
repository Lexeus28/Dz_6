namespace Dz_File_6
{
    public class Patients
    {
        private string id;
        private string name;
        private string surname;
        private string gender;
        private int age;
        private string illness;
        private string status;

        private static List<Patients> patientList = new List<Patients>();

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public string Illness
        {
            get { return illness; }
            set { illness = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public static void AddPatient(Patients newPatient)
        {
            if (newPatient == null) throw new ArgumentNullException(nameof(newPatient));
            patientList.Add(newPatient);
        }

        public static void DisplayPatients()
        {
            foreach (Patients patient in patientList)
            {
                Console.WriteLine($"\nId: {patient.id}\nИмя: {patient.Name}\nФамилия: {patient.Surname}\nПол: {patient.Gender}\nВозраст: {patient.Age}\nЗаболевание: {patient.Illness}\nСтатус: {patient.Status}\n");
            }
        }
        public static void AddPatient()
        {
            try
            {
                Console.Write("Введите Id: ");
                string id = Console.ReadLine();

                Console.Write("Введите имя: ");
                string name = Console.ReadLine();

                Console.Write("Введите фамилию: ");
                string surname = Console.ReadLine();

                Console.Write("Введите пол: ");
                string gender = Console.ReadLine();

                Console.Write("Введите возраст: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Введите заболевание: ");
                string illness = Console.ReadLine();

                Console.Write("Введите статус (Вылечен/Не вылечен): ");
                string status = Console.ReadLine();

                Patients newPatient = new Patients
                {
                    Id = id,
                    Name = name,
                    Surname = surname,
                    Gender = gender,
                    Age = age,
                    Illness = illness,
                    Status = status
                };

                patientList.Add(newPatient);
                Console.WriteLine("Пациент успешно добавлен!");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Ошибка при добавлении пациента: Неверный формат данных.");
            }
        }
    }
}


