// Console.Write("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write("Таблица кубов: ");
// for (int i = 0; i < number; i++) {
//     Console.Write($"{Math.Pow(i+1, 3)} ");
// }

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

int [] cubes = new int[N];
Console.Write("Таблица кубов: ");
int i = 0;
while(i < N){
    cubes[i] = (i+1)*(i+1)*(i+1);
    Console.Write($"{cubes[i]} ");
    i++;
}
