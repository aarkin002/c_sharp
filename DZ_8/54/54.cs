int[,] createArr (int m , int n){
    Random rnd = new Random();
    int[,] table = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            table[i, j] = rnd.Next(1, 9);
        }
    }
    return table;
}

void sortArr(int[,] arr ,int col){
    Comparer<int> comparer = Comparer<T>.Default;
    Array.Sort<int[,]>(arr, (x,y) => comparer.Compare(x[col],y[col]));
}

Console.WriteLine ("Массив: ");
int[,] arr = createArr(3, 4);
for (int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
        Console.Write("{0} ", string.Join(", ", arr[i,j]));
    }
    Console.WriteLine ("");
}

sortArr(arr);





Console.WriteLine ("Массив: ");
for (int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
        Console.Write("{0} ", string.Join(", ", arr[i,j]));
    }
    Console.WriteLine ("");
}