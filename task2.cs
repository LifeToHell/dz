//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

Console.WriteLine("Напишите первое число");

uint a = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Напишите второе число");

uint b = Convert.ToUInt32(Console.ReadLine());

Console.WriteLine("Напишите треть число");

uint c = Convert.ToUInt32(Console.ReadLine());

uint max = a;

if(b > a) { max = b;

}
if(c > b) { max = c;

}

Console.WriteLine(max);


