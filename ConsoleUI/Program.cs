using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemoryCarDal;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region CarTransactions

            CarManager carManager = new CarManager(new EfCarDal(), new BrandManager(new EfBrandDal()));

            //carManager.Add(new Car { BrandId = 1, ColorId = 4, DailyPrice = 123, ModelYear = 2010, Description = "v1" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 6, DailyPrice = 220, ModelYear = 2022, Description = "v2" });
            //carManager.Add(new Car { BrandId = 3, ColorId = 7, DailyPrice = 5555, ModelYear = 2012, Description = "v3" });
            //carManager.Add(new Car { BrandId = 4, ColorId = 2, DailyPrice = 1234, ModelYear = 2011, Description = "v4" });
            //carManager.Add(new Car { BrandId = 4, ColorId = 4, DailyPrice = 5621, ModelYear = 2021, Description = "v5" });
            //carManager.Add(new Car { BrandId = 6, ColorId = 1, DailyPrice = 21, ModelYear = 2022, Description = "v6" });
            //carManager.Add(new Car { BrandId = 7, ColorId = 5, DailyPrice = 144, ModelYear = 2000, Description = "v7" });
            //carManager.Add(new Car { BrandId = 1, ColorId = 3, DailyPrice = 1700, ModelYear = 2001, Description = "v8" });
            //carManager.Add(new Car { BrandId = 3, ColorId = 1, DailyPrice = 2214, ModelYear = 1999, Description = "v9" });
            //carManager.Add(new Car { BrandId = 2, ColorId = 1, DailyPrice = 1122, ModelYear = 1985, Description = "v10" });

            //foreach (var car in carManager.GetAllByModelYear(2000, 2005))
            //{
            //    Console.WriteLine(car.CarId + " " + car.ModelYear);
            //}

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.ModelYear);
            //}

            //int kacinci = 0;
            //var result = carManager.GetCarDetails();

            //if (result.Success == true)
            //{
            //    foreach (var car in carManager.GetCarDetails().Data)
            //    {
            //        kacinci++;
            //        Console.WriteLine("{6}.Arabanın Numarası : {0} \nMarkası : {1}" +
            //            "\nRengi : {2}\nModeli : " + "{3}\nGünlük Kiralama Bedeli : {4}$" + "\nVersiyonu : {5}"
            //            , car.CarId, car.BrandName, car.ColorName, car.ModelYear, car.DailyPrice, car.Description, kacinci);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}


            #endregion

            #region BrandTransactions

            BrandManager brandManager = new BrandManager(new EfBrandDal());

            //brandManager.Add(new Brand { Name = "Audi" });
            //brandManager.Add(new Brand { Name = "Bmw" });
            //brandManager.Add(new Brand { Name = "Mercedes" });
            //brandManager.Add(new Brand { Name = "Golf" });
            //brandManager.Add(new Brand { Name = "Polo" });
            //brandManager.Add(new Brand { Name = "Şahin" });
            //brandManager.Add(new Brand { Name = "Kartal" });

            //foreach (var brand in brandManager.GetAll())
            //{
            //    Console.WriteLine(brand.BrandId + " " + brand.Name);
            //}

            //Console.WriteLine(brandManager.GetAll().Last().BrandId);

            //Console.WriteLine(brandManager.GetByBrandId(1).Name);

            #endregion

            #region ColorTransactions

            ColorManager colorManager = new ColorManager(new EfColorDal());

            //colorManager.Add(new Color { Name = "Siyah" });
            //colorManager.Add(new Color { Name = "Beyaz" });
            //colorManager.Add(new Color { Name = "Kırmızı" });
            //colorManager.Add(new Color { Name = "Mavi" });
            //colorManager.Add(new Color { Name = "Turuncu" });
            //colorManager.Add(new Color { Name = "Kahverengi" });
            //colorManager.Add(new Color { Name = "Gri" });
            //colorManager.Add(new Color { Name = "Açık Mavi" });

            //colorManager.DeleteByColorId(2002);

            //foreach (var color in colorManager.GetAll())
            //{
            //    Console.WriteLine(color.ColorId + " " + color.Name);
            //}

            //var result = colorManager.GetAll().Where(c => c.ColorId > 4);

            //foreach (var color in result)
            //{
            //    Console.WriteLine(color.Name);
            //}
            #endregion

            #region UserTransactions

            UserManager userManager = new UserManager(new EfUserDal());

            //userManager.Add(new User { FirstName = "Erkam", LastName = "Cengiz", Email = "erkamcengiz@gmail.com", Password = "123" });
            //userManager.Update(new User { UserId = 1, FirstName = "Ali", LastName = "Cengiz", Email = "erkamcengiz@gmail.com", Password = "123" });

            //foreach (var user in userManager.GetAll().Data)
            //{
            //    Console.WriteLine(user.UserId + " " + user.FirstName + " " + user.LastName + " \n" + userManager.GetAll().Message + " " + userManager.GetAll().Success);
            //}



            #endregion

            Console.ReadLine();
        }
    }
}
