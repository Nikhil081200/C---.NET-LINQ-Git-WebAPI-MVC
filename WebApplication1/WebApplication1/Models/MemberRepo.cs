using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MemberRepo : IMember
    {
        List<Member> mlist = new List<Member>()
        {
            new Member(){mid=1,mname="john",maddr="Banglore",Depamt=150000},
            new Member(){mid=2,mname="Sam",maddr="Banglore",Depamt=100000},
            new Member(){mid=3,mname="scott",maddr="Banglore",Depamt=250000},
            new Member(){mid=4,mname="johny",maddr="Banglore",Depamt=350000}
        };
        public List<Member> GetAllMember()
        {
            return mlist;
        }
        public List<Member> GetMember(int id)
        {
            var sql = from i in mlist where i.mid == id select i;
            return sql.ToList();
        }
    }
}
