using System.ComponentModel.DataAnnotations;

namespace DesafioApp.Infra.Data.Entities
{
    public class EntityBase
    {
       [Key]
       public int Id { get; set; }
    }
}
