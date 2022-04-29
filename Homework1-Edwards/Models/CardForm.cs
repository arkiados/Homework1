using System.ComponentModel.DataAnnotations;

namespace Homework1_Edwards.Models
{
    public class CardForm
    {
        [Required(ErrorMessage = "Please enter your From address")]
        public string From { get; set; }
        [Required(ErrorMessage = "Please enter your To address")]
        public string To { get; set; }
        [Required(ErrorMessage = "Please enter your message")]
        public string Message { get; set; }
    }
}
