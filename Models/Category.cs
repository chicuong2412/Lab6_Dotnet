﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Lab6_LeChiCuong_2131200001.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string? Description { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "datetime")]
        public DateTime UpdatedDate { get; set; } = DateTime.Now;

        [Column(TypeName = "bit")]
        public bool IsActive { get; set; } = true;

        [Column(TypeName = "nvarchar(MAX)")]
        public string? Avatar { get; set; }

        public ICollection<Book> Books { get; set; } = new List<Book>();

    }
}
