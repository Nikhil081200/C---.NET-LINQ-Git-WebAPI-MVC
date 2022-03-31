using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IMember
    {
        List<Member> GetAllMember();
        List<Member> GetMember(int id);
    }
}
