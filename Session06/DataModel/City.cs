using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Session06.DataModel;

[Table("Shahr", Schema = "xyz")]
public class City
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    [Column("myName")]
    public string Name { get; set; }
    public int ProvinceId { get; set; }

    public Province Province { get; set; }
}