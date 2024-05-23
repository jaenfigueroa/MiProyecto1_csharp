using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyecto1.Models
{
    public class Transporte
    {
        public string _numero { get; set; }
        public DateTime _fecha { get; set; }
        public string _cliente { get; set; }
        public string _carga { get; set; }
        public double _TM { get; set; }
        public double _precio { get; set; }

        public Transporte()
        {
            _numero = "";
            _fecha = DateTime.Today;
            _cliente = string.Empty;
            _carga = string.Empty;
            _TM = 0;
            _precio = 150;
        }

        public double Costo() {
            return _precio * _TM;
        }

        public double Seguro() {
            return Costo() * 0.02;
        }

        public double Monto() {
            return Costo() + Seguro();
        }

        public double IGV() {
            return 0.18 * Monto();
        }

        public double MontoTotal() {
            return Monto() + IGV();
        }
    }
}