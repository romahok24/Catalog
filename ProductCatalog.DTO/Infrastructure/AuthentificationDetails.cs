﻿namespace ProductCatalog.DTO.Infrastructure
{
    public class AuthentificationDetails
    {
        public string Username { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Token { get; set; } = null!;
        public string Role { get; set; } = null!;
    }
}
