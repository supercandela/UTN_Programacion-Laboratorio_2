﻿using Entidades;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion elemento;

            elemento = new Numeracion(152, Numeracion.ESistema.Decimal);
            Console.WriteLine($"El número es {elemento.Valor} y su sistema es {elemento.Sistema} y lo convierto a su opuesto y es: {elemento.ConvertirA(Numeracion.ESistema.Binario)}");

            elemento = new Numeracion(1001100111, Numeracion.ESistema.Binario); //615
            Console.WriteLine($"El número es {elemento.Valor} y su sistema es {elemento.Sistema} y lo convierto a su opuesto y es: {elemento.ConvertirA(Numeracion.ESistema.Decimal)}");

            elemento = new Numeracion("35813551", Numeracion.ESistema.Decimal);
            Console.WriteLine($"El número es {elemento.Valor} y su sistema es {elemento.Sistema} y lo convierto a su opuesto y es: {elemento.ConvertirA(Numeracion.ESistema.Binario)}");

            elemento = new Numeracion("100110", Numeracion.ESistema.Binario); //38
            Console.WriteLine($"El número es {elemento.Valor} y su sistema es {elemento.Sistema} y lo convierto a su opuesto y es: {elemento.ConvertirA(Numeracion.ESistema.Decimal)}");

            elemento = new Numeracion("35813fd551", Numeracion.ESistema.Decimal);
            Console.WriteLine($"El número es {elemento.Valor} y su sistema es {elemento.Sistema} y lo convierto a su opuesto y es: {elemento.ConvertirA(Numeracion.ESistema.Binario)}");

            elemento = new Numeracion("10r4eh0110", Numeracion.ESistema.Binario);
            Console.WriteLine($"El número es {elemento.Valor} y su sistema es {elemento.Sistema} y lo convierto a su opuesto y es: {elemento.ConvertirA(Numeracion.ESistema.Decimal)}");


        }
    }
}