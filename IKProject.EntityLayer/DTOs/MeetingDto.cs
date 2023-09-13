using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.EntityLayer.DTOs
{
    public class MeetingDto
    {
        public int Id { get; set; }
        public string MeetingTitle { get; set; }
        public DateTime MeetingDate { get; set; }
        public List<int> StaffIds { get; set; }
    }
}
