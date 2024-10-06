using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class ApplicationUser : IdentityUser
    {

        public int SubscriptionId { get; set; }
        [ForeignKey("SubscriptionId")]
        public virtual Subscription Subscription { get; set; }
        public DateTime DateSubscribed { get; set; }
    }
}
