using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Models
{
    public class SourceofIncome
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public DateTime date { get; set; }
        public int Amount { get; set; }
    }
}
