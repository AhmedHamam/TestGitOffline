using System;

namespace ConsoleApp1
{
    class Program
    {
        class Patient
        {
            public int FileNo { get; set; }
            public string Name { get; set; }
            public int RoomNo { get; set; }
            public string Doctor { get; set; }
            public string Medicine { get; set; }

            public Patient(int fileNo, string name, int roomNo, string doctor, string medicine)
            {
                FileNo = fileNo;
                Name = name;
                RoomNo = roomNo;
                Doctor = doctor;
                Medicine = medicine;
            }

            ~Patient()
            {

            }
            public void Print()
            {
                Console.WriteLine("File Number : "+FileNo);
                Console.WriteLine("Patient Name : "+Name);
                Console.WriteLine("Room Number : "+RoomNo);
                Console.WriteLine("Doctor Name : "+Doctor);
                Console.WriteLine("Medicine Name : "+Medicine);
            }
        }
        static void Main(string[] args)
        {
            Patient p1 = new Patient(1, "P1", 1, "D1", "M1");
            Patient p2 = new Patient(2, "P2", 2, "D2", "M2");
            Patient p3 = new Patient(3, "P3", 3, "D3", "M3");
            p1.Print();
        }
    }
}
