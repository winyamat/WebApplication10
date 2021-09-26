using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication10.Data
{
    public class Results
    {
        [Key]
        public int id { get; set; }

        public char results { get; set; }




    }
}
