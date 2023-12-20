using CarBook.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entites
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public string Model { get; set; }
        public string CoverImageUrl { get; set; }
        public int Km { get; set; }
        public string Transmission { get; set; } //TODO: vites turu - enum olabilir.
        public byte Seat { get; set; }
        public byte Luggage { get; set; }
        public string Fuel { get; set; } //yakit turu
        public string BigImageUrl { get; set; }
        public List<CarFeature> CarFeatures { get; set; } //many to many rel.
        public List<CarDescription> CarDescriptions { get; set; } //one to many rel.
        public List<CarPricing> CarPricings { get; set; } //many to many rel.
    }
}
