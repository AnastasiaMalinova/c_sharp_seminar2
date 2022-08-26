// Напишите программу, которая выводит случайное трехзначное число и удалят вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

// Console.Clear();
// int number = new Random().Next(100, 1000); 
// Console.WriteLine(number);
// Console.WriteLine(number/100*10 + number%10);

// Напишите программу, которая будет принимать на вход 2 числа и выводить, является ли второе число 
// кратным первому. Если число 2 не кратно числу 1, то то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.Write("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a%b == 0)
// {
//     Console.Write($"{a}, {b} -> кратно");
// }
// else 
// {
//     Console.Write($" не кратно, остаток {a%b}");
// }


// Напишите программу, которая на вход принимает число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число:");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number%7 == 0 && number%23 == 0)
// {
//     Console.WriteLine ($"{number} -> да");
// }
// else {
//     Console.WriteLine ($"{number} -> нет");
// }

// Напишите программу, которая принимает на вход два числа и проверяет является ли одно число 
// квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8, 9 -> да

// Console.Clear();
// Console.Write("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());

// if (a*a == b)
// {
//     Console.Write($"{a}, {b} -> да");
// }
// else if (b*b == a)
// {
//     Console.Write($"{a}, {b} -> да");
// }
// else
// {
//     Console.Write($"{a}, {b} -> нет");
// }

// альтернативное решение:
// Console.Write("Введите первое число:");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int b = Convert.ToInt32(Console.ReadLine());

// Pow метод возводит в степень то значение, которое мы напишем первым, потом цифра в которую мы возводим.
// || условие или
// if (a == Math.Pow(b, 2) || b == Math.Pow(a, 2))
// {
//    Console.Write($"{a}, {b} -> да"); 
// }
// else
// {
//     Console.Write($"{a}, {b} -> нет");
// }


// Генерируется случайное целое число n в интервале [ 20 – 99 ].
// Проверяется, делится ли оно на введенное с клавиатуры целое число d
// (используйте тернарный оператор).

// int n = new Random().Next(20, 100);
// Console.WriteLine(n);
// Console.WriteLine("Введите целое число");
// int d = Convert.ToInt32(Console.ReadLine());

// if (n%d == 0)
// {
//     Console.Write("Случайное число делится на введенное");
// }
// else {
//     Console.Write("Случайное число не делится на введенное");
// }


// Введенная цифра (от 0 до 5) выводится прописью (оператор switch).

// Console.WriteLine("Input number from 0 to 5: ");
// int num = Convert.ToInt32(Console.ReadLine());
// switch(num) // оператор switch проверяет выражение
// {
//     case 0: Console.WriteLine("zero"); break;
//     case 1: Console.WriteLine("one"); break;
//     case 2: Console.WriteLine("two"); break;
//     case 3: Console.WriteLine("three"); break;
//     case 4: Console.WriteLine("four"); break;
//     case 5: Console.WriteLine("five"); break;
//     default: Console.WriteLine("Incorrect number"); break;
// }