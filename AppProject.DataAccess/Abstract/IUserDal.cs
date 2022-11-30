using AppProject.Core.DataAccess;
using AppProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}
