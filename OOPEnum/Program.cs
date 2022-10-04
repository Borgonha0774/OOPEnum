
using OOPEnum.Entities;
using OOPEnum.Entities.Enums;


Order order = new Order()
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayement
};

Console.WriteLine(order);
