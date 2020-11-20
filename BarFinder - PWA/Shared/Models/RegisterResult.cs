using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;


namespace POIN.Shared.Models
{
    public class RegisterResult
    {
        public bool Successful { get; set; }
        public IEnumerable<string> Errors { get; set; }
    }
}