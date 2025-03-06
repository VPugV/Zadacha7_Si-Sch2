Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine("Введите систему счисления вашего числа: ");
int sys = Convert.ToInt32(Console.ReadLine());
int cif = num.Length;
int vivod = 0;

while (sys < 2 || sys > 10)
{
    Console.WriteLine("Ошибка. Система счисления должна быть числом от 2 до 10");
    Console.WriteLine("Введите систему заново: ");
    sys = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("В какую систему счисления перевести? (от 2 до 9): ");
int con = Convert.ToInt32(Console.ReadLine());

while (con < 2 || con > 9)
{
    Console.WriteLine("Ошибка. Система счисления должна быть числом от 2 до 9");
    Console.WriteLine("Введите систему заново: ");
    con = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < cif; i++)
{
    char c = num[i];
    int C = c - '0';

    if (C < 0 || C >= sys)
    {
        Console.WriteLine($"Цифра '{c}' недопустима для системы");
        return;
    }

    int position = cif - i - 1;
    vivod += C * (int)Math.Pow(sys, position);
}

if (vivod == 0)
{
    Console.WriteLine($"Число в {con}-ой системе: 0");
    return;
}

string vivod2 = "";

while (vivod > 0)
{
    int remainder = vivod % con;
    vivod2 = remainder.ToString() + vivod2;
    vivod = vivod / con;
}

Console.WriteLine($"Число в {con} системе будет: {vivod2}");
