﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AnimalCenterAPI.DTO
{
    public class AppTaskDTO
    {
        [Required]
        [NotNull]
        public int Id { get; set; }
        [Required (ErrorMessage = " The field is required.") ]
        public string? Name { get; set; } 
        public string? Description { get; set; }
        public int UserId { get; set; }
        public int AnimalTaskId { get; set; }
    }

}

