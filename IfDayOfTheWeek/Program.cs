
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if(weekDay == 0)
{
    Console.WriteLine("SUNDAY");
}
else if(weekDay == 1)
{
    Console.WriteLine("MONDAY");
}
else if(weekDay == 2)
{
    Console.WriteLine("TUESDAY");
}
else if(weekDay == 3)
{
    Console.WriteLine("WEDNESDAY");
}
else if(weekDay == 4)
{
    Console.WriteLine("THURSDAY");
}
else if(weekDay == 5)
{
    Console.WriteLine("FRIDAY");
}
else
{
    Console.WriteLine("SATURDAY");
}
Console.WriteLine("Have a Nice Day!");