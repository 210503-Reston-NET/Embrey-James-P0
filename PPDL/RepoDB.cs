using Microsoft.Win32;
using System.IO;
using System.Collections.Generic;
using System;
using Model;

namespace PPDL
{
    public class RepoDB
    {
        
    }

    public Models.Reviews AddReview(Store store, Review review)
    {
        
        found.Reviews.Add
        (
            new Entity.Review
            {
                Rating = review.Rating,
                Description = review.Description,
                StoreId = _context.Store.FirstOrDefault(storez => storez.Name == store.Name && storez => storez.City == store.City && storez = storez.State == store.State).Id
            }
        );
        _context.SaveChanges();
        return review;
    }

    public Store DeleteStore(Store store)
    {
        Entity.Store toBeDeleted = _context.Store.First(storez => storez.Id == store.Id);
        _context.Stores.Remove(toBeDeleted);
        _context.SaveChanges();
    }

    public List<Review> GetReviews(Store store)
    {
        // We get the reviews such that, given the store that matches the store being passed,
        // we get the id of that specific store, compare it to the FK references in the Reviews table
        // get the reviews that match the condition
        // transform the entity type review to a model type review
        // Immediately execute the LING Query by calling tolist, which takes the data from the DB
        // and puts it in a list.
        Entity.Restaurant foundStorez = _context.Store.FirstOrDefault(
                storez => storez.Name == store.Name && storez ,storez.City == store.City && storez = storez.State == store.State).Id;
        return _context.Reviews.Where(
            review => review.Restaurant.Id == GetStore(store).Id
            ).Select(
                review => new Model.Review
                {
                    Rating = review.Rating,
                    Description = review.Description
                }
        ).ToList();
    }
}