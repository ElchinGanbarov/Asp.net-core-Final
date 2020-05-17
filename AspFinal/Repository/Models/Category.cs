using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Repository.Models
{
    public class Category:BaseEntity
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public int Count { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [Column(TypeName ="money")]
        public decimal MaxPayment { get; set; }
        [Column(TypeName = "money")]
        public decimal MinPayment { get; set; }
        public int GracePeriod { get; set; }
        public int Support { get; set; }
        [Required]
        [MaxLength(100)]
        public string PolicyModification { get; set; }
        public int NumberPeople { get; set; }
        [Required]
        [MaxLength(100)]
        public string Location { get; set; }
        public int ImagesId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Logo { get; set; }
        public int CompanyId { get; set; }
        public Company Company { get; set; }
        public Images Images { get; set; }
        public IEnumerable<Insurance> Insurances { get; set; }
    }
}
