using AppProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject.Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        void Add(User user);
        User GetByEmail(string email);
    }
}
