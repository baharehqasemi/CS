int n;
int sum = 0;
	
Console.WriteLine($"Select a number:");
n = int.Parse(Console.ReadLine());
 
for (int i = 1; i <= n; i++) {
	sum = sum + i;
    //sum += i; is the same thing
}
		
Console.WriteLine("Total sum: "+sum);