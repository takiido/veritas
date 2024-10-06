using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Vocabulary
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public int WordId { get; set; }
        [ForeignKey("WordId")]
        public virtual Word Word { get; set; }
        public DateTime DateAdded {  get; set; }
        public DateTime DateLastRead { get; set; }
    }
}
