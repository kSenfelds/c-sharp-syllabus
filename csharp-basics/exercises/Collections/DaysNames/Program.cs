static string DayName(DateTime dt)
{
    return dt.DayOfWeek.ToString();
}

Console.WriteLine(DayName(new DateTime(2023, 3, 6)));

Console.ReadKey();