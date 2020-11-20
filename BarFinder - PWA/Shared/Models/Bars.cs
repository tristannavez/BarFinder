using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace POIN.Shared.Models
{
    public class Bars
    {
        public Guid BarsID { get; set; }
        public String Name { get; set; }
        public Double Lat { get; set; }
        public Double Lng { get; set; }
        public Guid ImageID {get ; set;}

        [ForeignKey("ImageID")]
        public virtual Image Image { get ;set; }

        public IList<Menus> Menus { get; set; }
    }
}