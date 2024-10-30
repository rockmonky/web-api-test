using System.ComponentModel.DataAnnotations;

namespace web_api_test;

public class UserApplication
{
    [Key]
    public int ua_id { get; set; }
    public int co_id { get; set; }
    public string ua_usr { get; set; }
    public string ua_con { get; set; }
    public DateTime? ua_fechafin { get; set; }
}


public class AccessUserApplication
{
    [Key]
    public int aua_id { get; set; }
    public int ua_id { get; set; }
    public int ap_id { get; set; }
    public DateTime? aua_fechafin { get; set; }
    public int aua_perfil { get; set; }
}


public class Contact
{
    [Key]
    public int co_id { get; set; }
    public string co_nombre { get; set; }
    public string co_apellido { get; set; }
}


public class Installer
{
    [Key]
    public int in_id { get; set; }
    public int co_id { get; set; }
    public DateTime? in_fechafin { get; set; }
}