namespace Exercise14
{
    internal class Date
    {
        public static void getNLday(int year, int month, int day)
        {
            var culture = new System.Globalization.CultureInfo("nl-NL");
            DateTime time = new DateTime(year, month, day);
            string weekday = culture.DateTimeFormat.GetDayName(time.DayOfWeek).ToString();
            Console.WriteLine(weekday);
        }
    }
}
