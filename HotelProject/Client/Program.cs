using Client.HotelServices;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            HotelClient services = new HotelClient("BasicHttpBinding_IHotel");
            //string jsonData = JsonConvert.SerializeObject(services.GetAllHotel());
            List<HotelModel> hotels = new List<HotelModel>();
            hotels= services.GetAllHotel().ToList();
            foreach(HotelModel i in hotels)
            {
                Console.WriteLine("Id :"+i.Id);
                Console.WriteLine("Name :"+i.Name);
                Console.WriteLine("Address :"+i.Address);
                Console.WriteLine("Rating :"+i.Rating);
                Console.WriteLine("Price :"+i.Price);
                Console.WriteLine();
            }
            Console.WriteLine("Enter Id to Search");
            int id = int.Parse(Console.ReadLine());
            HotelModel hotelobject = new HotelModel();
            hotelobject = services.GetHotelById(id);
            Console.WriteLine("Id :" + hotelobject.Id);
            Console.WriteLine("Name :" + hotelobject.Name);
            Console.WriteLine("Address :" + hotelobject.Address);
            Console.WriteLine("Rating :" + hotelobject.Rating);
            Console.WriteLine("Price :" + hotelobject.Price);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
