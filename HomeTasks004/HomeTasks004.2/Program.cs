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
  CW("Задание 2. Программа, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.");
  CW("Введите число: ");
  int number = Int32.Parse(CR());
  int result = 1;
  for (int i = 1; i <= number; i++)
    result = i * result;
  CW($"Произведение чисел от 1 до {number}: {result}");
}
catch { CW("Вы ввели некорректное значение."); }