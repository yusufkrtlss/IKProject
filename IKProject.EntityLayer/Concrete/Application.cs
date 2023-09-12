using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.EntityLayer.Concrete
{
    public class Application : BaseEntity
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public byte[] PdfData { get; set; } // CV okumak için !!
        public string FileName { get; set; } // CV ismi
        public DateTime ApplicationTime { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
