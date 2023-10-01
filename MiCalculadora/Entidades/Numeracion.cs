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
                        return DecimalABinario(Convert.ToInt32(this.valorNumerico));
                    }
                }
            }
        }
        /// <summary>
        /// Convierte el valor de binario a decimal. Valida que el string se corresponda con un número binario antes de la conversión.
        /// </summary>
        /// <param name="valor">Valor a convertir.</param>
        /// <returns>El valor convertido de string a double. Si no se pudo convertir o el valor era inválido, devuelve un MinDouble.</returns>
        private static double BinarioADecimal (string valor)
        {
            double valorDecimal;

            if (EsBinario(valor))
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

            if (this.valorNumerico == Double.MinValue || (sistema == ESistema.Binario && this.valorNumerico < 0))
            {
                valorConvertido = "Número Inválido";
            }
            else
            {
                if (sistema == ESistema.Decimal)
                {
                    valorConvertido = this.valorNumerico.ToString();
                }
                else
                {
                    valorConvertido = DecimalABinario(this.valorNumerico.ToString());
                }
            }
            return valorConvertido;
        }
        /// <summary>
        /// Convierte el valor de decimal a binario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private static string DecimalABinario(int valor)
        {
            return Convert.ToString(valor, 2);
        }
        /// <summary>
        /// Convierte el valor de decimal a binario.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns></returns>
        private static string DecimalABinario(string valor)
        {
            return DecimalABinario(Convert.ToInt32(valor));
        }
        /// <summary>
        /// Valida que una cadena de caracteres esté compuesta SOLAMENTE por caracteres '0' o '1'.
        /// </summary>
        /// <param name="valor"></param>
        /// <returns>True si la cadena está compuesta sólo por '0' o '1'. False si la cadena tiene otros caracteres.</returns>
        private static bool EsBinario(string valor)
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
                this.valorNumerico = BinarioADecimal(valor);

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
        /// Sobrecarga de operador !=.
        /// Un ESistema y una Numeracion serán iguales si el atributo ESistema del objeto Numeracion es igual al ESistema comparado.
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns>Bool</returns>
        public static bool operator != (ESistema sistema, Numeracion numeracion)
        {
            return sistema != numeracion.sistema;
        }
        /// <summary>
        /// Sobrecarga de operador !=.
        /// Dos objetos de tipo Numeracion serán iguales si el atributo ESistema del primer objeto es igual al atributo ESistema del segundo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Bool</returns>
        public static bool operator != (Numeracion n1, Numeracion n2)
        {
            return n1.sistema != n2.sistema;
        }
        /// <summary>
        /// Sobrecarga de operador -.
        /// Toma el primer objeto recibido por parámetro y le resta el segundo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Numeracion. Resultado de la operación matemática.</returns>
        public static Numeracion operator - (Numeracion n1, Numeracion n2)
        {
            Numeracion resultado = new Numeracion(double.MinValue, n1.sistema);
            if (n1 == n2)
            {
                resultado.valorNumerico = n1.valorNumerico - n2.valorNumerico;
            }
            return resultado;
        }
        /// <summary>
        /// Sobrecarga de operador *.
        /// Toma el primer objeto recibido por parámetro y le multiplica el segundo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Numeracion. Resultado de la operación matemática.</returns>
        public static Numeracion operator * (Numeracion n1, Numeracion n2)
        {
            Numeracion resultado = new Numeracion(double.MinValue, n1.sistema);
            if (n1 == n2)
            {
                resultado.valorNumerico = n1.valorNumerico * n2.valorNumerico;
            }
            return resultado;
        }
        /// <summary>
        /// Sobrecarga de operador /.
        /// Toma el primer objeto recibido por parámetro y lo divide por el segundo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Numeracion. Resultado de la operación matemática.</returns>
        public static Numeracion operator / (Numeracion n1, Numeracion n2)
        {
            Numeracion resultado = new Numeracion(double.MinValue, n1.sistema);
            if (n1 == n2 && n2.valorNumerico != 0)
            {
                resultado.valorNumerico = n1.valorNumerico / n2.valorNumerico;
            }
            return resultado;
        }
        /// <summary>
        /// Sobrecarga de operador +.
        /// Toma el primer objeto recibido por parámetro y le suma el segundo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Numeracion. Resultado de la operación matemática.</returns>
        public static Numeracion operator + (Numeracion n1, Numeracion n2)
        {
            Numeracion resultado = new Numeracion(double.MinValue, n1.sistema);
            if (n1 == n2)
            {
                resultado.valorNumerico = n1.valorNumerico + n2.valorNumerico;
            }
            return resultado;
        }
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Un ESistema y una Numeracion serán iguales si el atributo ESistema del objeto Numeracion es igual al ESistema comparado.
        /// </summary>
        /// <param name="sistema"></param>
        /// <param name="numeracion"></param>
        /// <returns>Bool</returns>
        public static bool operator == (ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.sistema;
        }
        /// <summary>
        /// Sobrecarga de operador ==.
        /// Dos objetos de tipo Numeracion serán iguales si el atributo ESistema del primer objeto es igual al atributo ESistema del segundo.
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns>Bool</returns>
        public static bool operator == (Numeracion n1, Numeracion n2)
        {
            return n1.sistema == n2.sistema;
        }

        /// <summary>
        /// Enumerable que contiene los dos sistemas numéricos en los que podrá crearse un objeto de tipo Numeracion.
        /// </summary>
        public enum ESistema
        {
            Decimal,
            Binario
        }

        public override bool Equals(object? obj)
        {
            if (obj != null)
            {
                Numeracion numero = obj as Numeracion;
                return numero is not null && this == numero;
            }
            else
            {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return (valorNumerico, sistema).GetHashCode();
        }
    }
}