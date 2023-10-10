using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Data_Transfer_Objects.SourceofIncoe
{
    public class CreateSourceofIncomeDto
    {
        public string SourceofIncomeName { get; set; }
        public int Amount { get; set; }
        public string Descripton { get; set; }
    }
}
