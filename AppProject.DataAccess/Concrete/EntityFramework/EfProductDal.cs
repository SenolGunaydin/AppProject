using AppProject.Core.DataAccess.EntiityFramework;
using AppProject.DataAccess.Abstract;
using AppProject.DataAccess.Concrete.EntityFramework.Contexts;
using AppProject.Entities.Concrete;

namespace AppProject.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal :EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
    }
}
