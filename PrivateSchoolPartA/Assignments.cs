using System;
using System.Collections.Generic;


namespace PrivateSchoolPartA
{
    public class Assignments
    {
        public static int assignmentCount;
        public string Title { get; set; }
        private string Description { get; set; }
        public DateTime SubDateTime { get; set; }
        private double OralMark { get; set; }
        private double TotalMark { get; set; }
        private int AssignmentId { get; set; }

        public static List<Assignments> assignmentList = new List<Assignments>();
        public Assignments(){}
        public Assignments(string title, string description, DateTime subDateTime, double oralMark, double totalMark)
        {
            Title = title;
            Description = description;
            SubDateTime = subDateTime;
            OralMark = oralMark;
            TotalMark = totalMark;
        }


        static Assignments cassignment1 = new Assignments("CBT5 First", "Do thing", new DateTime(2018, 11, 01), 75, 70);
        static Assignments cassignment2 = new Assignments("CBT5 Second", "Do more thing", new DateTime(2018, 11, 30), 70, 90);
        static Assignments cassignment3 = new Assignments("CBT5 Final", "Do thing the most", new DateTime(2019, 01, 25), 50, 100);


        public static void GetAllAssignmentInfo()
        {
            Console.WriteLine("Enter number of assignments.");
            assignmentCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < assignmentCount; i++)
            {
                Assignments assignment = new Assignments();
                assignmentList.Add(assignment);
                Console.WriteLine($"Enter title of #{i + 1} assignment.");
                assignmentList[i].Title = Console.ReadLine();
                Console.WriteLine($"Enter description of #{i + 1} assignment.");
                assignmentList[i].Description = Console.ReadLine();
                Console.WriteLine($"Enter sub date of #{i + 1} assignment.");
                assignmentList[i].SubDateTime = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine($"Enter oral mark of #{i + 1} assignment.");
                assignmentList[i].OralMark = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"Enter total mark of #{i + 1} assignment.");
                assignmentList[i].TotalMark = Convert.ToDouble(Console.ReadLine());
                assignmentList[i].AssignmentId = i + 1;
            }
        }

        public static void ShowInputAssignments()
        {
            for (int i = 0; i < assignmentCount; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Assignment #{i + 1}:\nTitle: {assignmentList[i].Title}" +
                    $"\nDescription: {assignmentList[i].Description}\nSub date: {assignmentList[i].SubDateTime.ToShortDateString()}" +
                    $"\nOral mark: {assignmentList[i].OralMark}\nTotal mark: {assignmentList[i].TotalMark}");
                Console.WriteLine("Press any key for next assignment...");
                Console.ReadKey();
            }
            Console.WriteLine();
            Console.WriteLine("This concludes the assignment list.");
        }

        public static void ShowPresetAssignments()
        {
            Console.WriteLine();
            Console.WriteLine($"First assignment.\nAssignment title: {cassignment1.Title}\n" +
                $"Assignment description: {cassignment1.Description}\nAssignment Sub Date: {cassignment1.SubDateTime.ToShortDateString()}" +
                $"\nAssignment oral mark: {cassignment1.OralMark}\nAssignment total mark: {cassignment1.TotalMark}" +
                $"\nPress any key for next assignment...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Second assignment.\nAssignment title: {cassignment2.Title}\n" +
                $"Assignment description: {cassignment2.Description}\nAssignment Sub Date: {cassignment2.SubDateTime.ToShortDateString()}" +
                $"\nAssignment oral mark: {cassignment2.OralMark}\nAssignment total mark: {cassignment2.TotalMark}" +
                $"\nPress any key for next assignment...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine($"Third assignment.\nAssignment title: {cassignment3.Title}\n" +
                $"Assignment description: {cassignment3.Description}\nAssignment Sub Date: {cassignment3.SubDateTime.ToShortDateString()}" +
                $"\nAssignment oral mark: {cassignment3.OralMark}\nAssignment total mark: {cassignment3.TotalMark}" +
                $"\nThis concludes the assignment list.");
            Console.WriteLine();
        }
    }
}
