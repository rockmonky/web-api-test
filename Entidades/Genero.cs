using System.ComponentModel.DataAnnotations;

namespace web_api_test;

public class Genero
{
    public int Id { get; set; }
    [Required]
    [StringLength(50)]
    public string Nombre { get; set; }
}
