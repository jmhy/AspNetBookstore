using System.Web.Mvc;

namespace AspNetBookstore.Models
{
    [Bind(Exclude = "OrderId")]
    public partial class Order
    {
    }
}