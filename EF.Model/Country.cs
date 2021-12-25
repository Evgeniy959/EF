using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF.Model
{
    [Table("tab_countries")]
    public record Country
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("name")]
        [Required]
        public string Name { get; set; }
        
        [Column("population")]
        [Required]
        public int Population { get; set; }
        
        [Column("capital")]
        [Required]
        public string Capital { get; set; }
    }
}