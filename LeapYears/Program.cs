using System.Xml;

namespace LeapYears;

class Program
{
    static void Main(string[] args)
    {

        //Find the year of current date

        DateTime thisDay = DateTime.Today;
        string currentDate = thisDay.ToString("d");
        Console.WriteLine("Current Date in dd/mm/yyyy format is: " + currentDate);
        int currentDateLength = currentDate.Length;
        string currentYearAsString = currentDate.Substring(currentDateLength - 4);
        Console.WriteLine("Current year is: " + currentYearAsString);

        //Logic to check if current year is a leap year

        //int currentYear = Int32.Parse(currentYearString);
        int currentYear = 2025; //Non-leap year as starting value
        int remainder = currentYear % 4;
        string startYear;
        string output;

        //Check if current year is a leap year
        if (remainder == 0)
        {
            startYear = currentYear.ToString();
            output = startYear;
            for (int i = 1; i < 4; i++)
            {
                int nextLeapYear = Convert.ToInt32(startYear) + 4;
                string nextLeapYearAsString = Convert.ToString(nextLeapYear);
                output = output + " " + nextLeapYearAsString;
                Console.WriteLine("Output is: " + output);
                startYear = nextLeapYearAsString;
            }
        }
        else
        {
            startYear = (currentYear + (4 - remainder)).ToString();
            output = startYear;
            for (int i = 1; i < 4; i++)
            {
                int nextLeapYear = Convert.ToInt32(startYear) + 4;
                string nextLeapYearAsString = Convert.ToString(nextLeapYear);
                output = output + " " + nextLeapYearAsString;
                Console.WriteLine("Output is: " + output);
                startYear = nextLeapYearAsString;
            }
        }
    }
}
