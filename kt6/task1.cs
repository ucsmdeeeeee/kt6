public enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
public class Programm1
{
    public static void DayPrint(DayOfWeek day)
    {
        switch (day)
        {
            case DayOfWeek.Monday:
                Console.WriteLine("Понедельник");
                break;
            case DayOfWeek.Tuesday:
                Console.WriteLine("Вторник");
                break;
            case DayOfWeek.Wednesday:
                Console.WriteLine("Среда");
                break;
            case DayOfWeek.Thursday:
                Console.WriteLine("Четверг");
                break;
            case DayOfWeek.Friday:
                Console.WriteLine("Пятница");
                break;
            case DayOfWeek.Saturday:
                Console.WriteLine("Суббота");
                break;
            case DayOfWeek.Sunday:
                Console.WriteLine("Воскресенье");
                break;
            default:
                Console.WriteLine("День вне диапазона");
                break;
        }
    }
    public static void Main(string[] args)
    {
        DayOfWeek day1 = DayOfWeek.Monday;
        DayOfWeek day2 = DayOfWeek.Tuesday;
        DayOfWeek day3 = DayOfWeek.Wednesday;
        DayOfWeek day4 = DayOfWeek.Thursday;
        DayOfWeek day5 = DayOfWeek.Friday;
        DayOfWeek day6 = DayOfWeek.Saturday;
        DayOfWeek day7 = DayOfWeek.Sunday;
        DayPrint(day1);
        DayPrint(day2);
        DayPrint(day3);
        DayPrint(day4);
        DayPrint(day5);
        DayPrint(day6);
        DayPrint(day7);
    }
}