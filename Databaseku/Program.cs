namespace Databaseku.Model;


class Program
{
    static void Main(string[] args)
    {
        #region CREATE
        using (Database db = new())
        {
        // bool status = db.Database.CanConnect();
        // System.Console.WriteLine(status);

        // Doctor doctor1 = new();
        // doctor1.FullName = "Dr. Cha";
        // doctor1.Specialist = "Bedah Ortopedi";
        

        // Doctor doctor2 = new();
        // doctor2.FullName = "Dr. Hayes Clarin";
        // doctor2.Specialist = "Anti Aging";
       
        // db.Doctors.AddRange(doctor1, doctor2); // jika punya collection/array/data banyak. Bs langsung add seluruh datanya.
        // db.SaveChanges();

        // Patient patient1 = new();
        // patient1.Name = "Harry";
        // patient1.Gender = "Man";
        // patient1.Age=27;
        // Patient patient2 = new();
        // patient2.Name = "Melisa";
        // patient2.Gender = "Woman";
        // patient2.Age=32;
        // Patient patient3 = new();
        // patient3.Name = "Aldilla";
        // patient3.Gender = "Woman";
        // patient3.Age=25;
        //  db.Patients.AddRange(patient1, patient2,patient3); // jika punya collection/array/data banyak. Bs langsung add seluruh datanya.
        // db.SaveChanges();

        // Chat chat1 = new();
        // chat1.DoctorID = 1;
        // chat1.Message = "Selamat pagi, ada yang bisa dibantu?";
        // chat1.PatientID = 1;



        // chat1.DoctorID = 1;
        // chat1.Message = "Saya ingin operasi, kapan kira kira bisa segera dilaksanakan? ";
        // chat1.PatientID = 1;


        // chat1.DoctorID = 1;
        // chat1.Message = "Minggu depan. Mohon reservasi dahulu ke pihak rumah sakit. ";
        // chat1.PatientID = 1;

        // chat1.DoctorID = 1;
        // chat1.Message = "Baik, akan segera saya reservasi. Terima kasih. ";
        // chat1.PatientID = 1;


        // Chat chat2 = new();
        // chat2.DoctorID = 2;
        // chat2.Message = "Selamat pagi, ada yang bisa dibantu?";
        // chat2.PatientID = 3;

        // chat2.DoctorID = 2;
        // chat2.Message = "Saya ingin rekomendasi skincare untuk usia saya. ";
        // chat2.PatientID = 3;


        // chat2.DoctorID = 2;
        // chat2.Message = "Anda bisa menggunakan sabun cuci muka yang bisa dibeli di apotik saya. ";
        // chat2.PatientID = 3;

        // chat2.DoctorID = 2;
        // chat2.Message = "Baik, Terima kasih. ";
        // chat2.PatientID = 3;


        // Chat chat3 = new();
        // chat3.DoctorID = 2;
        // chat3.Message = "Selamat malam, ada yang bisa dibantu?";
        // chat3.PatientID = 2;

        // chat3.DoctorID = 2;
        // chat3.Message = "Saya ingin membeli 1 paket skincare lagi. ";
        // chat3.PatientID = 2;

        // chat3.DoctorID = 2;
        // chat3.Message = "Baik, akan saya buatkan. Silahkan tunggu di apotik. ";
        // chat3.PatientID = 2;

        // chat3.DoctorID = 2;
        // chat3.Message = "Baik, Terima kasih. ";
        // chat3.PatientID = 2;
        // db.Chat.Add(chat3);
        // db.SaveChanges();



        // db.Chat.AddRange(chat1, chat2, chat3); // jika punya collection/array/data banyak. Bs langsung add seluruh datanya.
        // db.SaveChanges();



        }
        #endregion


        #region  READ
        using (Database db = new())
        {
            List<Doctor> doctors = db.Doctors.ToList();
            foreach (var doc in doctors)
            {
                System.Console.WriteLine(doc.FullName);
            }
        }

        using (Database db = new())
        {
            int idDoc = 1;
            int idPat = 1;
            IQueryable<Chat> returnChat = db.Chat.Where(data => data.DoctorID == idDoc & data.PatientID == idPat);
            Doctor doctor = db.Doctors.Find(idDoc);
            Patient patient = db.Patients.Find(idPat);

            System.Console.WriteLine($"Chat between:  {doctor.FullName} - {patient.Name}");
            foreach (var chat in returnChat)
            {
                System.Console.WriteLine(chat.Message);
            }
            System.Console.WriteLine("==========");

            int idDoc2 = 2;
            int idPat2 = 2;
            IQueryable<Chat> returnChat2 = db.Chat.Where(data => data.DoctorID == idDoc2 & data.PatientID == idPat2);
            Doctor doctor2 = db.Doctors.Find(idDoc2);
            Patient patient2 = db.Patients.Find(idPat2);

            System.Console.WriteLine($"Chat between:  {doctor2.FullName} - {patient2.Name}");
            foreach (var chat in returnChat2)
            {
                System.Console.WriteLine(chat.Message);
            }
            System.Console.WriteLine("==========");
        }
        #endregion


        #region MOVE VALUE DB
        // using (Database db = new())
        // {
        //     IQueryable<string> specialist = db.Doctors.Select(doc => doc.Specialist).Distinct();
        //     foreach (string sp in specialist)
        //     {
        //         Specialist spec = new()
        //         {
        //             Name = sp
        //         };
        //         db.Specialist.Add(spec);
        //     }
        //     db.SaveChanges();


        // }
        #endregion
    
    #region UPDATE
     using (Database db = new())
        {
                        // ==FILTER BY ID==
            // Doctor doctor = db.Doctors.Find(1);
            // doctor.SpecialistID = 1;
            Doctor doctor = db.Doctors.Find(2);
            doctor.SpecialistID = 2;
            db.SaveChanges();
        }
    #endregion
    }
}