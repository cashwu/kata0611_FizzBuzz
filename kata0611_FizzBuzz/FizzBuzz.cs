namespace kata0611_FizzBuzz
{
    internal class FizzBuzz
    {
        public string GetValue(int input)
        {
            var result = string.Empty;
            
            if (IsDivided3(input))
            {
                result += "Fizz";
            }
            if (IsDivided5(input))
            {
                result += "Buzz";
            }
            if (string.IsNullOrEmpty(result))
            {
                result = input.ToString();
            }

            return result;
        }

        private static bool IsDivided5(int input)
        {
            return input % 5 == 0;
        }

        private static bool IsDivided3(int input)
        {
            return input % 3 == 0;
        }
    }
}