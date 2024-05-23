using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiProyecto1.Models
{
    public class Venta
    {
        public string _numero { get; set; }
        public DateTime _fecha{ get; set; }
        public string _cliente{ get; set; }
        public string _mueble { get; set; }
        public double _precio { get; set; }


        public Venta()
        {
            _numero = "";
            _fecha = DateTime.Today;
            _cliente = "";
            _mueble = "";
            _precio = 0;
        }

        public double Descuento()
        {
            if (_precio == 0)
                return 0;
            else
              if (_precio <= 500)
                return 0.05 * _precio;
            else
                return 0.1 * _precio;
        }
        public double Neto()
        {
            return _precio - Descuento();
        }
    }

}