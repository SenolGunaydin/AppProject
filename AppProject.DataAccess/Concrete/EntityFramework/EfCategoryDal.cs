using AppProject.Core.DataAccess.EntiityFramework;
using AppProject.DataAccess.Abstract;
using AppProject.DataAccess.Concrete.EntityFramework.Contexts;
using AppProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    }
}
