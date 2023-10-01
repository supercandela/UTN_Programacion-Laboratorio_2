using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        /// <summary>
        /// Propiedad PrimerOperando. 
        /// Retorna el objeto Numeracion, correspondiente al atributo primerOperando.
        /// Setea el valor del objeto Numeracion, correspondiente al atributo primerOperando.
        /// </summary>
        public Numeracion PrimerOperando
        {
            get
            {
                return primerOperando;
            }
            set
            {
                primerOperando = value;
            }
        }
        /// <summary>
        /// Propiedad SegundoOperando. 
        /// Retorna el objeto Numeracion, correspondiente al atributo segundoOperando.
        /// Setea el valor del objeto Numeracion, correspondiente al atributo segundoOperando.
        /// </summary>
        public Numeracion SegundoOperando
        {
            get
            {
                return segundoOperando;
            }
            set
            {
                segundoOperando = value;
            }
        }
        /// <summary>
        /// Constructor de clase. Recibe por parámetro dos objetos de tipo Numeracion, que guarda en los atributos de la clase, seteando su valor.
        /// </summary>
        /// <param name="primerOperando"></param>
        /// <param name="segundoOperando"></param>
        public Operacion (Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }
        /// <summary>
        /// Ejecuta una operación matemática entre dos objetos de tipo Numeracion. Recibe como parámetro un caracter (+, -,*, /), que determina la operación a ejecutar. Por defecto, siempre ejecutará una suma.
        /// </summary>
        /// <param name="operador"></param>
        /// <returns>Numeracion. Resultado de la operación realizada.</returns>
        public Numeracion Operar(char? operador)
        {
            Numeracion resultado;
            switch (operador)
            {
                case '-':
                    resultado = this.primerOperando - this.segundoOperando;
                    break;
                case '*':
                    resultado = this.primerOperando * this.segundoOperando;
                    break;
                case '/':
                    resultado = this.primerOperando / this.segundoOperando;
                    break;
                default:
                    resultado = this.primerOperando + this.segundoOperando;
                    break;
            }
            return resultado;
        }
    }
}
