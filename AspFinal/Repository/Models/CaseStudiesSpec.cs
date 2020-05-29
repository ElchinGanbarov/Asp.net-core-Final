using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public class CaseStudiesSpec:BaseEntity
    {
        [Required (ErrorMessage ="Acar sozu daxil edin...")]
        [MaxLength(50)]
        public string Key { get; set; }
        [Required(ErrorMessage ="Valuesini daxil edin...")]
        [MaxLength(50)]
        public string Value { get; set; }
        public int CaseStudiesSingleId { get; set; }
        public CaseStudiesSingle CaseStudiesSingle { get; set; }

    }
}
