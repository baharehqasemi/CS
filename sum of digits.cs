int num, sum = 0, r;

Console.WriteLine("Enter a number: ");
num = int.Parse(Console.ReadLine());.

      while (num != 0) {
            r = num % 10;
            num = num / 10;
            sum = sum + r;
      }
      Console.WriteLine("Result: " + sum);
      Console.ReadLine();
 