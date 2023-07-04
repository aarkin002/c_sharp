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


Console.WriteLine ("Массив: ");
int[,] arr = createArr(3, 4);
for (int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
        Console.Write("{0} ", string.Join(", ", arr[i,j]));
    }
    Console.WriteLine ("");
}

double valueColumn = 0;
for (int i = 0; i < 4; i++){
    for(int j = 0; j < 3; j++){
        valueColumn += arr[j, i];
    }
    Console.WriteLine ("Среднее арифметическое {0} столюца равно {1}", i+1, valueColumn/3);
    valueColumn = 0;
}