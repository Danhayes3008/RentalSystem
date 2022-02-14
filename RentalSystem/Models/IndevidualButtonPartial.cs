using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RentalSystem.Models
{
    public class IndevidualButtonPartial
    {
        public string ButtonType { get; set; }
        public string Action { get; set; }
        public  string Glyth { get; set; }
        public string Text { get; set; }

        // get the id's with these
        public int? GenreId { get; set; }
        public int? BookId { get; set; }
        public int? CustomerId { get; set; }
        public int? MembershipId { get; set; }

        public string ActionPerameter
        {
            get
            {
                var param = new StringBuilder(@"/");

                if(GenreId != null && GenreId > 0)
                {
                    param.Append(String.Format("{0}", GenreId));
                }
                if (BookId != null && BookId > 0)
                {
                    param.Append(String.Format("{0}", BookId));
                }
                if (CustomerId != null && CustomerId > 0)
                {
                    param.Append(String.Format("{0}", CustomerId));
                }
                if (MembershipId != null && MembershipId > 0)
                {
                    param.Append(String.Format("{0}", MembershipId));
                }
                return param.ToString();
            }
        }
    }
}