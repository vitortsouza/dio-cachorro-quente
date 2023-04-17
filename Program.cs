using System;

public class Program 
{
    public static void Main(string[] args) 
  {
    string[] entrada = Console.ReadLine().Split();
    int participantes = int.Parse(entrada[0]);
    int cachorrosQuentes = int.Parse(entrada[1]);
    
    decimal media = Convert.ToDecimal(participantes) / Convert.ToDecimal(cachorrosQuentes);

    Console.WriteLine(media.ToString("0.00"));
  }
}