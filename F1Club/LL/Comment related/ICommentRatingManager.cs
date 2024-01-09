
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public interface ICommentRatingManager
    {
        bool AddCommentRating(CommentRating CommentRating);
        bool DeleteCommentRating(CommentRating CommentRating);
        bool UpdateCommentRating(CommentRating CommentRating);
        CommentRating GetCommentRatingByUser(int UserID, int CommentID);
        List<CommentRating> GetAllCommentRatings(int CommentID);
    }
}
