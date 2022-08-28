// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6


System.Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

while (num / 10 >= 100){
    num = num /10;
}
if(num / 10 > 9 && num / 10 < 100){
    System.Console.WriteLine(num % 10);
}
else{
    System.Console.WriteLine("Третьей цифры нет");
}
