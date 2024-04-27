using System;

class Program
{
    static void Main(string[] args)
    {

        if (args.Length > 0)
        {
            foreach (string arg in args)
            {
                runCronJob(arg);
            }
        }
        else
        {
            Console.WriteLine("Nenhum argumento recebido.");
        }

        Environment.Exit(0);
    }

    public static void runCronJob(string argumento) {

        Console.WriteLine($"Passando argumento: {argumento}");
    }

}
