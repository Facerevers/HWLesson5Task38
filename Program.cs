// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void ShowResult(double[] mas)
{
    double max = mas[0];
    double min = mas[0];
    int i = 0;
    int j = 1;
    for (i = 0; i < mas.Length; i++)
    {
        for (j = i+1; j< mas.Length; j++)
        {
            if (mas[i] < mas[j] & max < mas[j]) {max = mas[j];}
            if (mas[i] > mas[j] & min > mas[j]) {min = mas[j];}
        }
    }
    Console.WriteLine($"{max} - {min} -> {max-min}");
}

double[] GetMas(int number)
{
    double[] mas = new double[number];
    for (int i = 0; i < number; i++)
    {
        mas[i] = Math.Round(new Random().NextDouble()*100,2);
    }
    return mas;
}

int GetInput(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = GetInput("Введите количество чисел массива: ");
double[] mas = GetMas(number);
Console.WriteLine($"Массив [{String.Join(", " , mas)}]");
ShowResult(mas);