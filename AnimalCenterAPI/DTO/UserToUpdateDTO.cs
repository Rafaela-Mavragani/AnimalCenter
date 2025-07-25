﻿namespace AnimalCenterAPI.DTO
{
    public class UserToUpdateDTO
    {
        public int Id { get; set; } 
        public string? UserName { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }
        public DateTime InsertedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
