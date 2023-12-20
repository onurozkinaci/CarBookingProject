using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entites
{
    public class Testimonial //Referanslar
    {
        public int TestimonialId { get; set; }
        public string Name { get; set; }
        public string Title { get; set; } //unvan
        public string Comment { get; set; }
        public string ImageUrl { get; set; }
    }
}
