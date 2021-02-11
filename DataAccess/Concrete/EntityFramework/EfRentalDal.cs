using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>, IRentalDal
    {
        public List<RentalDetailDto> GetRentalDetails(Expression<Func<Rental, bool>> filter = null)
        {
            using(RentACarContext context = new RentACarContext())
            {
                var result = from re in filter is null ? context.Rentals : context.Rentals.Where(filter)
                             join ca in context.Cars
                             on re.CarId equals ca.Id
                             join cust in context.Customers
                             on re.CustomerId equals cust.Id
                             join us in context.Users
                             on cust.UserId equals us.Id
                             select new RentalDetailDto
                             {
                                 Id = re.Id,
                                 CarName = ca.Name,
                                 CustomerName = cust.CompanyName,
                                 CarId = ca.Id,
                                 RentDate = re.RentTime,
                                 ReturnDate = re.ReturnTime,
                                 UserName = us.FirstName + " " + us.LastName
                             };
                return result.ToList();
            }
        }
    }
}
