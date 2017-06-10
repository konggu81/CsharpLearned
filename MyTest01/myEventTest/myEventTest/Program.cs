using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myEventTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var dealer = new CarDealer();

            var michael = new Consumer("老王");
            //dealer.NewCarInfo += michael.NewCarIsHere;
            WeakCarInfoEventManager.AddListener(dealer, michael);

            dealer.NewCar("法拉利");

            var sebastian = new Consumer("老张");
            //dealer.NewCarInfo += sebastian.NewCarIsHere;
            WeakCarInfoEventManager.AddListener(dealer, sebastian);


            dealer.NewCar("奔驰");
            //dealer.NewCarInfo -= michael.NewCarIsHere;
            WeakCarInfoEventManager.RemoveListener(dealer, michael);

            dealer.NewCar("奥迪");

            Console.ReadKey();
        }
    }
}
