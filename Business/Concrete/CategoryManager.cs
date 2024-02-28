using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccsess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;//Bağımlılığımızı minimize ediyoruz ve bağımlılığımızı contructor injection ile yapıyoruz

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetAll()
        {
            //Her entitynin kendi servisi olacak. Autration yazabilirzi buraya.
            //İş kodları
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category> (_categoryDal.Get(ctgry => ctgry.CategoryId == categoryId));
        }
    }
}
