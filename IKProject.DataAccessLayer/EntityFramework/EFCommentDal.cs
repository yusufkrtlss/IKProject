using IKProject.DataAccessLayer.Abstract;
using IKProject.DataAccessLayer.Concrete;
using IKProject.DataAccessLayer.Repository;
using IKProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKProject.DataAccessLayer.EntityFramework
{
    public class EFCommentDal : GenericRepository<Comment>, ICommentDal
    {
        public List<Comment> GetCommentsWithStaff(int id)
        {
            using var c = new StoreContext();
            var result = c.Comments.Where(x => x.Id == id).Include(y => y.Staff).ToList();
            return result;
        }
    }
}
