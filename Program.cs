// See https://aka.ms/new-console-template for more information
Console.WriteLine("Vvedite chislo ");
string writeN=Console.ReadLine()!;
int N=Convert.ToInt32(writeN);
int[] GetKub(int N)
{
    int[] Kubarray = new int [N];
    int number=1;
    for (int i= 0; i<N; i++, number++)
    {
        Kubarray [i] = (int)Math.Pow(i+1,3);
        number++;
    }
    return Kubarray;
}
void PrintTable(int[] Array)
{
    int number=1;
    for (int i=0; i<Array.Length; i++)
    {
    System.Console.Write($"{number} v kube=");
    System.Console.WriteLine(Array[i]);
    number++;
    }
}

int[]Kubarray=GetKub(N);
PrintTable(Kubarray);