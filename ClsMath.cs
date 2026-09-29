int[] numbers = {1,2,3,4};
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