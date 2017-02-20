using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Chat.Models
{
    public class UserMassage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Massage { get; set; }
        [Required]
        public DateTime DateOfCreate { get; set; }
        public virtual ApplicationUser User { get; set; }
        [ForeignKey(nameof(User))]
        public string User_Id { get; set; }
    }
}