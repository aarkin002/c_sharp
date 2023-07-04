


double[] Dot(double b1,double k1, double b2, double k2){
    double x = (b2 - b1)/(k1-k2);
    double y = k1*x + b1;
    Console.WriteLine(x);
    Console.WriteLine(y);
    double[] dotArr = new double[2]{x, y};
    return dotArr;
}

Console.WriteLine("Введите b1: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k1: ");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = double.Parse(Console.ReadLine());


double[] dot = Dot(b1,k1,b2,k2);

Console.WriteLine("[{0}]", string.Join(", ", dot));