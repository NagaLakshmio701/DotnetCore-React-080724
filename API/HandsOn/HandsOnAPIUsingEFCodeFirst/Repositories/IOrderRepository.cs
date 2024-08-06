﻿using HandsOnAPIUsingEFCodeFirst.Entities;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public interface IOrderRepository
    {
        void MakeOrder(Order order);
        Order GetOrder(int orderId);
        List<Order> GetAllOrders(int userId);

    }
}
