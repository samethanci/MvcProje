using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        EfEntityRepositoryBase<Category, DatabaseContext> repositoryBase = new EfEntityRepositoryBase<Category, DatabaseContext>();

        public List<Category> GetAll()
        {
            return repositoryBase.GetAll();
        }
        public void Add(Category category)
        {
            if (category.CategoryName == "" || category.CategoryName.Length <= 3 || category.CategoryName.Length >= 51 || category.CategoryDescription == "")
            {
                // hata mesajı
            }
            else
            {
                repositoryBase.Add(category);
            }
        }
    }
}
