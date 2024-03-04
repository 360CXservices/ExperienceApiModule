using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtoCommerce.ExperienceApiModule.XOrder.Models
{
    public enum OrderStatus
    {
        Pending,
        Cancelled,
        Completed,
        Confirmed,
        Delivered,
        Incompleted,
        New,
        Paid,
        Rejected,
        Returned,
        Shipped
    }
}
