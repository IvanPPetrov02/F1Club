using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class CommentRating
    {
        public Comment Comment { get; set; }
        public Profile User { get; set; }
        public bool Upvote { get; set; }

        public CommentRating(Comment comment, Profile user, bool upvote)
        {
            Comment = comment;
            User = user;
            Upvote = upvote;
        }

        public CommentRating()
        {
        }
    }
}
