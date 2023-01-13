using System;
using DataAccessLayer.Abstract;
using DataAccessLayer.Repositories;
using EntityLayer;

namespace DataAccessLayer.EntitiyFramework
{
	public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
		
	}
}

