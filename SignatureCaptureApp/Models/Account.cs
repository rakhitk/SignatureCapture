using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace SignatureCaptureApp.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        [Required]
        public string Email { get; set; } = "";
        [Required]
        public string PhoneNo { get; set; } = "";
        [Required]
        public string SignaturePad { get; set; } = "";
    }
}
