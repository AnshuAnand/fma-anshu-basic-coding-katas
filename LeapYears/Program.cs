using System.Xml;

namespace LeapYears;

class Program
{
    static void Main(string[] args)
    {

        //Find the year of current date

        DateTime thisDay = DateTime.Today;
        int currentYear = thisDay.Year;
        //int currentYear = 2025; //Non-leap year as starting value
        Console.WriteLine("Starting year is: " + currentYear);

        int remainder = currentYear % 4;


        string printOutput = "";
        int numberOfIterations = 4;

        //Check if current year is a leap year
        /*if (remainder == 0)
        {
            int nextLeapYear = currentYear + 4;
            for (int i = 0; i < numberOfIterations; i++)
            {
                printOutput = printOutput + " " + nextLeapYear;
                nextLeapYear += 4;
            }
        }

        else
        {
            int nextLeapYear = currentYear + (4 - remainder);
            for (int i = 0; i < numberOfIterations; i++)
            {
                printOutput = printOutput + " " + nextLeapYear;
                nextLeapYear += 4;
            }
        } */

        int nextLeapYear = currentYear + (4 - remainder);
        for (int i = 0; i < numberOfIterations; i++)
        {
            printOutput = printOutput + " " + nextLeapYear;
            nextLeapYear += 4;
        }

        Console.WriteLine("Output is: " + printOutput);
    }
}

