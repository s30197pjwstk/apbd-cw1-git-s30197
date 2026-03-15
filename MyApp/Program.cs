Console.WriteLine("Welcome to Statistics App!");
Console.WriteLine("Enter 5 numbers:");

int[] numbers = new int[5];

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Number " + (i + 1) + ": ");
    numbers[i] = int.Parse(Console.ReadLine());
}

int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum = sum + numbers[i];
}

Console.WriteLine("Sum = " + sum);

double average = (double)sum / numbers.Length;
Console.WriteLine("Average = " + CalculateAverage(numbers));
Console.WriteLine("Max = " + CalculateMax(numbers));
Console.WriteLine("Min = " + CalculateMin(numbers));

static double CalculateAverage(int[] values)
{
    int s = 0;
    for (int i = 0; i < values.Length; i++)
    {
        s = s + values[i];
    }
    return (double)s / values.Length;
}

static int CalculateMax(int[] values)
{
    int max = values[0];
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] > max)
        {
            max = values[i];
        }
    }
    return max;
}

static int CalculateMin(int[] values)
{
    int min = values[0];
    for (int i = 1; i < values.Length; i++)
    {
        if (values[i] < min)
        {
            min = values[i];
        }
    }
    return min;
}