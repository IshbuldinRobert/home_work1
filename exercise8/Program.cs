// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. [1; N)

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int i = 2;
string s = "Четные числа до введенного числа: ";
string a = " "; // через тип char не получилось :( с конвертацией пока слабоват
while (i < num)
{
    s = s + i + a;

    i = i + 2;
}
Console.WriteLine(s);