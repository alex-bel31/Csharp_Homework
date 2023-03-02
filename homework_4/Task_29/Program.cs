Console.Write("Введите количество элементов массива: ");
int countElem = int.Parse(Console.ReadLine());
int [] array = new int[countElem];
     
Random myRandom = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(0, 20);
    Console.Write("{0}, ", array[i]);
}