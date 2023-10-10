using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Data_Transfer_Objects.Ushering
{
    public class UpdateUsheringDto
    {
        public int Id { get; set; }
        public string UsheringName { get; set; }
        public string Descripton { get; set; }
    }
}
