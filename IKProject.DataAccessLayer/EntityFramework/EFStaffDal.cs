using IKProject.DataAccessLayer.Abstract;
using IKProject.DataAccessLayer.Concrete;
using IKProject.DataAccessLayer.Repository;
using IKProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DataAccessLayer.EntityFramework
{
    public class EFStaffDal : GenericRepository<Staff>, IStaffDal
    {
        public List<Staff> GetStaffWithComment(int id)
        {
            using var c = new StoreContext();
            var result = c.Staffs.Where(x => x.Id == id).Include(y => y.Comments).ToList();
            return result;
        }
    }
}
