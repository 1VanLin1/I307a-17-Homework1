namespace Homework
{
    public class ClsMath
    {
        public double sum(double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                result += number;
            }
            return result;
        }
        public double count(double[] numbers)
        {
            return numbers.Length;
        }
        public double max(double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                if (number > result)
                {
                    result = number;
                }
            }
            return result;
        }
        public double min(double[] numbers)
        {
            double result = 0;
            foreach (var number in numbers)
            {
                if (number < result)
                {
                    result = number;
                }
            }
            return result;
        }
    }
}