using AppProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject.Entities.Concrete
{
    public class OperationClaim : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
