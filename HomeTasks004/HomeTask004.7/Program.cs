string CW(string msg)
{
  Console.WriteLine(msg);
  return msg;
}
try
{
  CW("Задание 7. Программа, в которой задается массив чисел и выдаёт произведение чисел от 1 до N, каждого элемента этого массива.");

  int[] array = new int[9];
  int product;
  Random rand = new Random();

  for (int i = 0; i < array.Length; i++)
    array[i] = rand.Next(1, 10);

  CW("Исходный массив: [" + string.Join(",", array) + "]");

  for (int i = 0; i < array.Length; i++)
  {
    product = 1;
    for (int j = 1; j <= array[i]; j++)
    {
      product = product * j;
    }
    array[i] = product;
  }
  CW("Массив факториалов: [" + string.Join(",", array) + "]");
}
catch { CW("Вы ввели некорректное значение."); }