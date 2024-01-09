using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface ICommentManager
    {
        bool CreateComment(Comment Comment);
        bool DeleteComment(Comment Comment);
        bool UpdateComment(Comment Comment);
        Comment GetCommentByID(int id);
        List<Comment> GetAllComments();
    }
}
