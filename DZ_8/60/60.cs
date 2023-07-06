int[,,] createArr (int m , int n, int l){
    Random rnd = new Random();
    int[,,] table = new int[m, n, l];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            for (int e = 0; e < l; e++){
                table[i, j, e] = rnd.Next(11, 99);
            }            
        }
    }
    return table;
}

Console.WriteLine ("Массив: ");
int[,,] arr = createArr(2,2,2);
Console.WriteLine (arr);
for (int i = 0; i < 2; i++){
    for(int j = 0; j < 2; j++){
        for (int e = 0; e < 2; e++){
            Console.Write("{0} ({1}{2}{3})", string.Join(", ", arr[i,j,e]), i, j, e);
        }
    }
    Console.WriteLine ("");
}