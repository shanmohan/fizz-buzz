using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.BusinessLogic
{
    public class FizzBuzzProcesser : IFizzBuzzProcesser
    {

        #region Private Variables

        private const string CONST_FIZZ_BUZZ = "FizzBuzz";
        private const string CONST_FIZZ = "Fizz";
        private const string CONST_BUZZ = "Buzz";

        #endregion

        #region Public Methods
        /// <summary>
        /// Method which outputs the list of fizz-buzz string 
        /// </summary>
        /// <param name="rangeFrom">Starting range</param>
        /// <param name="rangeTo">Ending range</param>
        /// <returns></returns>
        public ArrayList GetFizzBuzzString(int rangeFrom, int rangeTo)
        {
            ArrayList arrayResult = new ArrayList();

            try {

                //Validate the Input args
                if (!IsRangeArgsValid(rangeFrom, rangeTo))
                {
                    return arrayResult;
                }
                else
                {
                    //Process the FizzBuzz
                    for (int i = rangeFrom; i <= rangeTo; i++)
                    {
                        bool isFizz = (i % 3 == 0);
                        bool isBuzz = (i % 5 == 0);

                        if (i == 0)
                        {
                            arrayResult.Add(i.ToString());
                        }
                        else if (isFizz && isBuzz)
                        {
                            arrayResult.Add(CONST_FIZZ_BUZZ);
                        }
                        else if (isFizz)
                        {
                            arrayResult.Add(CONST_FIZZ);
                        }
                        else if (isBuzz)
                        {
                            arrayResult.Add(CONST_BUZZ);
                        }
                        else
                        {
                            arrayResult.Add(i.ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Opops. An error occured. Unable to process the fizz-buzz string");
            }

            return arrayResult;
        }

        #endregion

        #region Private Methods
        /// <summary>
        /// Validate the input arguments
        /// </summary>
        /// <param name="rangeFrom">Starting range</param>
        /// <param name="rangeTo">Ending range</param>
        /// <returns></returns>
        private bool IsRangeArgsValid(int rangeFrom, int rangeTo)
        {
            bool result = true;
            try
            {

                //validation # 1 Check for negative and invalid combinations
                if (rangeFrom < 0 || rangeTo < 0 || (rangeFrom > rangeTo))
                {
                    result = false;
                }
            }catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        #endregion
    }
}