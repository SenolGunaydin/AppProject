using AppProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject.Entities.Concrete
{
    public class UserOparetionClaim : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
