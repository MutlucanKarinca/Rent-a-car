using System;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //RentalDetailsTest();
            //AddRentalTest();
            //CarDeleteTest();
            //CarDetailTest();
            //UserAdd();
        }

        private static void RentalDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAllRentalDetails();
            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarName + "/" + rental.BrandName + "/" + rental.CompanyName + "/" +
                                      rental.RentDate + "/" + rental.UserName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddRentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.Add(new Rental
            {
                CarId = 5,
                CustomerId = 1,
                RentDate = DateTime.Now
            });
            Console.WriteLine(result.Message);
        }

        private static void UserAdd()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User
            { FirstName = "Dimitrios", LastName = "Pelkas", Email = "deneme2@gmail.com", Password = "1907" });
        }

        private static void CarDeleteTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Delete(new Car { CarId = 2 });
        }

        private static void CarDetailTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetail();
            if (result.Success == true)
            {
                foreach (var car in carManager.GetCarDetail().Data)
                {
                    Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}