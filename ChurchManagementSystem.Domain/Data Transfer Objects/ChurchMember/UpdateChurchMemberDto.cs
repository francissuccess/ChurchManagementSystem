using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Data_Transfer_Objects.ChurchMember
{
    internal class UpdateChurchMemberDto
    {
        public int Id { get; set; }
        public string ChurchMemberName { get; set; }
        public string Descripton { get; set; }
    }
}
