//Name: Ishraq Alam
//Date: March 5, 2024

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q6DateDifferenceIA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable Declaration
            string strUser; //Yogurt container - getting input
            string strMonth1, strMonth2; //Represents the two months the user inputs in words
            int intMonth1 = 0; //Sets values corresponding to the order of the first month the user enters.
            int intMonth2 = 0; //Sets values corresponding to the order of the second month the user enters. 
            int intDay1, intDay2; //Represents the day the user enters. 
            int intYear1, intYear2; //Represents the year the user enters. 
            int intYearDifference; //Represents the difference between the two years the user enters. 
            int intYearDays; //Calculation for the number of days in completed years. 
            int intMonthsToDays1 = 0; //Used throughout application to convert the number of months into days so that it could be added to find the total number of days.
            int intMonthsToDays2 = 0; //Used throughout application to convert the number of months into days so that it could be added to find the total number of days.
            int intReverseMonths = 0; //Used to find the number of days after the initial date until the end of that same year. 
            int intDateDifference = 0; //Represents the total number of days outputted to user.
            int intLeapDay1 = 0; //Number of leap days from year 0 for first date.
            int intLeapDay2 = 0; //Number of leap days from year 0 for second date. 
            int intLeapDayDifference = 0; //Difference between the leap days to find number of leap days between the two dates. 
            int intMonthsDifference = 0; //Used to find the number of days between two dates in the same year. 



            //Input
            Console.WriteLine("Hello! This application will tell you the difference in days between any two dates."); //background info 
            Console.WriteLine("\nPlease enter the day of the first date: ");
            strUser = Console.ReadLine();
            intDay1 = Int32.Parse(strUser); //string to integer 

            Console.WriteLine("Please enter the year of the first date: ");
            strUser = Console.ReadLine();
            intYear1 = Int32.Parse(strUser);//string to integer 

            Console.WriteLine("Please enter the month of the first date in ALL CAPITALS. (Eg. January should be entered as JANUARY)");
            strUser = Console.ReadLine();
            strMonth1 = strUser;

            Console.WriteLine("\nPlease enter the day of the second date: ");
            strUser = Console.ReadLine();
            intDay2 = Int32.Parse(strUser);//string to integer 

            Console.WriteLine("Please enter the year of the second date: ");
            strUser = Console.ReadLine();
            intYear2 = Int32.Parse(strUser);//string to integer 

            Console.WriteLine("Please enter the month of the second date in ALL CAPITALS. (Eg. January should be entered as JANUARY)");
            strUser = Console.ReadLine();
            strMonth2 = strUser;

            //Process

            //Month 1 Values - converts each month into a number value
            if (strMonth1 == "JANUARY")
            {
                intMonth1 = 1;

            }

            else if (strMonth1 == "FEBRUARY")
            {
                intMonth1 = 2;

            }

            else if (strMonth1 == "MARCH")
            {
                intMonth1 = 3;

            }

            else if (strMonth1 == "APRIL")
            {
                intMonth1 = 4;

            }

            else if (strMonth1 == "MAY")
            {
                intMonth1 = 5;

            }

            else if (strMonth1 == "JUNE")
            {
                intMonth1 = 6;

            }

            else if (strMonth1 == "JULY")
            {
                intMonth1 = 7;

            }

            else if (strMonth1 == "AUGUST")
            {
                intMonth1 = 8;

            }

            else if (strMonth1 == "SEPTEMBER")
            {
                intMonth1 = 9;

            }

            else if (strMonth1 == "OCTOBER")
            {
                intMonth1 = 10;

            }

            else if (strMonth1 == "NOVEMBER")
            {
                intMonth1 = 11;

            }

            else if (strMonth1 == "DECEMBER")
            {
                intMonth1 = 12;

            }




            //Month 2 Values - converts each month into a number value
            if (strMonth2 == "JANUARY")
            {
                intMonth2 = 1;

            }

            else if (strMonth2 == "FEBRUARY")
            {
                intMonth2 = 2;

            }

            else if (strMonth2 == "MARCH")
            {
                intMonth2 = 3;

            }

            else if (strMonth2 == "APRIL")
            {
                intMonth2 = 4;

            }

            else if (strMonth2 == "MAY")
            {
                intMonth2 = 5;

            }

            else if (strMonth2 == "JUNE")
            {
                intMonth2 = 6;

            }

            else if (strMonth2 == "JULY")
            {
                intMonth2 = 7;

            }

            else if (strMonth2 == "AUGUST")
            {
                intMonth2 = 8;

            }

            else if (strMonth2 == "SEPTEMBER")
            {
                intMonth2 = 9;

            }

            else if (strMonth2 == "OCTOBER")
            {
                intMonth2 = 10;

            }

            else if (strMonth2 == "NOVEMBER")
            {
                intMonth2 = 11;

            }

            else if (strMonth2 == "DECEMBER")
            {
                intMonth2 = 12;

            }


            //Calculations 
            if (intYear2 > intYear1) //if second year entered is greater than first year entered
            {
                intYearDifference = intYear2 - intYear1; //difference of both years
                intYearDays = (intYearDifference - 1) * 365; //calculates number of days for number of years between

                //Month 2
                if (intMonth2 <= 7) //if second month entered is January - July
                {
                    if (intMonth2 != 3 && intMonth2 != 2) //If month is not February or March
                    {
                        intMonthsToDays1 = ((intMonth2 - 1) * 30) + intDay2; //calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 == 3) //if month is March
                    {
                        intMonthsToDays1 = ((intMonth2 - 1) * 30) - 1 + intDay2; //calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 == 2) //if month is February
                    {
                        intMonthsToDays1 = ((intMonth2 - 1) * 30) + 1 + intDay2; //calculates number of days from Jan 1 - date
                    }
                }

                if (intMonth2 > 7) //if second month entered is August - December
                {
                    if (intMonth2 == 8) //if month is August
                    {
                        intMonthsToDays1 = ((intMonth2 - 1) * 30) + 2 + intDay2; //calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 > 8 && intMonth2 <= 12) //if month is September - December
                    {
                        intMonthsToDays1 = ((intMonth2 - 1) * 30) + 3 + intDay2; //calculates number of days from Jan 1 - date
                    }
                }

                //Month 1
                if (intMonth1 <= 7) //If first month is January - July
                {
                    if (intMonth1 != 3 && intMonth1 != 2) //If month is not March or February
                    {
                        intMonthsToDays2 = ((intMonth1 - 1) * 30) + intDay1; //calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 == 3) //If month is March
                    {
                        intMonthsToDays2 = ((intMonth1 - 1) * 30) - 1 + intDay1; //calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 == 2) //If month is February
                    {
                        intMonthsToDays2 = ((intMonth1 - 1) * 30) + 1 + intDay1; //calculates number of days from Jan 1 - date
                    }
                }

                if (intMonth1 >= 7) //If month is August - December
                {
                    if (intMonth1 == 8) //If month is August
                    {
                        intMonthsToDays2 = ((intMonth1 - 1) * 30) + 2 + intDay1; //calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 > 8 && intMonth1 <= 12) //If month is September - December
                    {
                        intMonthsToDays2 = ((intMonth1 - 1) * 30) + 3 + intDay1; //calculates number of days from Jan 1 - date
                    }
                }

                intReverseMonths = 365 - intMonthsToDays2; //Finds the number of days from the date - the end of the year by subtracting 365 (reverse). 


                //Leap year calculation
                if (intMonth2 > 2) //If second inputted month is March - December
                {
                    intLeapDay2 = ((intYear2 - 1) / 4) + 2; //Extra leap day because February is passed, so the leap day in that year happened (Feb 29).
                }
                else if (intMonth2 <= 2) //If month is January or February
                {
                    intLeapDay2 = ((intYear2 - 1) / 4) + 1; //1 leap day because February 29 did not pass yet. 
                }

                if (intMonth1 > 2) //If first inputted month is March - December
                {
                    intLeapDay1 = ((intYear1 - 1) / 4) + 2; //Extra leap day because February is passed, so the leap day in that year happened (Feb 29).
                }
                else if (intMonth1 <= 2) //January or February
                {
                    intLeapDay1 = ((intYear1 - 1) / 4) + 1; //1 leap day because February 29 did not pass yet. 
                }

                intLeapDayDifference = intLeapDay2 - intLeapDay1; //Calculates the difference in leap days from the year 0 for both. The difference will determine the number of leap days in between.

                intDateDifference = intYearDays + intReverseMonths + intLeapDayDifference + intMonthsToDays1 + 2; //Total number of days between each date entered.
            }

            //if first year is later than second year
            else if (intYear1 > intYear2)
            {
                intYearDifference = intYear1 - intYear2; //Difference between years. 
                intYearDays = (intYearDifference - 1) * 365; //Converts years to days. 

                //Month 1
                if (intMonth1 <= 7) //If first month is January - July
                {
                    if (intMonth1 != 3 && intMonth1 != 2) //If it is not March or February/
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + intDay1; //calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 == 3) //If month is March
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) - 1 + intDay1;//calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 == 2) //If month is February
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + 1 + intDay1;//calculates number of days from Jan 1 - date
                    }
                }

                if (intMonth1 > 7) //if first month is August - December
                {
                    if (intMonth1 == 8) //if month is August
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + 2 + intDay1;//calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 > 8 && intMonth1 <= 12) //if month is September - December
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + 3 + intDay1;//calculates number of days from Jan 1 - date
                    }
                }

                //Month 2
                if (intMonth2 <= 7) //If second month is January - July
                {
                    if (intMonth2 != 3 && intMonth2 != 2) //If month is not March or February
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + intDay2;//calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 == 3) //If month is March
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) - 1 + intDay2;//calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 == 2) //If month is February
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + 1 + intDay2;//calculates number of days from Jan 1 - date
                    }
                }

                if (intMonth2 >= 7) //If month is August - December
                {
                    if (intMonth2 == 8) //If month is August 
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + 2 + intDay2;//calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 > 8 && intMonth2 <= 12) //If month is September - December
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + 3 + intDay2;//calculates number of days from Jan 1 - date
                    }
                }

                intReverseMonths = 365 - intMonthsToDays2; //Finds the number of days after the 2nd date inputted until the end of that year. 

                //Leap year calculation
                if (intMonth2 > 2) //If month is March - December
                {
                    intLeapDay2 = ((intYear2 - 1) / 4) + 2; //Finds number of leap years from year 0. Has extra day since Feb 29 passed.
                }
                else if (intMonth2 <= 2) //If month is January or February
                {
                    intLeapDay2 = ((intYear2 - 1) / 4) + 1; //Finds number of leap years from year 0. 
                }

                if (intMonth1 > 2) //If month is March - December
                {
                    intLeapDay1 = ((intYear1 - 1) / 4) + 2; //Finds number of leap years from year 0. Has extra day since Feb 29 passed.
                }
                else if (intMonth1 <= 2) //If month is January or February
                {
                    intLeapDay1 = ((intYear1 - 1) / 4) + 1; //Finds number of leap years from year 0. 
                }

                intLeapDayDifference = intLeapDay1 - intLeapDay2; //Finds the number of leap days in between.

                intDateDifference = intYearDays + intReverseMonths + intLeapDayDifference + intMonthsToDays1 + 2; //Adds the total number of days. 
            }

            else if (intYear1 == intYear2) //if both years are the same.
            {

                if (intMonth1 <= 7) // If month is January - July
                {
                    if (intMonth1 != 3 && intMonth1 != 2) //If month is not March or February
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + intDay1; //Calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 == 3) //If March
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) - 1 + intDay1; //Calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 == 2) //if February
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + 1 + intDay1; //Calculates number of days from Jan 1 - date
                    }
                }

                if (intMonth1 > 7) //If Month is August - December.
                {
                    if (intMonth1 == 8) //If month is August
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + 2 + intDay1; //Calculates number of days from Jan 1 - date
                    }
                    else if (intMonth1 > 8 && intMonth1 <= 12) //If month is September - December
                    {
                        intMonthsToDays1 = ((intMonth1 - 1) * 30) + 3 + intDay1; //Calculates number of days from Jan 1 - date
                    }
                }

                if (intMonth2 <= 7) //If month is January - July
                {
                    if (intMonth2 != 3 && intMonth2 != 2) //If month is not March or February
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + intDay2; //Calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 == 3) //If month is March
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) - 1 + intDay2; //Calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 == 2) //If month is February
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + 1 + intDay2; //Calculates number of days from Jan 1 - date
                    }
                }

                if (intMonth2 > 7) //If month is August - September
                {
                    if (intMonth2 == 8) //If month is August 
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + 2 + intDay2; //Calculates number of days from Jan 1 - date
                    }
                    else if (intMonth2 > 8 && intMonth2 <= 12) //If month is September - December
                    {
                        intMonthsToDays2 = ((intMonth2 - 1) * 30) + 3 + intDay2; //Calculates number of days from Jan 1 - date
                    }
                }
                intMonthsDifference = intMonthsToDays1 - intMonthsToDays2; //Calculates the difference between the number of days from Jan 1 - date for each.
                intMonthsDifference = Math.Abs(intMonthsDifference); //Finds the absolute value of the difference (negative --> positive). 

                if ((intYear1 % 4) == 0 && intMonthsToDays2 > 59 || intMonthsToDays1 > 59) //Identifies whether the year is a leap year. It also adds 1 to the total if it is a leap year and either date is after 59 days into the year (Feb 29). 
                {
                    intLeapDayDifference = 1; //Assigns value of 1 to leap day difference.
                }

                intDateDifference = intMonthsDifference + intLeapDayDifference + 1; //Calculates total number of days between each date. 
            }


            //Output
            Console.WriteLine("The difference between the two dates is: " + intDateDifference + " days"); //Outputs the result to the user. This results includes the start and end date that the user entered. 


            Console.ReadKey(); //Ends program
        }
    }
}
