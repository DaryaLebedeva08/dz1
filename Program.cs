/* 1) Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 

Console.WriteLine ("Введите первое число");
string firstNumber = Console.ReadLine ();
Console.WriteLine ("Введите второе число");
string secondNumber = Console.ReadLine ();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);

if (firstNum<secondNum)
Console.WriteLine ($"максимальное {secondNum}");
else 
Console.WriteLine ($"максимальное {firstNum}"); 

2) Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 

Console.WriteLine ("Введите первое число");
string firstNumber = Console.ReadLine ();

Console.WriteLine ("Введите второе число");
string secondNumber = Console.ReadLine ();

Console.WriteLine ("Введите третье число");
string thirdNumber = Console.ReadLine ();

int firstNum = int.Parse(firstNumber);
int secondNum = int.Parse(secondNumber);
int thirdNum = int.Parse(thirdNumber);

if (firstNum>secondNum)
 
    if (firstNum>thirdNum)
       Console.WriteLine ($"{firstNum}");
    else 
        Console.WriteLine ($"{thirdNum}");
 
else
    if 
    
        (firstNum>thirdNum)
        Console.WriteLine ($"{firstNum}");
    else 
        Console.WriteLine ($"{thirdNum}"); 
    

3) Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

if (number%2 ==0)

    Console.WriteLine("да");

else
    Console.WriteLine ("нет"); 

4) Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8 */


