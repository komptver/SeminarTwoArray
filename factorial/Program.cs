/*Example1. Принимаем число факториал которого нужно вычеслить
int Factorial (int n)
{
    // 1! = 1
    // 0! = 1
    if(n==1) return 1; //если 1, то возвращаем 1
    else return n * Factorial(n-1); // если не 1, то  n * Factorial(n-1)
}

Console.Write(Factorial(3)); // 1*2*3 = 6
*/
// Example2. Принимаем число i и находим из числа I факториал
double Factorial (int n)
{
    if (n==1) return 1;
    else return n * Factorial(n-1);
}
for (int i=1; i < 40; i++) // будет переполнение, поэтому вместо int пишем double
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}