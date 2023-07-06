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

int resultString (int[,] arr){
    int sumTemp = 0;
    int sumTmp = 0;
    int str = 0;
    for (int i = 0; i < 3; i++ ){
        for(int j = 0; j < 4; j++){
            sumTemp += arr[i,j];
        }
        if(i == 0){
            sumTmp = sumTemp;
        }
        if(sumTemp < sumTmp){
            sumTmp = sumTemp;
            str = i;
        }
        sumTemp = 0;        
    }
    return str;
}

Console.WriteLine ("Массив: ");
int[,] arr = createArr(3, 4);
for (int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
        Console.Write("{0} ", string.Join(", ", arr[i,j]));
    }
    Console.WriteLine ("");
}
Console.WriteLine ("Сумма элементов наименьшая в строке(первая строка 0) : {0}", resultString(arr));


