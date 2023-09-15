using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BusinessLayer.Abstract
{
    public interface IApplicationService : IGenericService<Application>
    {
        public void UploadPdfFile(string fileName, byte[] fileContent);
    }
}
