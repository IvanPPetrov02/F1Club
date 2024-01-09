using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LL
{
    public class Comment
    {
        public int ID { get; set; }
        public Profile User { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentDate { get; set; }
        public Dictionary<string, int> UnitUnitID { get; set; }

        public Comment(int iD, Profile user, string commentText, DateTime commentDate, Dictionary<string, int> unitUnitID)
        {
            ID = iD;
            User = user;
            CommentText = commentText;
            CommentDate = commentDate;
            UnitUnitID = unitUnitID;
        }

        public Comment()
        {
        }
    }
}
