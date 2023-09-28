using Entidades;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion elemento = new Numeracion();

            elemento.sistema = (Numeracion.ESistema)1;
            elemento.valorNumerico = 13800.25;

            Console.WriteLine($"El número es {elemento.Valor} y su sistema es {elemento.ConvertirA(elemento.sistema)}");
        }
    }
}