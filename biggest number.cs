int[] numbers = new int [10];
int max = -2147483648; //int value range -2147483648 to 2147483647
	
System.Console.WriteLine("Enter ten numbers: ");
        
for (int i = 0; i <= 9; i++) {
    numbers[i] = int.Parse(Console.ReadLine());
}
    
for (int i = 0; i <= 9; i++) {
    if (numbers[i] >= max){
        max = numbers[i];
    }
}

Console.WriteLine("MAX: " + max);