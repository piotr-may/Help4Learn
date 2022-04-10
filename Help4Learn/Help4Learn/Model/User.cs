using System;
using System.Collections.Generic;
using System.Text;

namespace Help4Learn.Model
{
    public class User
    {
        public string userName { get; set; }

        public long points { get; set; }

        public User(string userName, long points)
        {
            this.userName = userName;
            this.points = points;
        }
    }
}
