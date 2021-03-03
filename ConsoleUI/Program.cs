using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t\t\t\t\t Araç Kiralama\n\n");


            //********************** Display all cars with details ******
            //GetCarDetailsTest();

            //********************** Add a new car ********************** 
            //Car car1 = new Car
            //{
            //    BrandId = 4,
            //    ColorId = 1,
            //    ModelYear = 2021,
            //    DailyPrice = 300,
            //    Description = "Araç 1 eklendi"
            //};

            //AddCarTest(car1);
            //GetAllCarsTest();

            //**********************  Update a car ********************** 
            //Car carToUpdate = new Car
            //{
            //    Id = 4,
            //    BrandId = 3,
            //    ColorId = 1,
            //    ModelYear = 2017,
            //    DailyPrice = 145,
            //    Description = "Araç 1 güncellendi"
            //};

            //UpdateCarTest(carToUpdate);
            //GetAllCarsTest();

            //**********************  Delete a car *******************************  
            //DeleteCarTest(2);
            //GetAllCarsTest();

            //**********************  Display a car by its ID **********************  
            //GetCarByIdTest(3);

            //**********************  Display cars by BrandID **********************  
            //GetCarsByBrandIdTest(2);

            //**********************  Display cars by ColorID **********************             
            //GetCarsByColorIdTest(3);

            //**********************  Display cars by DailyPrice ********************  
            //GetCarsByDailyPriceTest(225, 235);



            //**********************  Add a new brand *******************************  
            //Brand brand1 = new Brand
            //{
            //    Name = "Peugeot"
            //};

            //AddBrandTest(brand1);
            //GetAllBrandsTest();

            //**********************  Update a brand ********************************* 
            //Brand brandToUpdate = new Brand
            //{
            //    Id = 1,
            //    Name = "Mercedes-Benz"
            //};

            //UpdateBrandTest(brandToUpdate);
            //GetAllBrandsTest();

            //********************** Delete a brand ******************************** 
            //DeleteBrandTest(3);
            //GetAllBrandsTest();

            //********************** Display a brand by ID ************************** 
            //GetBrandByIdTest(2);



            //********************** Add a new color ******************************** 
            //Color color1 = new Color
            //{
            //    Name = "Açık mavi"
            //};

            //AddColorTest(color1);
            //GetAllColorsTest();

            //********************** Update a color ********************************** 
            //Color colorToUpdate = new Color
            //{
            //    Id = 4,
            //    Name = "Koyu Yeşil"
            //};

            //UpdateColorTest(colorToUpdate);
            //GetAllColorsTest();

            //********************** Delete a color ******************************** 
            //DeleteColorTest(1);
            //GetAllColorsTest();

            //Displaying a color by ID in the system
            //GetColorByIdTest(1);


            //********************** Add a brand whose name < 2 characters
            //Brand brand2 = new Brand
            //{
            //    Name = "a"
            //};

            //AddBrandTest(brand2);
            //GetAllBrandsTest();

            //********************** Add a car whose daily price > 0 
            //Car car2 = new Car
            //{
            //    BrandId = 2,
            //    ColorId = 1,
            //    ModelYear = 2011,
            //    DailyPrice = -250,
            //    Description = "DailyPrice negatif"
            //};

            //AddCarTest(car2);
            //GetAllCarsTest();


            //********************** Add a new customer ***************************** 
            //Customer customer1 = new Customer
            //{
            //    UserId = 3,
            //    CompanyName = "ABC"
            //};

            //AddCustomerTest(customer1);
            //GetAllCustomersTest();

            //********************** Delete a customer ******************************
            //DeleteCustomerTest(2);
            //GetAllCustomersTest();

            //********************** Update a customer ******************************** 
            //Customer customerToUpdate = new Customer
            //{
            //    Id = 3,
            //    UserId = 3,
            //    CompanyName = "DEF"
            //};

            //UpdateCustomerTest(customerToUpdate);
            //GetAllCustomersTest();

            //********************** Display a customer by ID ************************** 
            //GetCustomerByIdTest(1);

            //********************** Display a customer by UserID ********************** 
            //GetCustomerByUserIdTest(2);

            //********************** Display a customer by CompanyName ****************** 
            //GetCustomerByCompanyNameTest("ABC");

            //********************** Display all customers with details *****************
            //GetCustomerDetailsTest();


            //********************** Add a new rental ********************************** 

            //Rental rental1 = new Rental
            //{
            //    CarId = 1,
            //    CustomerId = 2,
            //    RentDate = new DateTime(2021, 02, 15),
            //    ReturnDate = new DateTime(2021, 03, 15)
            //};

            //AddRentalTest(rental1);
            //GetAllRentalsTest();

            //********************** Update a rental *************************************

            //Rental rental2 = new Rental
            //{
            //    Id = 3,
            //    CarId = 1,
            //    CustomerId = 2,
            //    RentDate = new DateTime(2021, 02, 15),
            //    ReturnDate = DateTime.Now
            //};

            //UpdateRentalTest(rental2);
            //GetAllRentalsTest();

            //********************** Display a rental by ID *******************************
            //GetRentalByIdTest(1);

            //********************** Display a rental by CarID ****************************
            //GetRentalsByCarIdTest(1);

            //********************** Display all rentals with details ***********************
            //GetRentalDetailsTest();
        }


        // ************ Car ************
        private static void GetAllCarsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\tAll Cars in the System");
                string str = new string('_', 180);
                Console.WriteLine(str + "\n\n" +
                                  "\tId\t\tBrandId\t\tColorId\t\tModelYear\tDailyPrice\tDescription\t");

                foreach (var car in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t",
                         car.Id, car.BrandId, car.ColorId,
                         car.ModelYear, car.DailyPrice, car.Description);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarByIdTest(int id)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetById(id);
            Car carById = result.Data;

            if (result.Success == true)
            {
                Console.WriteLine("Car whose Id is {0}", id);
                string str = new string('_', 180);
                Console.WriteLine(str + "\n\n" + "\tId\t\tBrandId\t\tColorId\t\tModelYear\tDailyPrice\tDescription\t");

                Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t",
                      carById.Id, carById.BrandId, carById.ColorId,
                      carById.ModelYear, carById.DailyPrice, carById.Description);

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetailsTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            var result = carManager.GetCarDetails();

            if (result.Success == true)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\tCar Details");
                string str = new string('_', 180);

                Console.WriteLine(str + "\n\n" +
                                      "\tId\t\tBrand\t\tColor\t\tPrice\t\tStatus\t");

                foreach (var detail in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t",
                        detail.CarId, detail.BrandName, detail.ColorName,
                        detail.DailyPrice, detail.Description);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }          
        }

        private static void GetCarsByBrandIdTest(int brandId)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetByBrandId(brandId);
            List<Car> carsByBrandId = result.Data;

            if (result.Success == true)
            {
                Console.WriteLine("Car whose BrandId is {0}", brandId);
                string str = new string('_', 180);
                Console.WriteLine(str + "\n\n" + "\tId\t\tBrandId\t\tColorId\t\tModelYear\tDailyPrice\tDescription\t");

                foreach (var car in carsByBrandId)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t",
                      car.Id, car.BrandId, car.ColorId,
                      car.ModelYear, car.DailyPrice, car.Description);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarsByColorIdTest(int colorId)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetByColorId(colorId);
            List<Car> carsByColorId = result.Data;

            if (result.Success == true)
            {
                Console.WriteLine("Car whose ColorId is {0}", colorId);
                string str = new string('_', 180);
                Console.WriteLine(str + "\n\n" + "\tId\t\tBrandId\t\tColorId\t\tModelYear\tDailyPrice\tDescription\t");

                foreach (var car in carsByColorId)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t",
                      car.Id, car.BrandId, car.ColorId,
                      car.ModelYear, car.DailyPrice, car.Description);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarsByDailyPriceTest(int min, int max)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetByDailyPrice(min, max);
            List<Car> carsByDailyPrice = result.Data;

            if (result.Success == true)
            {
                Console.WriteLine("Car whose DailyPrice is greater than {0} and less than {1}", min, max);
                string str = new string('_', 180);
                Console.WriteLine(str + "\n\n" + "\tId\t\tBrandId\t\tColorId\t\tModelYear\tDailyPrice\tDescription\t");

                foreach (var car in carsByDailyPrice)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t",
                      car.Id, car.BrandId, car.ColorId,
                      car.ModelYear, car.DailyPrice, car.Description);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void AddCarTest(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Add(car);

            Console.WriteLine(result.Message);
        }

        private static void DeleteCarTest(int id)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Delete(carManager.GetById(id).Data);

            Console.WriteLine(result.Message);
        }

        private static void UpdateCarTest(Car car)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.Update(car);

            Console.WriteLine(result.Message);
        }

        // ************ Brand ************
        private static void AddBrandTest(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.Add(brand);

            Console.WriteLine(result.Message);
        }

        private static void DeleteBrandTest(int id)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.Delete(brandManager.GetById(id).Data);

            Console.WriteLine(result.Message);
        }

        private static void UpdateBrandTest(Brand brand)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.Update(brand);

            Console.WriteLine(result.Message);
        }

        private static void GetAllBrandsTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine("\tAll Brands in the System");
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tName\t");

                foreach (var brand in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t",
                        brand.Id, brand.Name);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetBrandByIdTest(int id)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            var result = brandManager.GetById(id);
            Brand brandById = result.Data;

            if (result.Success == true)
            {
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tName\t");

                Console.WriteLine("\t{0}\t\t{1}\t",
                    brandById.Id, brandById.Name);

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        // ************ Color ************
        private static void AddColorTest(Color color)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.Add(color);

            Console.WriteLine(result.Message);
        }

        private static void DeleteColorTest(int id)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.Delete(colorManager.GetById(id).Data);

            Console.WriteLine(result.Message);
        }

        private static void UpdateColorTest(Color color)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.Update(color);

            Console.WriteLine(result.Message);
        }

        private static void GetAllColorsTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine("\tAll Colors in the System");
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tName\t");

                foreach (var color in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t",
                        color.Id, color.Name);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetColorByIdTest(int id)
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());

            var result = colorManager.GetById(id);
            Color colorbyId = result.Data;

            if (result.Success == true)
            {
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tName\t");

                Console.WriteLine("\t{0}\t\t{1}\t",
                    colorbyId.Id, colorbyId.Name);

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        // ************ Customer ************
        private static void AddCustomerTest(Customer customer)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.Add(customer);

            Console.WriteLine(result.Message);
        }

        private static void DeleteCustomerTest(int id)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.Delete(customerManager.GetById(id).Data);

            Console.WriteLine(result.Message);
        }

        private static void UpdateCustomerTest(Customer customer)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.Update(customer);

            Console.WriteLine(result.Message);
        }

        private static void GetAllCustomersTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine("\t\tAll Customers in the System");
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tUserID\t\tCompany Name\t");

                foreach (var customer in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t",
                        customer.Id, customer.UserId, customer.CompanyName);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCustomerByIdTest(int id)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetById(id);
            Customer customerById = result.Data;

            if (result.Success == true)
            {
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tUserID\t\tCompany Name\t");

                Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t",
                    customerById.Id, customerById.UserId, customerById.CompanyName);

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCustomerByUserIdTest(int userId)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetByUserId(userId);
            Customer customerByUserId = result.Data;

            if (result.Success == true)
            {
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tUserID\t\tCompany Name\t");

                Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t",
                    customerByUserId.Id, customerByUserId.UserId, customerByUserId.CompanyName);

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCustomerByCompanyNameTest(string companyName)
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetByCompanyName(companyName);
            Customer customerByCompanyName = result.Data;

            if (result.Success == true)
            {
                string str = new string('_', 50);
                Console.WriteLine(str + "\n\n\tID\t\tUserID\t\tCompany Name\t");

                Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t",
                    customerByCompanyName.Id, customerByCompanyName.UserId, customerByCompanyName.CompanyName);

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCustomerDetailsTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());

            var result = customerManager.GetCustomerDetails();

            if (result.Success == true)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\tCustomer Details");
                string str = new string('_', 180);

                Console.WriteLine(str + "\n\n" +
                                      "\tId\t\tFirstName\t\tLastName\t\tCompanyName\t");

                foreach (var detail in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t",
                        detail.Id, detail.FirstName, detail.LastName, detail.CompanyName);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        // ************ Rental ************
        private static void AddRentalTest(Rental rental)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Add(rental);

            Console.WriteLine(result.Message);
        }

        private static void UpdateRentalTest(Rental rental)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.Update(rental);

            Console.WriteLine(result.Message);
        }

        private static void GetAllRentalsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetAll();

            if (result.Success == true)
            {
                Console.WriteLine("\tAll Rentals in the System");
                string str = new string('_', 150);
                Console.WriteLine(str + "\n\n\tID\t\tCarID\t\tCustomerID\t\tRentDate\t\tReturnDate\t");

                foreach (var rental in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t",
                        rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetRentalByIdTest(int id)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetById(id);
            Rental rentalById = result.Data;

            if (result.Success == true)
            {
                string str = new string('_', 150);
                Console.WriteLine(str + "\n\n\tID\t\tCarID\t\tCustomerID\t\tRentDate\t\tReturnDate\t");

                Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t",
                        rentalById.Id, rentalById.CarId, rentalById.CustomerId, rentalById.RentDate, rentalById.ReturnDate);

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetRentalsByCarIdTest(int carId)
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetByCarId(carId);
            List<Rental> rentalsByCarId = result.Data;

            if (result.Success == true)
            {
                Console.WriteLine("Rental whose CarId is {0}", carId);
                string str = new string('_', 150);
                Console.WriteLine(str + "\n\n\tID\t\tCarID\t\tCustomerID\t\tRentDate\t\tReturnDate\t");

                foreach (var rental in rentalsByCarId)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t",
                        rental.Id, rental.CarId, rental.CustomerId, rental.RentDate, rental.ReturnDate);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetRentalDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetails();

            if (result.Success == true)
            {
                Console.WriteLine("\t\t\t\t\t\t\t\tRental Details");
                string str = new string('_', 180);

                Console.WriteLine(str + "\n\n\tID\t\tCarID\t\tCustomerID\t\tCustomerName\t\tRentDate\t\tReturnDate\t");

                foreach (var detail in result.Data)
                {
                    Console.WriteLine("\t{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}\t\t{5}\t",
                        detail.Id, detail.CarId, detail.CustomerId, detail.CustomerName, detail.RentDate, detail.ReturnDate);
                }

                Console.WriteLine(str + "\n");
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}