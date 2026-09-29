Console.WriteLine("Введите размер массива:");
var nuum = int.Parse(Console.ReadLine());
int[] numbers = new int[nuum];

Console.WriteLine("Введите числа массива, по одному числу");
for (int i = 0; i < nuum; i++)
{
  Console.Write($"numbers[{i}] = ");
  numbers[i] = int.Parse(Console.ReadLine());
}

var num = new ClsMath();

Console.WriteLine($"{num.sum(numbers)}");
Console.WriteLine($"{num.count(numbers)}");
Console.WriteLine($"{num.max(numbers)}");
Console.WriteLine($"{num.min(numbers)}");
    public class ClsMath
    {
      public double sum(int[] numbers)
    {
      var result = 0;
      foreach (var number in numbers)
      {
        result += number;
      }
      return result;
    }
    public double count(int[] numbers)
    {
      return numbers.Length;
    }
    public double max(int[]numbers)
    {
      var result = 0;
      foreach(var number in numbers)
      {
        if (number > result)
        {
          result = number;
        }
      }    
      return result;
    }
    public double min(int[]numbers)
    {
      var result = 0;
      foreach(var number in numbers)
      {
        if(number < result)
        {
          result = number;
        }
      }
      return result;
    }
    }