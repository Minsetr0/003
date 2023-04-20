Random random = new Random();
int arraySize = 30;
int[] numbers = new int[arraySize];
int maxNumberInArray = 31;
int minNumberInArray = 0;
int rightNeighbor = 1;
int leftNeighbor = -1;

Console.Write("Все локальные максимумы: ");

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = random.Next(minNumberInArray, maxNumberInArray);
}

if (numbers[0] > numbers[0 + rightNeighbor])
{
    Console.Write(numbers[0] + " ");
}

for (int i = 1; i < numbers.Length - 1; i++)
{
    if (numbers[i] > numbers[i + leftNeighbor] && numbers[i] > numbers[i + rightNeighbor])
    {
        Console.Write(numbers[i] + " ");
    }
}

if (numbers[numbers.Length - 1] > numbers[numbers.Length + leftNeighbor - 1])
{
    Console.Write(numbers[numbers.Length - 1] + " ");
}
