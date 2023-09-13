using IKProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.BusinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        public List<Comment> GetCommentsWithStaff(int staffId);
    }
}
