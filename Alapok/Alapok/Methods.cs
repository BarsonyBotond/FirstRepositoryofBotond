double x = 4;
double x2 = Math.Sqrt(1-x);
WriteCounting(7);
WriteCounting(79);
WriteCounting(34);

double y = Math.Abs(-5) - x;
float c = Abs(4);
float Abs(float imput) //csinálunk saját methódust
{
    if (imput < 0);
        imput = imput * -1;
    return imput;
}
void WriteCounting(int n )
{
    
    for (int i = 1; i <= n; i++)
    {
        Console.WriteLine( i );
    }



}
bool IsPrime(int number)
{
    for (int i = 2; i < number/2; i++)
    { 
        if (number % i == 0)
            return false;
    }
    return true;
}

// void WriteCounting(int k);
//első n db prímszám
void WriteFirstNPrime(int k)
{
    int found = 0;
    for (int l = 2; l < found; l++)
        if
            {
            (IsPrime(l) == true)
            Console.WriteLine(l);
            found++;
}
       
       

}































