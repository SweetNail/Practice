using LeetcodeApp.Filter.sql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Filter.demo
{
    [Transaction]
    public class UserInfoAction : SqlDAL
    {
        [TransactionMethod]
        public void Add(UserInfo user)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("UPDATE [UserInfo] SET Password='");
            sb.Append(user.Password);
            sb.Append("' WHERE UID=");
            sb.Append(user.UID);
            ExecuteNonQuery(sb.ToString());
        }
    }

    public class UserInfo
    {
        public string UID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
