using Assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Interface
{
    interface ReviewRepository
    {
        IEnumerable<Review> GetAll();
        Review Get(int id);
        Review Add(Review item);
        bool Update(Review item);
        bool Delete(int id);
    }
}
