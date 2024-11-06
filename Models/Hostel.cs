using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace College_System.Models
{
    public class Hostel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  HostelID { get; set; }

        [Required]
        [MaxLength(20)]
        public string Hostel_Name { get; set; }

        public int No_of_seats { get;set; }

        [ForeignKey ("Student")]
        public int SID { get; set; }
        public Student Student { get; set; }

    }
}
