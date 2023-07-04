int[,] createArr (int m , int n){
    Random rnd = new Random();
    int[,] table = new int[m, n];
    for (int i = 0; i < m; i++){
        for (int j = 0; j < n; j++){
            table[i, j] = rnd.Next(101,999);
        }
    }
    return table;
}


string returnValue(int x, int y, int[,] arr){
    try{ 
        return arr[x-1,y-1].ToString();
    }
    catch(Exception e){
       return "не существует!"; 
    }
}


int[,] arr = createArr(3, 4);
Console.WriteLine ("Массив: ");
for (int i = 0; i < 3; i++){
    for(int j = 0; j < 4; j++){
        Console.Write("{0} ", string.Join(", ", arr[i,j]));
    }
    Console.WriteLine ("");
}


Console.WriteLine("Введите строку элеиента в двуменрном массиве, начиная с 1: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите столбец элеиента в двуменрном массиве, начиная с 1: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Ваш элемент: {0}", returnValue(x, y, arr));