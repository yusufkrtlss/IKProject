using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.EntityLayer.Concrete
{
    public class Department : BaseEntity
    {
        public string DeptName { get; set; }
        public ICollection<Staff> StaffMembers { get; set; } = new List<Staff>();
    }
}
