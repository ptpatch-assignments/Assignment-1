using System;
using System.Collections.Generic;


namespace PrivateSchoolPartA
{
    class Program
    {
        public static string _choice;
 

        static void Main(string[] args)
        {
            FirstChoice();
        }


        public static void FirstChoice()
        {
            Print("Welcome.\nEnter A to start entering data, or B to continue with presets.");
            string choice = Console.ReadLine();
            bool flag = true;
            while (flag == true)
            {
                if (choice.ToUpper().Trim() == "A")
                {
                    StartDataCollection();
                    break;
                }
                else if (choice.ToUpper().Trim() == "B")
                {
                    StartWithData();
                    break;
                }
                else
                {
                    Print("Enter A to start entering data, or B to continue with premade data.");
                    _choice = Console.ReadLine();
                    choice = _choice;
                }
            }
        }

        public static void StartDataCollection()
        {
            Print("");
            Print("Data collection has begun.");
            Console.WriteLine("");
            Students.GetAllStudentInfo();
            Print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Trainers.GetAllTrainerInfo();
            Print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Courses.GetAllCourseInfo();
            Print("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            Assignments.GetAllAssignmentInfo();
            Console.Clear();
            Print("Data has been set.\nPress any key to show...");
            Console.ReadKey();
            Print("");
            Students.ShowInputStudents();
            Console.ReadKey();
            Console.Clear();
            Trainers.ShowInputTrainers();
            Console.ReadKey();
            Console.Clear();
            Courses.ShowInputCourses();
            Console.ReadKey();
            Console.Clear();
            Assignments.ShowInputAssignments();
            Print("");
            Print("Wait, there's more.");
            Students.CheckSubDate();
            Print("");
            Print("Press any key to close.");
            Console.ReadKey();
        }

        public static void StartWithData()
        {
            Print("Data has been set.");
            Print("");
            Print("Press any key to show all students...");
            Console.ReadKey();
            Students.ShowPresetStudents();
            Print("Press any key to show all trainers...");
            Console.ReadKey();
            Console.Clear();
            Trainers.ShowPresetTrainers();
            Print("Press any key to show all courses...");
            Console.ReadKey();
            Console.Clear();
            Courses.ShowPresetCourses();
            Print("Press any key to show all assignments...");
            Console.ReadKey();
            Console.Clear();
            Assignments.ShowPresetAssignments();
            Print("Press any key to close.");
            Console.ReadKey();
        }

        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
