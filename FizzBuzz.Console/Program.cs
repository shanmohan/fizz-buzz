using FizzBuzz.BusinessLogic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        private const string CONST_WELCOME_FIZZBUZZ = "Welcome to the FizzBuzz World..";
        /// <summary>
        /// Main Console Starting Point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            IFizzBuzzProcesser fizzBuzzService;
            ArrayList arrayFizzBuzzString;

            try
            {

                Console.WriteLine(CONST_WELCOME_FIZZBUZZ);
                fizzBuzzService = new FizzBuzzProcesser();
                arrayFizzBuzzString = fizzBuzzService.GetFizzBuzzString(0, 100);

                while (true)
                {
                    foreach (var item in arrayFizzBuzzString)
                    {
                        Console.WriteLine(item);
                    }
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
