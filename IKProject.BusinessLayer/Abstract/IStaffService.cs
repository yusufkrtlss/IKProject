using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BusinessLayer.Abstract
{
    public interface IStaffService : IGenericService<Staff>
    {
        public List<Staff> GetStaffWithComment(int id);
    }
}
