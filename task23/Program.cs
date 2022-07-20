Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Таблица кубов: ");
for (int i = 0; i < number; i++) {
    Console.Write($"{Math.Pow(i+1, 3)} ");
}