namespace Core.Entities.Order_Entities
{
    public class ProductOrderItem
    {
        public ProductOrderItem()
        {

        }
        public ProductOrderItem(int productId, string productName, string imageCover)
        {
            ProductId = productId;
            ProductName = productName;
            ProductImageCover = imageCover;
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductImageCover { get; set; }
    }
}