Console.WriteLine("Введите число: ");
string num = Console.ReadLine();
Console.WriteLine("Введите в какой системе ваше число: ");
int sys = Convert.ToInt32(Console.ReadLine());

while (sys < 2 || sys > 10)
{
    Console.WriteLine("Система счисления должна быть введена числом от 2 до 10");
    Console.WriteLine("Введите систему заново: ");
    sys = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите систему счисления для перевода от 2 до 9: ");
int num_sys = Convert.ToInt32(Console.ReadLine());

while (num_sys < 2 || num_sys > 9)
{
    Console.WriteLine("Система счисления должна быть введена числом от 2 до 9");
    Console.WriteLine("Введите систему заново: ");
    num_sys = Convert.ToInt32(Console.ReadLine());
}

int vivod = 0;
int length = num.Length;
for (int i = 0; i < length; i++)
{
    char c = num[i];
    int user_int = c - '0';

    if (user_int < 0 || user_int >= sys)
    {
        Console.WriteLine($"Цифра '{c}' недопустима для системы!");
        return;
    }

    int position = length - i - 1;
    vivod += user_int * (int)Math.Pow(sys, position);
}

if (vivod == 0)
{
    Console.WriteLine($"Число в {num_sys}-ой системе: 0");
    return;
}

string result = "";

while (vivod > 0)
{
    int remainder = vivod % num_sys;
    result = remainder.ToString() + result;
    vivod = vivod / num_sys;
}

Console.WriteLine($"Число в {num_sys}-ой системе: {result}");
