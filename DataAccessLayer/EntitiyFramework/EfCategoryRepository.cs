using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntitiyFramework
{
	public class EfCategoryRepository:GenericRepository<Category>, ICategoryDal
	{
		
	}
}

