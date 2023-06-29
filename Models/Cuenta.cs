﻿namespace Clase_asp_net.Models
{
    public class Cuenta
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string password { get; set; }
        public string descripcion { get; set; }
        public bool disponible { get; set; }
        public string genero { get; set; }
        public List<string> lenguajes { get; set; }
        public string cargo { get; set; }
        public string foto { get; set; }
    }
}
