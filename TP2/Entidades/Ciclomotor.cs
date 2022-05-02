using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color) : base(marca, chasis, color)
        {
        }


        /// <summary>
        /// Propiedad de Ciclomotor, por defecto es 'Chico'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
               return ETamanio.Chico;
            }
        }

     /// <summary>
     /// Muestra por pantalla los datos de ciclomotor
     /// </summary>
     /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}\n", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
    }
}
