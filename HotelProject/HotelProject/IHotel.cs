using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    [ServiceContract]
    public interface IHotel
    {
        [OperationContract]
        IEnumerable<HotelModel> GetAllHotel();
        [OperationContract]
        HotelModel GetHotelById(int id);
    }
}
