int[] numbers = new int[10]; //int array to store 10 numbers
int max = -2147483648; //int value range -2147483648 to 2147483647
int counter = 0; //int variable to store the times the max appears in the array

System.Console.WriteLine("Enter ten numbers: "); //Ask the user 10 numbers
        
for (int i = 0; i <= 9; i++) { //Go through all the indexes in the array
    numbers[i] = int.Parse(Console.ReadLine());  //Store values in every index 
                                                //of the array
    
    if (numbers[i] >= max) {  //Check if the number on the index i is greatest 
                             //or equal to max
        max = numbers[i]; //change the value of max to the number in index i
        counter++; //Increase the counter by 1
    }
}

Console.WriteLine("MAX: " + max);
Console.WriteLine("Repeated digit: " + (counter - 1));