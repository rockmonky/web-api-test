using System.ComponentModel.DataAnnotations;

namespace web_api_test;

public class Images
{
    [Key]
    public int vf_id { get; set; }
    public int vi_id { get; set; }
    public string vf_path { get; set; }
    public byte to_id { get; set; }
    public DateTime vf_fechaini { get; set; }
    public int ua_idcrea { get; set; }
    // public string vf_location { get; set; }
}
