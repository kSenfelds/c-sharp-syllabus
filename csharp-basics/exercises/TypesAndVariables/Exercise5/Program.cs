namespace Exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] teachers = { "Ms.Lapan", "Mrs.Gideon", "Mr. Davis", "Ms. Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James" }; 
            string[] classes = { "English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Information Systems" };
            string topAndBottom = new String('-', 62);

            Console.WriteLine($"+{topAndBottom}+");
            for (int i=0; i<classes.Length; i++)
            {
                AddToTable(i + 1, classes[i], teachers[i]);
            }
            Console.WriteLine($"+{topAndBottom}+");
        }
        static void AddToTable (int numberOfClass, string study, string teacher)
        {
            string courseWidth = new string(' ', 36);
            string printCourse = courseWidth.Substring(study.Length - 1) + study;
            string teachersWidth = new string(' ', 15);
            string printTeacher = teachersWidth.Substring(teacher.Length - 1) + teacher;
            
            Console.WriteLine($"| {numberOfClass} | {printCourse} | {printTeacher} |");
        }
        
    }
}