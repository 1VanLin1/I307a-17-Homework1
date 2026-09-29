namespace Homework
{
    public class GUIConsolApp
    {
        public double[] GetArray(double[] numbers)
        {
            Console.Write("Enter Count of element: ");
            var arraylength = int.Parse(Console.ReadLine());
            numbers = new double[arraylength];
            for (int i = 0; i < arraylength; i++)
            {
                Console.Write($"Enter value of element {numbers[i]}: ");
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }
            return numbers;
        }
    }
}