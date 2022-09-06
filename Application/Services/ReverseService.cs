using Application.Interfaces;

namespace Application.Services
{
    public class ReverseService : IReverseService
    {
        public string ReverseString(string str) => new string(str.Reverse().ToArray());

        public double SquareDigit(double digit)
        {
            if (digit < 0)
                throw new InvalidOperationException("value cannot be less than zero");

            return Math.Sqrt(digit);
        }
    }
}
