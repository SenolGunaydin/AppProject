using AppProject.Business.Abstract;
using AppProject.Business.Concrete;
using AppProject.DataAccess.Abstract;
using AppProject.DataAccess.Concrete.EntityFramework;
using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppProject.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
           builder.RegisterType<ProductManager>().As<IProductService>();
           builder.RegisterType<EfProductDal>().As<IProductDal>();

           builder.RegisterType<CategoryManager>().As<ICategoryService>();
           builder.RegisterType<EfCategoryDal>().As<ICategoryDal>();
        }
    }
}
