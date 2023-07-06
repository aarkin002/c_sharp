void wtf(int m, int n){
    for(int i = m; i <=n; i++) {
        Console.WriteLine(i);
    }
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
wtf(m, n);