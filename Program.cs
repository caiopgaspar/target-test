internal class Program
{
    private static void Main(string[] args)
    {        
        Console.Write("Digite um número: ");
        var numero = int.Parse(Console.ReadLine());
        
        Fibonacci(numero);

        if (Fibonacci(numero)){
            Console.WriteLine("Pertence à sequência de Fibonacci");
        }
        else{
            Console.WriteLine("Não pertence à sequência de Fibonacci");
        }
    }

    public static bool Fibonacci(int n){
               
        List<int> fib = new List<int> {0, 1};

        for (int i = 2; fib[i - 1] < n; i++){            
            fib.Add(fib[i - 2] + fib[i - 1]); 
        }

        return fib.Contains(n);
    }
}



