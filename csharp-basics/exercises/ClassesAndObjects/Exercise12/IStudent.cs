namespace Exercise12
{
    internal interface IStudent
    {
        string[] TestsTaken { get; set; }
        void TakeTest(ITestpaper paper, string[] answers) { }
    }
}
