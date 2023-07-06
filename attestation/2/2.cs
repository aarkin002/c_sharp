int wtf(int m, int n){
    int sum = 0;
    for(int i = m; i <=n; i++) {
        sum += i;
    }
    return sum;
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine(wtf(m, n));