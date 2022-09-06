Console.WriteLine("Введите числа через запятую");
string numberStr = Console.ReadLine();

string[] numbers = numberStr.Split(',');

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (int.Parse(numbers[i]) > 0)
    {
        count++;
    }
}
Console.WriteLine("Количество чисел больше нуля = {0}",count);
