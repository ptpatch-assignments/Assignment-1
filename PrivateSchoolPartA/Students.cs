using System;
using System.Collections.Generic;


namespace PrivateSchoolPartA
{
    public class Students
    {
        public static DateTime checkDate;

        public static int studentCount;
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private DateTime DateOfBirth { get; set; }
        private decimal TuitionFees { get; set; }
        private int StudentId { get; set; }

        public static List<Students> studentList = new List<Students>();
        public Students(){}
        public Students(string firstName, string lastName, DateTime dateOfBirth, decimal tuitionFees)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            TuitionFees = tuitionFees;
        }


        static Students cstudent1 = new Students("Panos", "T.", new DateTime(1986, 01, 11), 2500.00m);
        static Students cstudent2 = new Students("Xristina", "Z.", new DateTime(2000, 11, 23), 2000.00m);
        static Students cstudent3 = new Students("Manos", "H.", new DateTime(1995, 05, 20), 2500.00m);


        public static void GetAllStudentInfo()
        {
            
            Console.WriteLine("Enter number of students.");
            studentCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                Students student = new Students();
                studentList.Add(student);
                Console.WriteLine($"Enter first name of #{i + 1} student.");
                studentList[i].FirstName = Console.ReadLine();
                Console.WriteLine($"Enter last name of #{i + 1} student.");
                studentList[i].LastName = Console.ReadLine();
                Console.WriteLine($"Enter date of birth of #{i + 1} student (yyyy, mm, dd).");
                studentList[i].DateOfBirth = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine($"Enter tuition fees for #{i + 1} student.");
                studentList[i].TuitionFees = Convert.ToDecimal(Console.ReadLine());
                studentList[i].StudentId = i + 1;
            }
        }

        public static void ShowInputStudents()
        {
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Student #{i + 1}:\nFirst name: {studentList[i].FirstName}\nLast name: {studentList[i].LastName}" +
                    $"\nDate of birth: {studentList[i].DateOfBirth.ToShortDateString()}\nTuition fees: {studentList[i].TuitionFees}");
                Console.WriteLine("Press any key for next student...");
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.WriteLine("This concludes the student list.");
        }

        public static void ShowPresetStudents()
        {
            Console.WriteLine();
            Console.WriteLine($"First student.\nFirst Name: {cstudent1.FirstName}\nLast Name: {cstudent1.LastName}\n" +
                $"Date of birth: {cstudent1.DateOfBirth.ToShortDateString()}\nTuition Fees: {cstudent1.TuitionFees}\n" +
                $"Press any key for next student...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Second student.\nFirst Name: {cstudent2.FirstName}\nLast Name: {cstudent2.LastName}\n" +
                $"Date of birth: {cstudent2.DateOfBirth.ToShortDateString()}\nTuition Fees: {cstudent2.TuitionFees}\n" +
                $"Press any key for next student...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Third student.\nFirst Name: {cstudent3.FirstName}\nLast Name: {cstudent3.LastName}\n" +
               $"Date of birth: {cstudent3.DateOfBirth.ToShortDateString()}\nTuition Fees: {cstudent3.TuitionFees}\n" +
               $"This concludes the student list.");
            Console.WriteLine();
        }

        public static void CheckSubDate()
        {
            Console.WriteLine("Give a date to check : ");
            checkDate = Convert.ToDateTime(Console.ReadLine());
                for (int i = 0; i < Assignments.assignmentCount; i++)
                {
                    if (VeryOriginalFirstDayCheck(checkDate, Assignments.assignmentList[i].SubDateTime) == true)
                    {           // Could do it right if I connected assignments to students.
                        Console.WriteLine($"The {Assignments.assignmentList[i].Title} assignment is due that week.");  
                        Console.WriteLine("Press any key to show next assignment, if there is one.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
        }

        public static bool VeryOriginalFirstDayCheck(DateTime firstDate, DateTime secondDate)
        {
            var cal = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
            var date1 = firstDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(firstDate));
            var date2 = secondDate.Date.AddDays(-1 * (int)cal.GetDayOfWeek(secondDate));
            return date1 == date2;
        }

        //public static void CoursesPerStudent()
        //{
        //    for (int i = 0; i < studentList.Count; i++)
        //    {
        //        for (int j = 0; j < Courses.courseCount, j++)
        //        {

        //        }
        //    }

        //    for (int i = 0; i < studentList.Count; i++)
        //    {

        //    }
        //}
    }
}
