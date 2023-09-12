using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.EntityLayer.Concrete
{
    public class Staff : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Tc { get; set; } // Kimlik kart numarası
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string PictureUrl { get; set; }
        public string Email { get; set; }
        public string Title { get; set; }
        public string Address { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime EndingDate { get; set; }
        public int DepartmentId { get; set; } // Department Foreign Key
        public Department Department { get; set; }
        public int GenderId { get; set; } // Gender Foreign Key
        public Gender Gender { get; set; }
        public ICollection<Comment> Comments { get; set; } // Yönetici tarafından oluşturulan geçmiş yorumları da görmek için ICollection
        public ICollection<StaffMeeting> StaffMeetings { get; set; } // Çalışan 1'den fazla toplantıya katılabilir.

        // Özel Alanlar
        public string Ozel_Alan1 { get; set; }
        public string Ozel_Alan2 { get; set; }
        public string Ozel_Alan3 { get; set; }
        public string Ozel_Alan4 { get; set; }
        public string Ozel_Alan5 { get; set; }
        public string Ozel_Alan6 { get; set; }
        public string Ozel_Alan7 { get; set; }
        public string Ozel_Alan8 { get; set; }
        public string Ozel_Alan9 { get; set; }
        public string Ozel_Alan10 { get; set; }
    }
}
