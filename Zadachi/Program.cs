

//Домашняя работа:

//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*Console.WriteLine ("Введите первое число:");
int numA = int.Parse (Console.ReadLine()!);

Console.WriteLine ("Введите второе число:");
int numB = int.Parse (Console.ReadLine()!);
if(numA>numB){

    Console.WriteLine($"максимальным числом является {numA}, а минимальным числом является {numB}");
}
    else
{
    Console.WriteLine($"максимальным числом является {numB}, а минимальным числом является {numA}");
}*/


//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.


/*Console.WriteLine ("Введите первое число:");
int num1 = int.Parse (Console.ReadLine ()!);

Console.WriteLine ("Введите второе число:");
int num2 = int.Parse (Console.ReadLine ()!);

Console.WriteLine ("Введите третье число:");
int num3 = int.Parse (Console.ReadLine ()!);

int max = num1;
if (max < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}

Console.WriteLine ($"Максимальным числом является {max}");*/



//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*Console.WriteLine ("Введите число:");
int number = int.Parse (Console.ReadLine()!);

if(number % 2 == 0)
{
    Console.WriteLine($"Да! число {number} чётное");
}
    else
{

    Console.WriteLine($"Нет! число {number} не чётное");

}  */ 


//Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

/*Console.WriteLine ("Введите число: ");
int N = int.Parse (Console.ReadLine()!);
int i = 1;
while (i <= N)
{
    if (i % 2 == 0)
    {
        Console.Write ($" {i} ");
    }
    i++;
}*/