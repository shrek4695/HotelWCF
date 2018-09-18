using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject
{
    public class HotelService : IHotel
    {
        public static List<HotelModel> hotels = new List<HotelModel>();
        [OperationBehavior]
        public IEnumerable<HotelModel> GetAllHotel()
        {
            List<HotelModel> items;
            using (StreamReader r = new StreamReader("C:\\Users\\skapoor\\source\\repos\\HotelProject\\HotelProject\\HotelsList.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<HotelModel>>(json);
            }
            return items;
        }
        [OperationBehavior]
        public HotelModel GetHotelById(int id)
        {
            List<HotelModel> items;
            using (StreamReader r = new StreamReader("C:\\Users\\skapoor\\source\\repos\\HotelProject\\HotelProject\\HotelsList.json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<HotelModel>>(json);
            }
            HotelModel hotel = items.Find(i => i.Id == id);
            return hotel;
        }
    }
}
