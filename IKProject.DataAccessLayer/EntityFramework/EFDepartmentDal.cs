using IKProject.DataAccessLayer.Abstract;
using IKProject.DataAccessLayer.Repository;
using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DataAccessLayer.EntityFramework
{
    public class EFDepartmentDal : GenericRepository<Department>, IDepartmentDal
    {
    }
}
