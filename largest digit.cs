int num;
int r;
int largest = 0;

 System.Console.WriteLine("Enter a number");
 num = int.Parse(Console.ReadLine());

  while (num > 0) {
    r = num % 10;

    if (largest < r) {
     largest = r;
    }
    num = num / 10;
}
System.Console.WriteLine("The largest digit is: " + largest);
 
