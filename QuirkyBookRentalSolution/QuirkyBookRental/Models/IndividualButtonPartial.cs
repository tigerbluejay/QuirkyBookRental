﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Text;
using System.Linq;

namespace QuirkyBookRental.Models
{
    public class IndividualButtonPartial
    {
        public string ButtonType { get; set; }
        public string Action { get; set; }
        public string Glyph { get; set; }
        public string Text { get; set; }

        public int? GenreId { get; set; }
        public int? BookId { get; set; }
        public int? CustomerId { get; set; }
        public int? MembershipTypeId { get; set; }

        public string ActionParameter
        {
            get
            {
                var param = new StringBuilder(@"/");

                if (BookId != null && BookId > 0)
                { 
                    param.Append(String.Format("{0}", BookId));
                }
                if (GenreId != null && GenreId > 0)
                {
                    param.Append(String.Format("{0}", GenreId));
                }
                if (CustomerId != null && CustomerId > 0)
                {
                    param.Append(String.Format("{0}", CustomerId));
                }
                if (MembershipTypeId != null && MembershipTypeId > 0)
                {
                    param.Append(String.Format("{0}", MembershipTypeId));
                }

                return param.ToString();

            }
        }
    }
}