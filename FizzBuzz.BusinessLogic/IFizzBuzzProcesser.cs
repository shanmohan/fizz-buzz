using System.Collections;

namespace FizzBuzz.BusinessLogic
{
    public interface IFizzBuzzProcesser
    {
        ArrayList GetFizzBuzzString(int rangeFrom, int rangeTo);
    }
}