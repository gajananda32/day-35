namespace ProductRiviewMangement
{
    public class Program
    {
       public static void Main(string[] args)
        {
            List<ProdutcReview> produtcReviews = new List<ProdutcReview>()
            {
                new ProdutcReview() { productID =1,userID =1,Rating =5,Review ="Good",isLike =true},
                new ProdutcReview() { productID =2,userID =2,Rating =5,Review ="Good",isLike =true},
                new ProdutcReview() { productID =3,userID =3,Rating =4,Review ="Good",isLike =true},
                new ProdutcReview() { productID =4,userID =4,Rating =3,Review ="bad",isLike =false},
                new ProdutcReview() { productID =5,userID =5,Rating =3,Review ="bad",isLike =true},
                new ProdutcReview() { productID =6,userID =6,Rating =5,Review ="Good",isLike =true},
                new ProdutcReview() { productID =7,userID =7,Rating =2,Review ="bad",isLike =false},
                new ProdutcReview() { productID =7,userID =8,Rating =5,Review ="nice",isLike =true},
                new ProdutcReview() { productID =8,userID =5,Rating =5,Review ="Good",isLike =true},
                new ProdutcReview() { productID =9,userID =9,Rating =3,Review ="bad",isLike =true},                          
            };
            Mangement mangement = new Mangement();
            // mangement.SelecctedRecords(produtcReviews);
            //mangement.SpecificRecords(produtcReviews);
            // mangement.RetriveCountofRecord(produtcReviews);
            //mangement.RetriveProductIDAndReview(produtcReviews);
            // mangement.RetriveOnlyProductID(produtcReviews);
           // mangement.RetriveDatatableIslikeIsTrue(produtcReviews);

        }
    }
}