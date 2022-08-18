string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
string CR()
{
  return Console.ReadLine();
}

void sum(string number, out string numberstr)
{
  int sum = 0;
  for (int i = 0; i < number.Length; i++)
    sum = sum + Int32.Parse(number[i].ToString());
  numberstr = sum.ToString();
}

try
{
  CW("Задание 5. Программа, которая принимает на вход число и выдаёт сумму цифр в числе.");
  string number = CR();
  string numberstr = "";
  sum(number, out numberstr);

  CW($"Cумму цифр в числе: {numberstr}");
}
catch { CW("Вы ввели некорректное значение."); }