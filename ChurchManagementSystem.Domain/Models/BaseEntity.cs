using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementSystem.Domain.Models
{
    public class BaseEntity
    {
        public DateTime DateCreated { get; set; }
        public String Createdby { get; set; }
        public DateTime DateModified { get; set; }

        public String Modifiedby { get; set; }

        public bool isDeleted { get; set; }
    }
}
