using System;
using System.ComponentModel.DataAnnotations;


namespace POIN.Shared.Models
{
    public class Image
    {
        public Guid ImageID { get; set; }
        public String Link { get; set; }
    }
}