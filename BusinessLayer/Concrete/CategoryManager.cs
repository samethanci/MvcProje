using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using CoreLayer.DataAccess.EntityFramework;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
        //public IDataResult<List<Category>> GetAll()
        //{
        //    //if (DateTime.Now.Hour == 20)
        //    //{
        //    //    return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
        //    //}
        //    //return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.CategoryListed);
        //}

    }
}
