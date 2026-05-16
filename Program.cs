using System;
class Progran 
{
    static void Main ()
    {
      int[] notas = {81, 92, 78, 96, 61};

      for (int i=0; i < notas.Length; i ++)
      {
        Console.WriteLine($"Posicion [{i}]: {notas[i]}");
      }
    }
} 