string Number(int N, int b)


{
    //string result = string.Empty 

    if (N >= b) return $"{N} " + Number(N - 1, b);
    else return String.Empty;


}
Console.WriteLine(Number(8, 1));
