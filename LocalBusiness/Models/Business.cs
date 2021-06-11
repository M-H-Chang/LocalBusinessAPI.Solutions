using System.ComponentModel.DataAnnotations;
namespace LocalBusiness.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    public string Name { get; set; }
    public string Location { get; set; }
  }
}