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
                    Description = "Ciudad de la furia",
                    PointOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Obelisk",
                            Description = "National historic monument and icon of Buenos Aires"
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Caminito",
                            Description = "Street museum and a traditional alley"
                        }
                    }
                },
                new CityDTO()
                {
                    Id = 2,
                    Name = "Entre Ríos",
                    Description = "Ciudad del Litoral",
                    PointOfInterest = new List<PointOfInterestDTO>()
                    {
                        new PointOfInterestDTO()
                        {
                            Id = 1,
                            Name = "Termas de Federacion",
                            Description = "Spring produced by the emergence of geothermally heated groundwater that rises from the Earth's crust"
                        },
                        new PointOfInterestDTO()
                        {
                            Id = 2,
                            Name = "Rivers",
                            Description = "Rivers where the people can fishing"
                        }
                    }
                }
            };
        }
    }
}
