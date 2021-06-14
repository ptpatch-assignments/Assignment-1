using System;
using System.Collections.Generic;


namespace PrivateSchoolPartA
{ 
    class Trainers
    {
        public static int trainerCount;
        private string FirstName { get; set; }
        private string LastName { get; set; }
        public string Subject { get; set; }
        public int TrainerId { get; set; }

        public static List<Trainers> trainerList = new List<Trainers>();
        public Trainers(){}
        public Trainers(string firstName, string lastName, string subject)
        {
            FirstName = firstName;
            LastName = lastName;
            Subject = subject;
        }


        static Trainers ctrainer1 = new Trainers("Giorgos", "G.", "Java");
        static Trainers ctrainer2 = new Trainers("Makis", "T.", "C#");
        static Trainers ctrainer3 = new Trainers("Maria", "N.", "Python");


        public static void GetAllTrainerInfo()
        {
            Console.WriteLine("Enter number of trainers.");
            trainerCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < trainerCount; i++)
            {
                Trainers trainer = new Trainers();
                trainerList.Add(trainer);
                Console.WriteLine($"Enter first name of #{i + 1} trainer.");
                trainerList[i].FirstName = Console.ReadLine();
                Console.WriteLine($"Enter last name of #{i + 1} trainer.");
                trainerList[i].LastName = Console.ReadLine();
                Console.WriteLine($"Enter main subject of #{i + 1} trainer.");
                trainerList[i].Subject = Console.ReadLine();
                trainerList[i].TrainerId = i + 1;
            }
        }

        public static void ShowInputTrainers()
        {
            for (int i = 0; i < trainerCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Trainer #{i + 1}:\nFirst name: {trainerList[i].FirstName}\nLast name: {trainerList[i].LastName}" +
                    $"\nMain subject: {trainerList[i].Subject}");
                Console.WriteLine("Press any key for next trainer...");
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.WriteLine("This concludes the trainer list.");
        }

        public static void ShowPresetTrainers()
        {
            Console.WriteLine();
            Console.WriteLine($"First trainer.\nFirst Name: {ctrainer1.FirstName}\nLast Name: {ctrainer1.LastName}\n" +
            $"Main subject: {ctrainer1.Subject}\nPress any key for next trainer...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Second trainer.\nFirst Name: {ctrainer2.FirstName}\nLast Name: {ctrainer2.LastName}\n" +
            $"Main subject: {ctrainer2.Subject}\nPress any key for next trainer...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Third trainer.\nFirst Name: {ctrainer3.FirstName}\nLast Name: {ctrainer3.LastName}\n" +
            $"Main subject: {ctrainer3.Subject}\nThis concludes the trainer list.");
            Console.WriteLine();
        }
    }
}