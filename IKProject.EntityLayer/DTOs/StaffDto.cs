using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.EntityLayer.DTOs
{
    public class StaffDto
    {
        public int Id { get; set; }
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
        public List<CommentDto> Comments { get; set; }
        public GenderDto Gender { get; set; }
        public DepartmentDto Department { get; set; }
        public List<MeetingDto> Meetings { get; set; }
    }
}
