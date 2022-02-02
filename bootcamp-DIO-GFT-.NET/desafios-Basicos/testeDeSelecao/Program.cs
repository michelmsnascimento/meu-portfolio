using System; 

class MinhaClasse {

    static void Main(string[] args) { 

        string [] selections = Console.ReadLine().Split(' ');
        int a = int.Parse(selections[0]);
        int b = int.Parse(selections[1]);
        int c = int.Parse(selections[2]);
        int d = int.Parse(selections[3]);

        // Implemente a condição abaixo para ter o resultado esperado
        if (b>c && d>a && c+d>a+b && c>0 && d>0 && a%2==0)
		    {
          Console.WriteLine("Valores aceitos");
        } 
        else 
        {
          Console.WriteLine("Valores nao aceitos");
        }
    }

}
