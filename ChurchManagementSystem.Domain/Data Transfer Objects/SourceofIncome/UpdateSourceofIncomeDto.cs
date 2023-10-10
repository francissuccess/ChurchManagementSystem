using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Data_Transfer_Objects.SourceofIncome
{
    public class UpdateSourceofIncomeDto
    {
        public int Id { get; set; }
        public string SourceofincomeName { get; set; }
        public int Amount { get; set; }
        public string Descripton { get; set; }
    }
}
