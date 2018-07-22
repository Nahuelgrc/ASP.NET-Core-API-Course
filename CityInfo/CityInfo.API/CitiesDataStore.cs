using CityInfo.API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API
{
    public class CitiesDataStore
    {
        public List<CityDTO> Cities { get; set; }

        public static CitiesDataStore Current { get; } = new CitiesDataStore();

        public CitiesDataStore()
        {
            Cities = new List<CityDTO>()
            {
                new CityDTO()
                {
                    Id = 1,
                    Name = "Buenos Aires",
                    Description = "Ciudad de la furia"
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Entre Ríos",
                    Description = "Ciudad del Litoral"
                }
            };
        }
    }
}
