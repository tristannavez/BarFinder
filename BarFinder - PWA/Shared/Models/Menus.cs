using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace POIN.Shared.Models
{
    public class Menus
    {
        public Guid MenusID {get; set;}
        public String Link { get; set; }

        public Guid BarsID { get; set; }
        public Bars Bars { get; set; }

    }
}
