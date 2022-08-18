string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
try
{
  CW("Задание 6. Программа, которая задаёт массив из 8 элементов и выводит их на экран.");

  int[] array = new int[8];
  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(0, 100);

  CW("[" + string.Join(",", array) + "]");
}
catch { CW("Вы ввели некорректное значение."); }