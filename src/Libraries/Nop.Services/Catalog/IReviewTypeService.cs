using System.Collections.Generic;
using Nop.Core.Domain.Catalog;

namespace Nop.Services.Catalog
{
    /// <summary>
    /// Review type service interface
    /// </summary>
    public partial interface IReviewTypeService
    {
        /// <summary>
        /// Delete review type
        /// </summary>
        /// <param name="reviewType">Review type</param>
        void DeleteReiewType(ReviewType reviewType);

        /// <summary>
        /// Gets all review types
        /// </summary>
        /// <param name="loadCacheableCopy">A value indicating whether to load a copy that could be cached (workaround until Entity Framework supports 2-level caching)</param>
        /// <returns>Review types</returns>
        IList<ReviewType> GetAllReviewTypes();

        /// <summary>
        /// Gets review type 
        /// </summary>
        /// <param name="reviewTypeId">Review type identifier</param>
        /// /// <param name="loadCacheableCopy">A value indicating whether to load a copy that could be cached (workaround until Entity Framework supports 2-level caching)</param>
        /// <returns>Review type</returns>
        ReviewType GetReviewTypeById(int reviewTypeId);

        /// <summary>
        /// Inserts review type
        /// </summary>
        /// <param name="reviewType">Review type</param>
        void InsertReviewType(ReviewType reviewType);

        /// <summary>
        /// Updates the review type
        /// </summary>
        /// <param name="reviewType">Review type</param>
        void UpdateReviewType(ReviewType reviewType);
    }
}
