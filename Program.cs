using System;
using static System.Console;

WriteLine("Задача №64");
WriteLine();

string PrintNumbers (int m, int n){
    if(m == n) return m.ToString();
    string str = m.ToString() + " " + PrintNumbers(m - 1, n) ;
    return str;
}

Write("Введите первое число: ");
int number1 = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int number2 = Convert.ToInt32(ReadLine());

WriteLine($"Все числа в диапазоне ({number1}, {number2}) -> {PrintNumbers(number1, number2)}");

WriteLine();
WriteLine("Задача №66");
WriteLine();

int SumNumbers (int n){
    if(n == 0) return 0;
    else return n + SumNumbers(n - 1);
}

Write("Введите число: ");
int num = int.Parse(ReadLine()!);

WriteLine();
WriteLine($"Сумма чисел от 1 до {num} -> {SumNumbers(num)}");

WriteLine();
WriteLine("Задача №68");
WriteLine();

int Akkerman (int a, int b){
    if(a == 0) return b + 1;
    else if(b == 0) return Akkerman(a - 1, 1);
    else return Akkerman(a - 1, Akkerman(a, b - 1));
}

Write("Введите первое число: ");
int n1 = int.Parse(ReadLine()!);

Write("Введите второе число: ");
int n2 = int.Parse(ReadLine()!);

WriteLine($"Функция Аккермана: {Akkerman(n1,n2)}");
