namespace PrintPOSDesk.Models
{
    public class Unidad
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Cedula { get; set; }
        public string? Contacto { get; set; }
        public string? Vehiculo { get; set; }
        public string? Placa { get; set; }
        public string? Descripcion { get; set; }
        public bool Parqueadero { get; set; } = false;
        public double ValorHora { get; set; } 
        public double ValorLavado { get; set; } 
        public bool Lavado { get; set; } = false;
        public bool EnParqueadero { get; set; } = true;
        public string? Recomendacion { get; set; }
        public string? Token { get; set; }
        public string? CodigoUsuario { get; set; }//agregado
        public string? CodigoParqueadero { get; set; }//agregado
        public string? Url { get; set; }
        public string? ChatId { get; set; }
        public DateTime FechaInicio { get; set; } = DateTime.Now;
        public DateTime FechaFinal { get; set; } = DateTime.Now;
        public double ContidadHoras(DateTime fecha)
        {
            TimeSpan diferencia = fecha - FechaInicio;
            double horas = diferencia.TotalHours;
            return Math.Floor(horas);
        }

        public double ContidadMinutos(DateTime fecha)
        {
            TimeSpan diferencia = fecha - FechaInicio;
            double minutos = diferencia.TotalMinutes;
            double pisomin=Math.Floor(minutos/60);
            double minminu = (minutos / 60 - pisomin)*60;
            return Math.Floor(minminu);
        }
        public double ValorHoras(DateTime fecha) {
            TimeSpan diferencia = fecha - FechaInicio;
            double horas = diferencia.TotalHours;
            double valor = horas * ValorHora;
            return Math.Floor(valor);
        }
        public double Total(DateTime fecha)
        {
            double valor = 0;
            if (Parqueadero)
            {
                valor= ValorHoras(fecha);
            }
            if (Lavado)
            {
                valor = valor + ValorLavado;
            }
            return Math.Floor(valor);
        }
    }
}
