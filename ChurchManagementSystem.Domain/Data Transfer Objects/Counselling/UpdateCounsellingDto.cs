using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Data_Transfer_Objects.Counselling
{
    public class UpdateCounsellingDto
    {
        public int Id { get; set; }
        public string CounsellorName { get; set; }
        public string Descripton { get; set; }
    }
}
