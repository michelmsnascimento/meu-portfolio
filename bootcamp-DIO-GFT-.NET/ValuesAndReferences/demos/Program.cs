using System;
class Program
{
    static void Demo1()
    {
         int a = 2;
        a = Adicionar20(a);
        
        Console.WriteLine($"O Valor da variável a é {a}");
    }
    static int Adicionar20(int x)
    {
        return x + 20;
    }
    public static void Main()
    {
        int a = 2;
        a = Adicionar20(a);
        
        Console.WriteLine($"O Valor da variável a é {a}");
    }
}
