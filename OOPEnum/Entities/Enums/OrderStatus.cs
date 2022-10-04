
namespace OOPEnum.Entities.Enums
{
    //Estamos derivando da classe int
    enum OrderStatus : int
    {
        //Se não atribuirmos valores iniciais ele por padrão inicia em 0
        PendingPayement,    
        Processing, 
        Shipped,    
        Delivered,  
    }
}
