// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет
// string a = "Пн";
// string b = "Вт";
// string c = "Ср";
// string d = "Чт";
// string e = "Пт";
// string f = "Сб";
// string g = "Вс";
// string [] array = new string[7] {a, b, c, d, e, f, g};
// System.Console.WriteLine(array[6]);

// System.Console.WriteLine("Введите цифрой день недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

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