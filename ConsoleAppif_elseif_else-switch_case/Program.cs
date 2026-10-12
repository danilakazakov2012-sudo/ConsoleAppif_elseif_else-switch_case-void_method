/*Console.WriteLine("Условная конструкция if_elseif_else");
Console.WriteLine("Введите значение");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 <= 10)
{
    Console.WriteLine($"{num1} больше нуля");
}
else if (num1 >100)
{
    Console.WriteLine($"{num1} больше ста");
}
else if(num1 == 0)
        {
    Console.WriteLine($"{num1} равно нулю");
}
else
{
    Console.WriteLine($"{num1} меньше нуля!");

}*/


//Console.WriteLine(("Время дня"));
//int hour = Convert.ToInt32(Console.ReadLine());

//if (hour >= 6 &&  hour <= 12)
//{
//    Console.WriteLine("Доброе утро");
//}
//else if (hour > 12 && hour <= 18)
//{
//    Console.WriteLine("Добрый день");
//}
//else if (hour > 18 && hour <= 23)
//{
//    Console.WriteLine("Дорый вечер");
//}
//else if (hour == 24)
//{
//    Console.WriteLine("Полночь");
//}
//else if (hour > 6)
//{
//    Console.WriteLine("Доброй ночи");
//}


/*Console.WriteLine("Начало игры.Выберите один из пунктов!");
Method1();
Console.WriteLine("1.Начало игры!");
Method1();
Console.WriteLine("2.Загрузить игру!");
Method1();
Console.WriteLine("3.Выход из игры!");
Method1();
string game = Console.ReadLine();

switch (game)
{
    case "1":
        Console.WriteLine("Вход в игру!");
        break;
        case "2":
        Console.WriteLine("Загрузка игры начата!");
        break;
    case "3":
        Console.WriteLine("Выход из игры");
        break;
}*/


void Method2(string name,int age)
{
    //Console.WriteLine($"Ваше имя:{name}, Ваш возраст:{age}");
    if (age > 18)
    {
        Console.WriteLine($"{name} Вам больше 18!");
    }
    else
    {
        Console.WriteLine($"{name} Вам меньше 18!");
    }
}
Method2("danya", 13);
