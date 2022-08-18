string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
try
{
  CW("Задание 3. Программа, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.");

  int[] array = new int[8];
  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(0, 2);

  CW("[" + string.Join(",", array) + "]");
}
catch { CW("Вы ввели некорректное значение."); }