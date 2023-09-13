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
    public class StaffMeetingManager : IStaffMeetingService
    {
        private readonly IStaffMeetingDal _staffMeetingDal;

        public StaffMeetingManager(IStaffMeetingDal staffMeetingDal)
        {
            _staffMeetingDal = staffMeetingDal;
        }

        public void TAdd(StaffMeeting t)
        {
            _staffMeetingDal.Insert(t);
        }

        public void TDelete(StaffMeeting t)
        {
            _staffMeetingDal.Delete(t);
        }

        public StaffMeeting TGetByID(int id)
        {
            return _staffMeetingDal.GetByID(id);
        }

        public List<StaffMeeting> TGetList()
        {
            return _staffMeetingDal.GetList();
        }

        public void TUpdate(StaffMeeting t)
        {
            _staffMeetingDal.Update(t);
        }
    }
}
