string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
string CR()
{
  return Console.ReadLine();
}
try
{
  CW("Задание 1. Программа, которая принимает на вход число и выдает количество цифр в числе.");
  string number = CR();
  number = (Math.Abs(Int32.Parse(number))).ToString();
  CW($"Количество цифр в числе: {number.Length}.");
}
catch { CW("Вы ввели некорректное значение."); }