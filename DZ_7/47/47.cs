double[,] createArr (int m , int n){
    Random rnd = new Random();
    double[,] table = new double[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            table[i, j] = rnd.Next(101,1001)*0.01;
        }
    }
    return table;
}

Console.WriteLine ("Введите m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите n: ");
int n = int.Parse(Console.ReadLine());
double[,] arr = createArr(m, n);

for (int i = 0; i < m; i++){
    for(int j = 0; j < n; j++){
        Console.Write("{0} ", string.Join(", ", arr[i,j]));
    }
    Console.WriteLine ("");
}