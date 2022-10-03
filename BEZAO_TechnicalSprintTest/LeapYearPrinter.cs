using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEZAO_TechnicalSprintTest
{
	class LeapYearPrinter
	{
		// BEZAO Technical Test - Question one
		// A program that prints leap year for the next 20 years.


		// A variable to store current year
		int year = DateTime.Now.Year;

		// The number of years to be printed
		int n = 20;

		// A count variable to count the years
		int yearcount = 0;


		// The method that actually prints the leap years
		public void Print()
		{
			//The loop is meant to increament the years until the count is equal to 20
			while (yearcount != n)
			{
			
				

				// This condition checks if the year is a leap year by checking if the year can be divided by 400 as well if the years is divisible by 4 and 100
				if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
				{

					// If the year is leap year,then increment
					// the count
					yearcount++;

					// Print the leap year
					Console.WriteLine(year);
				}

				// Incrementing the year count by 1
				year = year + 1;
			}
			return;
		}



			 
		






	}
}
