Console.WriteLine("Enter the score (-1 to exit) : ");
int grade = 0;
int count = 0; 
int sum = 0;
int highest = 0;
int lowest = 100;
while (true)
{
    grade = int.Parse(Console.ReadLine());

    if (grade == -1)
        break;

    sum += grade;
    count++;

    if (grade > highest)
        highest = grade;

    if (grade < lowest)
        lowest = grade;
}
Console.WriteLine("Count: " + count);
Console.WriteLine("Sum: " + sum);
if (count > 0)
{
    Console.WriteLine("Average: " + (double)sum / count);
    Console.WriteLine("Highest: " + highest);
    Console.WriteLine("Lowest: " + lowest);
}
