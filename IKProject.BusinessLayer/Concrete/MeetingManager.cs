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
    public class MeetingManager : IMeetingService
    {
        private readonly IMeetingDal _meetingDal;

        public MeetingManager(IMeetingDal meetingDal)
        {
            _meetingDal = meetingDal;
        }

        public void TAdd(Meeting t)
        {
            _meetingDal.Insert(t);
        }

        public void TDelete(Meeting t)
        {
            _meetingDal.Delete(t);
        }

        public Meeting TGetByID(int id)
        {
            return _meetingDal.GetByID(id);
        }

        public List<Meeting> TGetList()
        {
            return _meetingDal.GetList();
        }

        public void TUpdate(Meeting t)
        {
            _meetingDal.Update(t);
        }
    }
}
