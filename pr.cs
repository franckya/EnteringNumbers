using System;
using System.Collections.Generic;

namespace EnterNums
{
    class Program
    {
        static void Main(string[] args)
        {

           int count = 0;

            while (true)
            {
                if (count>= 10)
                {
                    break;
                }

                try
                {
                    int userNumber = int.Parse(Console.ReadLine());
                    ReadNumbers(userNumber);
                    count++;
                }
                catch (ArgumentException aex)
                {
                    Console.WriteLine(aex.Message);
                    count = 0;
                }
                catch (OverflowException oEx)
                {
                    Console.WriteLine(oEx.Message);
                    count = 0;
                }
                catch (FormatException fEx)
                {
                    //Console.WriteLine(fEx.Message);
                    Console.WriteLine("non-number text is entered"); // here throws exception and
                    //the program continues user friendly
                    count = 0;
                    //throw new ArgumentException("non-number text is entered");-->here throw new EX 
                    //and the program is stoped, 
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    count = 0;
                }
            }            
        }

        public static void ReadNumbers(int userNumber) 
        {
            int startRange = 1;  //Allowed Range from 2 till 100

            int endRange = 100;  // [2...100 ] -- 10 numbers valid from the user


            if (userNumber <= startRange || userNumber >= endRange )
            {
                throw new ArgumentException("invalid number");
            }           
        }
    }
}
