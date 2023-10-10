using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Models
{
    public class Pastor : BaseEntity
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public int Phonenumber { get; set; }
        public char Address { get; set; }
        public string Portfolio { get; set; }
    }
}
