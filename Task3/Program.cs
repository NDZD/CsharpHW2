// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.



string CheckDayOfWeek(int number){
    string a = "Выходной день";
    string b = "Будний день";
    System.Console.WriteLine(number + " - день недели");
    if(number == 6 || number == 7){
        return a;
    }
    else{
        return b;
    }
    
}
System.Console.WriteLine(CheckDayOfWeek(new Random().Next(1, 8)));