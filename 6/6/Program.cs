﻿Console.WriteLine("Введите число от 1 до 5:");
double eee = Convert.ToDouble(Console.ReadLine());
switch (eee)
{
    case 1:
        Console.WriteLine("Плохо");
        break;
    case 2:
        Console.WriteLine("Неудовлетворительно");
        break;
    case 3:
        Console.WriteLine("Удовлетворительно");
        break;
    case 4:
        Console.WriteLine("Хорошо");
        break;
    case 5:
        Console.WriteLine("Отлично");
        break;
    default:
        Console.WriteLine("Введите число от 1 до 5!!!");
        break;

}
