void distance (int x, int y, int x1, int y1) {

    double result = Math.Sqrt((x1 - x)*(x1 - x) + (y1 - y)*(y1 - y)) ;
    Console.WriteLine(result);
}
distance(3,7,8,9);