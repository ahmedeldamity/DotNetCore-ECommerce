using Core.Entities.Order_Entities;

namespace Core.Specifications.Order_Specifications
{
    public class OrderWithPaymentIntentSpecifications : BaseSpecification<Order>
    {
        public OrderWithPaymentIntentSpecifications(string paymentIntentId)
        {
            WhereCriteria = O => O.PaymentIntentId == paymentIntentId;
        }
    }
}