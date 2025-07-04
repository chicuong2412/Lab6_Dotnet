﻿using System.ComponentModel.DataAnnotations;

namespace Lab6_LeChiCuong_2131200001.DTO.User
{
    public class UserUpdationRequest
    {
        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public string UserCode { get; set; }

        public List<int> SelectedRoleIds { get; set; } = new List<int>();
    }
}
