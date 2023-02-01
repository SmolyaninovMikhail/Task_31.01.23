// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
int count = 0;

void InputArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine($"Начальные элементы: [{string.Join(", ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine($"Чисел больше 0: {count}");