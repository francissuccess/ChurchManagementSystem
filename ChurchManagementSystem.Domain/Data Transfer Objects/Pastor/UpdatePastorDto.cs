using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Data_Transfer_Objects.Pastor
{
    public class UpdatePastorDto
    {
        public int Id { get; set; }
        public string PastorName { get; set; }
        public string Descripton { get; set; }
    }
}
