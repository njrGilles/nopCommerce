using Nop.Tests;
using NUnit.Framework;

namespace Nop.Data.Tests.Catalog
{
    [TestFixture]
    public class ProductReviewReviewTypeMappingPersistenceTest : PersistenceTest
    {
        [Test]
        public void Can_save_and_load_productReviewReviewTypeMapping()
        {
            var productReviewReviewTypeMapping = this.GetTestProductReviewReviewTypeMapping();
            var fromDb = SaveAndLoadEntity(this.GetTestProductReviewReviewTypeMapping());            
            fromDb.ShouldNotBeNull();
            fromDb.PropertiesShouldEqual(productReviewReviewTypeMapping);
            fromDb.ProductReview.ShouldNotBeNull();
            fromDb.ProductReview.PropertiesShouldEqual(productReviewReviewTypeMapping.ProductReview);
            fromDb.ReviewType.ShouldNotBeNull();
            fromDb.ReviewType.PropertiesShouldEqual(productReviewReviewTypeMapping.ReviewType);
        }
    }
}
