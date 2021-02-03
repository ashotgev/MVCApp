using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCApp.Models
{
    public class Journal
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(9), MaxLength(9)]
        public string ISSN { get; set; }
        [Required]
        public string Name { get; set; }
        public JornalType Type { get; set; }
        public int PageCount { get; set; }
        public bool InWoS { get; set; }
        public bool InScopus { get; set; }
    }
    public enum JornalType
    {
        Scientific,
        Popular,
        Entertainment,
        Fashion
    }
}
