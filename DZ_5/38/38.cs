double[] arr = new double[8]{1,2,3,4,5,6,7,8};
double min = arr[1];
double max = arr[1];
foreach(double a in arr){
    if (min > a ){
        min = a;
    }
    if (max < a ){
        max = a;
    }
}
Console.WriteLine("Разница между максимальным и минимальным элементов массива. ==  {0}", max - min);