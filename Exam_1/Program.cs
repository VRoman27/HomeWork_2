/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.*/

bool isParsed = false;
int num = 0;

while (!isParsed | !(num < 1000 & num > 99))
{
    Console.Write("Введите число: ");
    isParsed = int.TryParse(Console.ReadLine(), out num);
}

int midDigit = (num % 100)/10;

Console.WriteLine(midDigit);