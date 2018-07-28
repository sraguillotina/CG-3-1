using System;

namespace Class3_Months
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please type a month's number to get the name of the " +
                          "month in return: ");

            //The user's input becomes the string (variable) month. 
            string month = Console.ReadLine();

            //The input value "1" is evaluated and defined as "January" for variable firstMonth.
            if (month == "1")
            {
                string firstMonth = "January";
                Console.WriteLine(firstMonth);
            }
            /*The input value "2" is evaluated and defined as "February" for variable secondMonth.
            else if conditional used for the rest of the months through December. 
            The same logic is applied for the subsequent months.*/

            else if (month == "2")
            {
                string secondMonth = "February";
                Console.WriteLine(secondMonth);
            }

            else if (month == "3")
            {
                string thirdMonth = "March";
                Console.WriteLine(thirdMonth);
            }
            else if (month == "4")
            {
                string fourthMonth = "April";
                Console.WriteLine(fourthMonth);
            }
            else if (month == "5")
            {
                string fifthMonth = "May";
                Console.WriteLine(fifthMonth);
            }
            else if (month == "6")
            {
                string sixthMonth = "June";
                Console.WriteLine(sixthMonth);
            }
            else if (month == "7")
            {
                string seventhMonth = "July";
                Console.WriteLine(seventhMonth);
            }
            else if (month == "8")
            {
                string eighthMonth = "August";
                Console.WriteLine(eighthMonth);
            }
            else if (month == "9")
            {
                string ninthMonth = "September";
                Console.WriteLine(ninthMonth);
            }
            else if (month == "10")
            {
                string tenthMonth = "October";
                Console.WriteLine(tenthMonth);
            }
            else if (month == "11")
            {
                string eleventhMonth = "November";
                Console.WriteLine(eleventhMonth);
            }
            else if (month == "12")
            {
                string twelfthMonth = "December";
                Console.WriteLine(twelfthMonth);
            }
            /*If the user enters anything outside the valid numerical scope 
             * 1-12, she receives the following error message
             * executed using an else (catch-all) expression.*/

            else
            {
                string errorMessage = "Sorry, you entered an invalid month number. " +
                    "Thank you, come again.";
                    Console.WriteLine(errorMessage);
            }
            Console.ReadLine();
        }
    }
}
