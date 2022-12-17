// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string DataEntry(string text)
{
    Console.Write(text);
    string result = Console.ReadLine();
    return result;
}

string output = string.Empty;
string number = DataEntry("Введите число (если хотите закончить ввод нажимите ENTER): ");
int num = 0;
int count = 0;
while (number!="")
{
    num = Convert.ToInt32(number);
    output = output+"| " +num + " |";
    if (num>0) count++;
    number = DataEntry("Введите число (если хотите закончить ввод нажимите ENTER): ");
}
Console.WriteLine($"Вы ввели следующие числа: {output} из них {count} больше 0");