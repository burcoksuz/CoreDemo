using BusinnesLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinnesLayer.Concrete
{
    public class CommentManager : ICommentService
    { ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;   
        }

        public void Add(Comment comment)
        {
            _commentDal.Add(comment);   
        }

        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return filter == null ? _commentDal.GetAll():_commentDal.GetAll(filter);
        }
    }
}
