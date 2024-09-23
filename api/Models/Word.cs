using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Word
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public string Example { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
    }
}
