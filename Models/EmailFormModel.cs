using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Assignment.Models
{
    public class EmailFormModel
    {
        [Required, Display(Name = "Your name")]
        public string FromName { get; set; }
        [Display(Name = "Your email"), EmailAddress]
        public string FromEmail { get; set; }
        [Required]
        public string Message { get; set; }
        public HttpPostedFileBase Upload { get; set; }
        [Display(Name ="To Email")]
        public string ToEmail { get; set; }
    }
}