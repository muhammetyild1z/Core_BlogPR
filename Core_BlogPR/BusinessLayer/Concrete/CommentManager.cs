using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommnetServices
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment comment)
        {
            _commentDal.Insert(comment);
        }

        public void Delete(Comment t)
        {
            throw new NotImplementedException();
        }

        public void Update(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetBlogAndByWriter(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetBlogAndCatagoryList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList()
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetLista(int id)
        {
            Context c = new Context();
           
           return _commentDal.GetListAll(x => x.blogID == id);
        }

       
    }
}
