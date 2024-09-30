using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDP.DataAccessLayer.Abstract;
using UnitOfWorkDP.DataAccessLayer.Concrete;
using UnitOfWorkDP.DataAccessLayer.Repositories;
using UnitOfWorkDP.EntityLayer.Concrete;

namespace UnitOfWorkDP.DataAccessLayer.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer> , ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {

            
        }
    }
}
