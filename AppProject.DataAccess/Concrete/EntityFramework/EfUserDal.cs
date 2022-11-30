﻿using AppProject.Core.DataAccess.EntiityFramework;
using AppProject.DataAccess.Abstract;
using AppProject.DataAccess.Concrete.EntityFramework.Contexts;
using AppProject.Entities.Concrete;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace AppProject.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                             on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name};

                return result.ToList();
            }
        }
    }
}
