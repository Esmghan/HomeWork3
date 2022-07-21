Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
 
string FiveDigit = n.ToString();

if (n>99999 || n<10000) {
    Console.WriteLine("Число не соответствует условию задачи");}

else if(FiveDigit[0] == FiveDigit[4] && FiveDigit[1] == FiveDigit[3]) {
    Console.WriteLine ($"Числo {n} является палиндромом");}

else {
    Console.WriteLine ($"Число {n} - не палиндром");
}

