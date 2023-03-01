
double a;
double b;
double c;

Console.WriteLine("Квадратичная функция - y= ax^2 + bx + c");
Console.WriteLine("Введите число а");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число b");
b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите число с");
c = Convert.ToDouble(Console.ReadLine());

double x0 = -b / (2 * a);
Console.WriteLine($"x0 = {x0}");
double y0 = a * Math.Pow(x0, 2) + b * x0 + c;
Console.WriteLine($"y0 = {y0}");
double d = Math.Pow(b, 2) - 4 * a * c;


Console.WriteLine(" ");


if (a > 0)
{
    Console.WriteLine(" Ветви направлены вверх");

}

else if (a < 0)
{

    Console.WriteLine(" Ветви направлены вниз");

}

Console.WriteLine(" ");


if (a > 0)
{

    Console.WriteLine($" Минимальное значение:{y0} ");
    


}

else if (a < 0)
{

    Console.WriteLine($" Максимальное значение: {y0} ");


}




if (a > 0)
{
    Console.WriteLine($" Убывает от -беск : {-x0}; Возрастает от {-x0} : беск");
  

}

else if (a < 0)
{

    Console.WriteLine($" Возрастает от -беск : {-x0}; Убывает от {-x0} : беск");

}

if (d <= 0)
{
    Console.WriteLine($"{a > 0}Функция всегда всегда положительна");

}
else if (d <= 0)
{

    Console.WriteLine($"{a < 0}Функиця всегда отрицательна");

}


double x1 = -b + Math.Sqrt(d) / 2 * a;
double x2 = -b - Math.Sqrt(d) / 2 * a;

if (d >= 0)
{



    Console.WriteLine(x1);


    Console.WriteLine(x2);


}
