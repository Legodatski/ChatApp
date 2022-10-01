﻿using System.ComponentModel.DataAnnotations;

namespace ChatApp.Models
{
    public class MessageViewModel
    {
        public string Sender { get; set; }

        [Required]
        public string MessageText { get; set; }
    }
}
