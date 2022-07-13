int[] numbers = new int [10];
int max = -2147483648; //int value range -2147483648 to 2147483647
int index = 0;
int max2 = -2147483648;
	
System.Console.WriteLine("Enter ten numbers: ");
        
for (int i = 0; i <= 9; i++) {
    numbers[i] = int.Parse(Console.ReadLine());
}
    
for (int i = 0; i <= 9; i++) { 
    if (numbers[i] >= max) {
        max = numbers[i];
    }
}

for (int i = 0; i <= 9; i++) {
    if (numbers[i] == max) {
        index = i;
    } 
}

numbers[index] = -2147483648; //Change that value to -2147483648

for (int i = 0; i <= 9; i++) {
    if (numbers[i] >= max2) { //Search for the new max
        max2 = numbers[i]; //Store the value of the new max
    } 
}

Console.WriteLine("MAX: " + max);
Console.WriteLine("2nMAX: " + max2);