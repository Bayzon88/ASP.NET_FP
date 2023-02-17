﻿namespace FinalProject.Models
{
    public class Account
    {
        // properties
        public int AcctId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public long Phone { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastLoginTime { get; set; }

        // constructor
        public Account()
        {
        }
    }
}
