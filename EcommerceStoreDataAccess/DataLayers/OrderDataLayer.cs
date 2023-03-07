using EcommerceStoreDomain.Entities;

namespace EcommerceStoreDataAccess.DataLayers
{
    internal class OrderDataLayer
    {
       private readonly DatabaseContext _dbContext;
       private OrderDataLayer(DatabaseContext databaseContext) 
       {
            _dbContext = databaseContext;
       }

        private void CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }
            else
            {
                _dbContext.Order.Add(order);
                _dbContext.SaveChanges();
            }
        }


    }
}
