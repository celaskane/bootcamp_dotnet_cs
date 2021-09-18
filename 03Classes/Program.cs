using System;
using Classes.Heranca;

namespace _03Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponto p1 = new Ponto(10, 20);
            Ponto p2 = new Ponto3D(10, 20, 30);

            Ponto3D.Calcular();
        }
    }
}
