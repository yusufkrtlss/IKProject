using IKProject.DataAccessLayer.Abstract;
using IKProject.DataAccessLayer.Concrete;
using IKProject.DataAccessLayer.Repository;
using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DataAccessLayer.EntityFramework
{
    public class EFApplicationDal : GenericRepository<Application>, IApplicationDal
    {
        public void UploadPdfFile(string fileName, byte[] fileContent)
        {
            using var _dbContext = new StoreContext();

            var pdfDocument = new Application
            {
                FileName = fileName,
                PdfData = fileContent,
                ApplicationTime = DateTime.Now
            };

            _dbContext.Applications.Add(pdfDocument);
            _dbContext.SaveChanges();
        }
    }
}
