using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Data_Transfer_Objects.Media
{
    public class UpdateMediaDto
    {
        public int Id { get; set; }
        public string MediaName { get; set; }
        public string Descripton { get; set; }
    }
}
