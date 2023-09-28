namespace Entidades
{
    public class Numeracion
    {
        public ESistema sistema;
        public double valorNumerico;

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
                return this.valorNumerico.ToString();
            }
        }
        /// <summary>
        /// Convierte el valor de binario a decimal.
        /// </summary>
        /// <param name="valor">Valor a convertir.</param>
        /// <returns>El valor convertido de string a double.</returns>
        private double BinarioADecimal (string valor)
        {
            double valorDecimal;
            if (!double.TryParse(valor, out valorDecimal))
            {
                valorDecimal = double.MinValue;
            }
            return valorDecimal;
        }
        /// <summary>
        /// Retorna un string
        /// </summary>
        /// <param name="sistema">ESistema</param>
        /// <returns></returns>
        public string ConvertirA(ESistema sistema)
        {
            return sistema.ToString();
        }
        private string DecimalABinario(int valor)
        {
            return "Hola";
        }
        public enum ESistema
        {
            Decimal,
            Binario
        }
    }
}