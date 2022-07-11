using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Session06.DataModel;

public class City
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProvinceId { get; set; }

    public Province Province { get; set; }
}