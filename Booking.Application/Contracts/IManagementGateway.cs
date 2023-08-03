using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementInquiry.Application.Contracts
{
    public interface IManagementGateway
    {
        Task<Product?> GetProductBySku(string sku);
    }
}
