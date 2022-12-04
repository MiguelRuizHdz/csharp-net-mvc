using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaEntidad
{
    public class AutomovilModel
    {
        private int automovilId;
        private string marca;
        private string modelo;
        private int anio;
        private decimal precio;

        public int AutomovilId { get => automovilId; set => automovilId = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public int Anio { get => anio; set => anio = value; }
        public decimal Precio { get => precio; set => precio = value; }
    }
}
