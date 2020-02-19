using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace My_Scripture_Journal.Models
{
    public class Scripture
    {
        public int ID { get; set; }
        public string Book { get; set; }
                
        public int Chapter { get; set; }
        public int Verse { get; set; }
        public string Note { get; set; }

        [Display(Name = "Date Added")]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }


    }
}