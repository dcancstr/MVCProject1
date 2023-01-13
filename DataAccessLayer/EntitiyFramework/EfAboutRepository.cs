using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntitiyFramework
{
	public class EfAboutRepository : GenericRepository<About>, IAboutDal
    {
		
	}
}

