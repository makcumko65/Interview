using Application.Interfaces;

namespace Application.Services
{
    public class ReverseResolver : IReverseResolver
    {
        private readonly IReverseService reverseService;

        public ReverseResolver(IReverseService reverseService)
        {
            this.reverseService = reverseService;
        }

        public string Reverse(string data)
        {
            var isDigit = double.TryParse(data, out var digit);

            var res = isDigit ?
                reverseService.SquareDigit(digit).ToString()
                : reverseService.ReverseString(data);

            return res;
        }
    }
}
