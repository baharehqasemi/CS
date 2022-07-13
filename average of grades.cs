int[] grades = new int [10]; //Array grades with 10 positions to store grades
int avg = 0; //int variable to store the value of the average
int sum = 0; //int variable to store the sum of the grades above 15
int counter = 0; //int variable to store the number of grades above 15

System.Console.WriteLine("Enter the grades: ");
        
for (int i = 0; i <= 9; i++) {
    grades[i] = int.Parse(Console.ReadLine());

    if (grades[i] >= 15) {
      sum += grades[i];
      counter++;
    }
}

avg = sum/counter;

Console.WriteLine($"average: " + avg);