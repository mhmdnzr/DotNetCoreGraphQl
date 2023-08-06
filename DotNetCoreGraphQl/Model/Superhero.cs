using DotNetCoreGraphQl.Model;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreGraphQl.Model
{
    public class Superhero
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please specify a name for the superhero")]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Height { get; set; }

        [HotChocolate.Data.UseSorting]
        public ICollection<Superpower> Superpowers { get; set; }

        [HotChocolate.Data.UseSorting]
        public ICollection<Movie> Movies { get; set; }
    }
}


