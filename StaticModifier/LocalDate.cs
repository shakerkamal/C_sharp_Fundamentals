public static class LocalDate
{
    //hardly typed
    private static string timeZone = "Pacific Standard Time";
    //get it from the system
    private static string systemTimeZone = TimeZoneInfo.Local.StandardName;
    public static DateTime GetLocalDate()
    {
        DateTime date = DateTime.UtcNow;
        TimeZoneInfo info = TimeZoneInfo.FindSystemTimeZoneById(timeZone);
        DateTime localDate = TimeZoneInfo.ConvertTimeFromUtc(date, info);
        return localDate;
    }
}