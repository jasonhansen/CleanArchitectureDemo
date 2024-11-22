using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Member.Application
{
    public interface IMemberService
    {
        List<Domain.Member> GetAllMembers(); 
    }
}
