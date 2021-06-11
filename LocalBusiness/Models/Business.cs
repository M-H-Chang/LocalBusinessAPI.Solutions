using System.ComponentModel.DataAnnotations;
namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Location { get; set; }
  }
}