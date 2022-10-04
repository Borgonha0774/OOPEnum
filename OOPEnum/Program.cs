
using OOPEnum.Entities;
using OOPEnum.Entities.Enums;


Order order = new Order()
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PendingPayement
};

Console.WriteLine(order);


//Convertendo um Enum para String
string txt = OrderStatus.PendingPayement.ToString();
Console.WriteLine($"Enum to String: {txt}");

//Convertendo uma String para Enum
//Some methods below
//OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");
//OrderStatus os;
//Enum.TryParse("Delivered", out os);
OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
Console.WriteLine($"String to Enum: {os}");
