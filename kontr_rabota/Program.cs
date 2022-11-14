Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string [] stringArray = new string [n];
void FillArray(string [] stringArray)
{
 for (int i = 0; i < stringArray.Length; i++)
 {
 stringArray[i] = Console.ReadLine();
 }
}
void PrintArray(string [] stringArray)
{
 for (int i = 0; i < stringArray.Length; i++)
 {
 Console.Write($"{stringArray [i]} ");
 }
}
FillArray(stringArray);
Console.WriteLine("Исходный массив:");
PrintArray(stringArray);
Console.WriteLine();
void StrArray(string [] stringArray)
{
 for (int i = 0; i < stringArray.Length; i++)
 {
    int count = stringArray[i].Count();
    if (count < 3)
    {
        Console.Write($"{stringArray [i]} ");
        count = 0;
    }
 }
}
Console.WriteLine("Новый массив:");
StrArray(stringArray);