using AppProject.Core.DataAccess;
using AppProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {

    }
}
