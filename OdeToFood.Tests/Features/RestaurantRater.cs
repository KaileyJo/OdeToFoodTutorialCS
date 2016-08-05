using System;
using OdeToFood.Models;
using System.Linq;

namespace OdeToFood.Tests.Features
{
    internal class RestaurantRater
    {
        private Restaurant _restaurant;

        public RestaurantRater(Restaurant restaurant)
        {
            this._restaurant = restaurant;
        }

        public RatingResult ComputeResult(IRatingAlgorithm algorithm, int numberOfReviewsToUse)
        {
            var filteredReviews = _restaurant.Reviews.Take(numberOfReviewsToUse);

            return algorithm.Compute(filteredReviews.ToList());
        }
    }
}