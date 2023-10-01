using System.Drawing;
using System;
using System.Text.RegularExpressions;

namespace Entidades
{
    public class Numeracion
    {
        private ESistema sistema;
        private double valorNumerico;

        /// <summary>
        /// Propiedad Sistema. Retorna el ESistema en que debe representarse el valor numérico.
        /// </summary>
        public ESistema Sistema
        {
            get 
            { 
                return this.sistema; 
            }
        }
        /// <summary>
        /// Propiedad Valor. Retorna el valor del objeto de acuerdo al sistema de numeración de su propiedad Sistema.
        /// </summary>
        public string Valor
        {
            get
            {
                if (this.sistema == ESistema.Decimal)
                {
                    return this.valorNumerico.ToString();
                }
                else
                {
                    if (this.valorNumerico == Double.MinValue)
                    {
                        return "Numero Inválido";
                    } else
                    {
                        return this.DecimalABinario(Convert.ToInt32(this.valorNumerico));
                    }
                }
            }
        }
        /// <summary>
        /// Convierte el valor de binario a decimal. Valida que el string se corresponda con un número binario antes de la conversión.
        /// </summary>
        /// <param name="valor">Valor a convertir.</param>
        /// <returns>El valor convertido de string a double. Si no se pudo convertir o el valor era inválido, devuelve un MinDouble.</returns>
        private double BinarioADecimal (string valor)
        {
            double valorDecimal;

            if (this.EsBinario(valor))
            {
                valorDecimal = Convert.ToInt32(valor, 2);
            }
            else
            {
                valorDecimal = double.MinValue;
            }
            return valorDecimal;
        }
        /// <summary>
        /// Retorna una cadena representada en un sistema de numeración basado en el parámetro recibido.
        /// </summary>
        /// <param name="sistema">ESistema</param>
        /// <returns></returns>
        public string ConvertirA(ESistema sistema)
        {
            string valorConvertido;

            if (sistema == ESistema.Decimal)
            {
                valorConvertido = this.valorNumerico.ToString();
            }
            else
            {
                valorConvertido = this.DecimalABinario(this.valorNumerico.ToString());
            }

            return valorConvertido;
        }
        /// <summary>
        /// Convierte el valor de decimal a binario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private string DecimalABinario(int valor)
        {
            return Convert.ToString(valor, 2);
        }
        /// <summary>
        /// Convierte el valor de decimal a binario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private string DecimalABinario(string valor)
        {
            return this.DecimalABinario(Convert.ToInt32(valor));
        }
        /// <summary>
        /// Valida que una cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>True si la cadena está compuesta sólo por '0' o '1'. False si la cadena tiene otros caracteres.</returns>
        private bool EsBinario(string valor)
        {
            return Regex.IsMatch(valor, "^[01]+$");
        }
        /// <summary>
        /// Inicializa los valores del objeto.
        /// Si el valor recibido pertenece al sistema binario, lo convierte a decimal para guardarlo. 
        /// Si el valor es un decimal, verifica que pueda ser convertido a decimal.
        /// En caso de que no se cumplan ninguna de las condiciones antes dadas, almacenará el MinValue de un double.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        private void InicializarValores (string valor, ESistema sistema)
        {
            this.sistema = sistema;
            if (sistema == ESistema.Decimal)
            {                
                if (!double.TryParse(valor, out this.valorNumerico))
                {
                    this.valorNumerico = double.MinValue;
                }
            }
            else
            {
                this.valorNumerico = this.BinarioADecimal(valor);

            }
        }
        /// <summary>
        /// Constructor de clase. Recibe un double que representa el valor y un enumerable que representa el sistema numérico del objeto.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        public Numeracion (double valor, ESistema sistema)
        {
            this.InicializarValores(valor.ToString(), sistema);
        }
        /// <summary>
        /// Constructor de clase. Recibe un string que representa el valor y un enumerable que representa el sistema numérico del objeto.
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="sistema"></param>
        public Numeracion (string valor, ESistema sistema)
        {
            this.InicializarValores(valor, sistema);
        }
        /// <summary>
        /// Enumerable que contiene los dos sistemas numéricos en los que podrá crearse un objeto de tipo Numeracion.
        /// </summary>
        public enum ESistema
        {
            Decimal,
            Binario
        }
    }
}