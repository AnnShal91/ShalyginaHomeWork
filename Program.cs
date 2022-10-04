
/*

// Задача 1. Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("Input a first nunber:  ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second nunber: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if(n1 > n2)
    Console.WriteLine("Max = " + n1 + " Min = " + n2);
else
    Console.WriteLine("Max = " + n2 + " Min = " + n1);
*/

/*
// Задача 2. Напишите программу, которая принимает три числа и выдает максимальное из них.

Console.Write("Input a first nunber:  ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second nunber: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third nunber:  ");
int n3 = Convert.ToInt32(Console.ReadLine());
int Max;

if(n1 > n2)
    Max = n1;
else
    Max = n2;
if(n3 < Max)
    Console.WriteLine("Максимальное = " + Max );
else  
    Console.WriteLine("Максимальное = " + n3 );
*/

/*
// Задача 3. Напишите программу, которая принимает число и выдает, является ли число четным.

Console.Write("Input a nunber:  ");
int n = Convert.ToInt32(Console.ReadLine());

if(n%2 == 0)
    Console.WriteLine("Число является четным");
else
    Console.WriteLine("Число является нечетным");
    
*/

//Задача 4.  Напишите программу, которая на вход принимает число, а на выходе показываетвсе четные числа от 1до n1

Console.Write("Input a nunber:  ");
int n = Convert.ToInt32(Console.ReadLine());
int current = 1;

while(current < n)

    if(current%2 == 0)
        {
            Console.Write(current + " ");
            current++; 
        }
    else
        current++ ;