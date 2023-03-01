namespace Exercise12
{
    internal interface IStudent
    {
        string[] TestsTaken { get; set; }
        void TakeTest(ITestpaper paper, string[] answers) { }
    }

    internal class Student
    {
        public string[] TestsTaken
        {
            get
            {
                if (TestsTaken == null)
                {
                    TestsTaken = new string[] { "No tests taken"};
                }
                return TestsTaken;
            }
            set
            {
                TestsTaken = value;
            }

        }
        public void TakeTest(ITestpaper paper, string[] answers)
        {

        }
    }
}
