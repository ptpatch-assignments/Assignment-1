using System;
using System.Collections.Generic;


namespace PrivateSchoolPartA
{
    class Courses
    {
        public static int courseCount;
        private string Title { get; set; }
        private string Stream { get; set; }
        private string Type { get; set; }
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        private int CourseId { get; set; }

        public static List<Courses> courseList = new List<Courses>();
        //List<Students> StudentsPerCourse = new List<Students>();
        //List<Trainers> TrainersPerCourse = new List<Trainers>();
        //List<Assignments> AssignmentsPerCourse = new List<Assignments>();

        public Courses() { }
        public Courses(string title, string stream, string type, DateTime startDate, DateTime endDate)
        {
            Title = title;
            Stream = stream;
            Type = type;
            StartDate = startDate.Date;
            EndDate = endDate.Date;
        }


        static Courses ccourse1 = new Courses("CBT5", "Java", "Full-Time", new DateTime(2018, 04, 15), new DateTime(2018, 07, 15));
        static Courses ccourse2 = new Courses("CBT6", "C#", "Part-Time", new DateTime(2019, 05, 23), new DateTime(2019, 11, 23));
        static Courses ccourse3 = new Courses("CBT11", "Python", "Full-Time", new DateTime(2021, 03, 15), new DateTime(2021, 06, 15));

        public static void GetAllCourseInfo()
        {
            Console.WriteLine("Enter number of courses.");
            courseCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < courseCount; i++)
            {
                Courses course = new Courses();
                courseList.Add(course);
                Console.WriteLine($"Enter title of #{i + 1} course.");
                courseList[i].Title = Console.ReadLine();
                Console.WriteLine($"Enter stream of #{i + 1} course.");
                courseList[i].Stream = Console.ReadLine();
                Console.WriteLine($"Enter type of #{i + 1} course.");
                courseList[i].Type = Console.ReadLine();
                Console.WriteLine($"Enter starting date of #{i + 1} course.");
                courseList[i].StartDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine($"Enter ending date of #{i + 1} course.");
                courseList[i].EndDate = Convert.ToDateTime(Console.ReadLine());
                courseList[i].CourseId = i + 1;
            }
        }

        public static void ShowInputCourses()
        {
            for (int i = 0; i < courseCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Course #{i + 1}:\nTitle: {courseList[i].Title}\nStream: {courseList[i].Stream}" +
                    $"\nType: {courseList[i].Type}\nStarting date: {courseList[i].StartDate.ToShortDateString()}");
                Console.WriteLine("Press any key for next course...");
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.WriteLine("This concludes the course list.");
        }

        public static void ShowPresetCourses()
        {
            Console.WriteLine();
            Console.WriteLine($"First course.\nCourse title: {ccourse1.Title}\nCourse stream: {ccourse1.Stream}\n" +
                $"Course type: {ccourse1.Type}\nCourse starting date:{ccourse1.StartDate.ToShortDateString()}\nCourse ending date:" +
                $"{ccourse1.EndDate.ToShortDateString()}\nPress any key for next course...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Second course.\nCourse title: {ccourse2.Title}\nCourse stream: {ccourse2.Stream}\n" +
                $"Course type: {ccourse2.Type}\nCourse starting date:{ccourse2.StartDate.ToShortDateString()}\nCourse ending date:" +
                $"{ccourse2.EndDate.ToShortDateString()}\nPress any key for next course...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Third course.\nCourse title: {ccourse3.Title}\nCourse stream: {ccourse3.Stream}\n" +
                $"Course type: {ccourse3.Type}\nCourse starting date:{ccourse3.StartDate.ToShortDateString()}\nCourse ending date:" +
                $"{ccourse3.EndDate.ToShortDateString()}\nThis concludes the course list.");
            Console.WriteLine();
        }

        //public static void CheckTrainerPerCourse(List<Courses> courselist, List<Trainers> trainerlist)
        //{
        //    foreach (Courses course in courselist)
        //    {
        //        foreach (Trainers trainer in trainerlist)
        //        {
        //             for (int i = 0; i < trainerlist.Count; i++)
        //             {
        //                  if (trainerlist[i].Subject == courselist[i].Stream)
        //                  {
                            
        //                  }
        //             }
        //        }
        //    }
        //}
    }
}
