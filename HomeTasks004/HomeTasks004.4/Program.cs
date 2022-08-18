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
  CW("Задание 4. Программа, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");

  int firstNumber = Int32.Parse(CR());
  int secondNumber = Int32.Parse(CR());
  int numberDegree = 1;

  for (int i = 0; i < secondNumber; i++)
    numberDegree = numberDegree * firstNumber;

  CW($"Число {firstNumber} в степени {secondNumber} = {numberDegree}");
}
catch { CW("Вы ввели некорректное значение."); }