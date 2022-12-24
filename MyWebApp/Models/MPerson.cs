using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWebApp.Models
{
    public class MPerson
    {
        public int? Id
        {
            get;
            set;
        }
        
        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int PersonTypeId
        {
            get;
            set;
        }
    }
}