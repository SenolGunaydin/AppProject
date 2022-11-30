using AppProject.Core.DataAccess;
using AppProject.Entities.Concrete;

namespace AppProject.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
