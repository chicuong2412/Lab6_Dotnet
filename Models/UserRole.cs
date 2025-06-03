using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Lab6_LeChiCuong_2131200001.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6_LeChiCuong_2131200001.Models
{
    [PrimaryKey("UserId", "RoleId")]
    public class UserRole
    {
        
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        
        public User User { get; set; }

        public int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public Role Role { get; set; }
    }
}
