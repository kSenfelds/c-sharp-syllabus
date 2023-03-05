namespace Exercise12
{
    internal class Student : IStudent
    {
        private List<string> _testsTaken = new List<string>();

        public string[] TestsTaken
        {
            get
            {
                return _testsTaken.Any() ? _testsTaken.ToArray() : new string[] { "No tests taken" };
            }
            set
            {
                TestsTaken= value;
            }
        }

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            double score = 0;

            for (int i = 0; i < answers.Length; i++)
            {
                if (paper.MarkScheme[i] == answers[i])
                {
                    score++;
                }
            }

            score = Math.Ceiling(score / answers.Length * 100);

            if (int.Parse(paper.PassMark.Substring(0, 2)) <= score)
            {
                _testsTaken.Add($"{paper.Subject}: Passed! ({score}%)");
            }
            else
            {
                _testsTaken.Add($"{paper.Subject}: Failed! ({score}%)");
            }
        }
    }
}
