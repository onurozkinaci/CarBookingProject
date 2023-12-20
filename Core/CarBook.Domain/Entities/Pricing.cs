using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public string Name { get; set; } //gunluk, haftalik, aylik, yillik, vs. odeme plani
        public List<CarPricing> CarPricings { get; set; } //many to many rel.
    }
}
