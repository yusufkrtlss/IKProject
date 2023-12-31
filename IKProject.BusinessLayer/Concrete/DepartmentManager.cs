﻿using IKProject.BusinessLayer.Abstract;
using IKProject.DataAccessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BusinessLayer.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private readonly IDepartmentDal _departmentDal;

        public DepartmentManager(IDepartmentDal departmentDal)
        {
            _departmentDal = departmentDal;
        }

        public void TAdd(Department t)
        {
            _departmentDal.Insert(t);
        }

        public void TDelete(Department t)
        {
            _departmentDal.Delete(t);
        }

        public Department TGetByID(int id)
        {
            return _departmentDal.GetByID(id);
        }

        public List<Department> TGetList()
        {
            return _departmentDal.GetList();
        }

        public void TUpdate(Department t)
        {
            _departmentDal.Update(t);
        }
    }
}
