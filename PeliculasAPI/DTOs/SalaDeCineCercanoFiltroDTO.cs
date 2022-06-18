using System.ComponentModel.DataAnnotations;

namespace PeliculasAPI.DTOs
{
    public class SalaDeCineCercanoFiltroDTO
    {
        [Range(-90, 90)]
        public double Latitud { get; set; }

        [Range(-180, 180)]
        public double Longitud { get; set; }

        private int distanciEnKms = 10;
        private int distanciMaximaKms = 50;

        public int DistanciaEnKms
        {
            get 
            { 
                return distanciEnKms; 
            }
            set 
            { 
                distanciEnKms = (value > distanciMaximaKms) ? distanciMaximaKms : value; 
            }
        }
    }
}
