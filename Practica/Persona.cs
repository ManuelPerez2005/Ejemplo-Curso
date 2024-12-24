using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    internal class Persona
    {
        public string nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string chocolate { get; set; }
        public string tipo { get; set; }    
        public string ColorFavorito { get; set; }
        public int NumeroFavorito { get; set; }

        public string VerPerfil()
        {
            return $"Nombre: {nombre}, Fecha: {FechaNacimiento.ToShortDateString()}, " +
                   $"{chocolate}, es {tipo}, " +
                   $"Su color favorito es: {ColorFavorito}, " +
                   $"y su número favorito es: {NumeroFavorito}.";
        }
    }
}
