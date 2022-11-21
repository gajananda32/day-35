using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductRiviewMangement
{
    public class Mangement
    {
        public void SelecctedRecords(List<ProdutcReview> listproductreview)
        {
            var recordData = (from ProdutcReview in listproductreview
                              orderby ProdutcReview.Rating descending
                              select ProdutcReview).Take(3);
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.productID + " UserID: " + list.userID + " Rating: " + list.Rating + " Review: " + list.Review + " Islike: " + list.isLike);
            }
        }
        public void SpecificRecords(List<ProdutcReview> listproductreview)
        {
            var recordData = from review in listproductreview
                             where (review.productID == 1 && review.Rating > 3 || (review.productID == 4 && review.Rating > 3) ||
                            review.productID == 9 && review.Rating > 3)
                             select review;
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.productID + " UserID: " + list.userID + " Rating: " + list.Rating + " Review: " + list.Review + " Islike: " + list.isLike);
            }
        }
        public void RetriveCountofRecord(List<ProdutcReview> listproductreview)
        {
            var recordData = listproductreview.GroupBy(x => x.productID).Select(x => new { productID = x.Key, Count = x.Count() });
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.productID + "--------" + list.Count);
            }
        }
        public void RetriveProductIDAndReview(List<ProdutcReview> listproductreview)
        {
            var recordData = listproductreview.Select(x => new { productID = x.productID, Review = x.Review, Rating = x.Rating });
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.productID +" rating: " + list.Rating+" review: "+list.Review );
            }
        }
        public void RetriveOnlyProductID(List<ProdutcReview> listproductreview)
        {
            var recordData = listproductreview.Select(x => new { productID = x.productID });
            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID: " + list.productID);
            }
        }
        public void RetriveDatatableIslikeIsTrue(List<ProdutcReview> listproductreview)
        {
            var recordData = from review in listproductreview
                             where (review.isLike == true)
                             select review;
           // var recordData = listproductreview.Select(x => x.isLike ==true);
            foreach (var list in recordData)
            {
                Console.WriteLine(list.isLike );
            }
        }
    }
}
