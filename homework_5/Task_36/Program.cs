int[] CreateRandomArray(int N, int min, int max)
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] input = CreateRandomArray(5, 10, 100);

int Calculate(int[] input)
{
int sum = 0;
for (int i = 0; i < input.Length; i++)
{
    if (i % 2 != 0) sum = sum + input[i];
}
return sum;
}

int sum = Calculate(input);
string inputString = string.Join(", ", input);
Console.WriteLine($"[{inputString}] -> {sum}");
