namespace Homework
{
    public class Program
    {
        public static void Main()
        {
            var gui = new GUIConsolApp();
            var clsMath = new ClsMath();

            double[] numbers = { };

            numbers = gui.GetArray(numbers);

            Console.WriteLine($"{clsMath.sum(numbers)}");
            Console.WriteLine($"{clsMath.count(numbers)}");
            Console.WriteLine($"{clsMath.max(numbers)}");
            Console.WriteLine($"{clsMath.min(numbers)}");
        }
    }

}