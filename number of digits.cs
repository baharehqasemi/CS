int num = 0;
int counter = 0;

Console.WriteLine("Enter the number: ");
num = int.Parse(Console.ReadLine());



 while(num != 0) {
         num = num / 10;
         counter++;
      }

Console.WriteLine("Number of digits: " + counter);
