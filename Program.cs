Random random = new Random();
int[] array = new int[30];
int firstNumberInArray = 0;
int maxNumberInArray = 31;
int minNumberInArray = 0;
int rightNeighbor = 1;
int leftNeighbor = -1;

Console.Write("Все локальные максимумы: ");

for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(minNumberInArray, maxNumberInArray);
}

if (array[firstNumberInArray] > array[firstNumberInArray + rightNeighbor])
{
    Console.Write(array[firstNumberInArray] + " ");
}


for (int i = 1; i < array.Length - 1; i++)
{
    if (i != firstNumberInArray && i != array.Length)
    {
        if (array[i] > array[i + leftNeighbor] && array[i] > array[i + rightNeighbor])
        {
            Console.Write(array[i] + " ");
        }
    }
}

if (array[array.Length - 1] > array[array.Length + leftNeighbor - 1])
{
    Console.Write(array[array.Length - 1] + " ");
}
