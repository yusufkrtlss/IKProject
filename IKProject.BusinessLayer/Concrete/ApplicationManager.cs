using IKProject.BusinessLayer.Abstract;
using IKProject.DataAccessLayer.Abstract;
using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BusinessLayer.Concrete
{
    public class ApplicationManager : IApplicationService
    {
        private readonly IApplicationDal _applicationDal;

        public ApplicationManager(IApplicationDal applicationDal)
        {
            _applicationDal = applicationDal;
        }

        public void TAdd(Application t)
        {
            _applicationDal.Insert(t);
        }

        public void TDelete(Application t)
        {
            _applicationDal.Delete(t);
        }

        public Application TGetByID(int id)
        {
            return _applicationDal.GetByID(id);
        }

        public List<Application> TGetList()
        {
            return _applicationDal.GetList();
        }

        public void TUpdate(Application t)
        {
            _applicationDal.Update(t);
        }

        public void UploadPdfFile(string fileName, byte[] fileContent)
        {
            _applicationDal.UploadPdfFile(fileName, fileContent);
        }
    }
}
