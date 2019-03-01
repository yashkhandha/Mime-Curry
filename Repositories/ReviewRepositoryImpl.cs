using Assignment.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using Assignment.Models;

namespace Assignment.Repositories
{
    public class ReviewRepositoryImpl : ReviewRepository
    {
        ReviewEntities reviewDB = new ReviewEntities();

        IEnumerable<Models.Review> ReviewRepository.GetAll()
        {
            return reviewDB.Reviews;
        }

        Review ReviewRepository.Get(int id)
        {
            return reviewDB.Reviews.Find(id);
        }

        Review ReviewRepository.Add(Review item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            reviewDB.Reviews.Add(item);
            reviewDB.SaveChanges();
            return item;
        }

        bool ReviewRepository.Update(Review item)
        {
            //throw new NotImplementedException();
            if (item == null)
            {
                throw new ArgumentNullException("item");
            }
            // TO DO : Code to update record into database
            var reviews = reviewDB.Reviews.Single(a => a.ReviewID == item.ReviewID);
            reviews.ReviewTitle = item.ReviewTitle;
            reviews.ReviewDescription = item.ReviewDescription;
            reviews.ReviewDate = item.ReviewDate;
            reviews.ReviewRating = item.ReviewRating;
            reviewDB.SaveChanges();
            return true;
        }

        bool ReviewRepository.Delete(int id)
        {
            //throw new NotImplementedException();
            Review reviews = reviewDB.Reviews.Find(id);
            reviewDB.Reviews.Remove(reviews);
            reviewDB.SaveChanges();
            return true;
        }

    }
}