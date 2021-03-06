﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityInfo.API.Model
{
    public class CityDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int NumberOfPointsOfInterest {
            get
            {
                return this.PointOfInterest.Count;
            }

        }

        public ICollection<PointOfInterestDTO> PointOfInterest { get; set; } = new List<PointOfInterestDTO>();


    }
}
