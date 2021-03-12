using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string MaintenanceTime = "System is Maintenance";
        public static string CarAdded = "Car Added";
        public static string CarModified = "Car Updated";
        public static string CarDeleted = "Car Deleted";
        public static string CarsListed = "Cars Listed";
        public static string CarListedById = "Cars Listed By Id";
        public static string CarInvalidName = "Car Has a Invlaid Name";
        public static string CarInvalidPrice = "Car Price Has a Wrong Amount Of Money";
        public static string CarsListedByBrandId = "Cars Listed By Brand Id";
        public static string CarsListedByColorId = "Cars Listed By Color Id";
        public static string CarsListedByTwoPrices = "Cars Listed Between Two Prices";
        public static string CarDetailsListed = "Car Details Listed";

        public static string ColorsListed = "Colors Listed";
        public static string ColorAdded = "Color Added";
        public static string ColorListedById = "Color Listed By Id";
        public static string ColorModified = "Color Modified";
        public static string ColorDeleted = "Color Deleted";

        public static string BrandsListed = "Brands Listed";
        public static string BrandAdded = "Brand Added";
        public static string BrandListedById = "Brand Listed By Id";
        public static string BrandModified = "Brand Modified";
        public static string BrandDeleted = "Brand Deleted";

        public static string UsersListed = "Users Listed";
        public static string UserAdded = "User Added";
        public static string UserListedById = "User Listed By Id";
        public static string UserModified = "User Modified";
        public static string UserDeleted = "User Deleted";

        public static string CustomersListed = "Customers Listed";
        public static string CustomerAdded = "Customer Added";
        public static string CustomerListedById = "Customer Listed By Id";
        public static string CustomerModified = "Customer Modified";
        public static string CustomerDeleted = "Customer Deleted";

        public static string RentalsListed = "Rentals Listed";
        public static string RentalAdded = "Rental Added";
        public static string RentalListedById = "Rental Listed By Id";
        public static string RentalModified = "Rental Modified";
        public static string RentalDeleted = "Rental Deleted";
        public static string CarCantRentable = "Car Can Not Be Rented";
        public static string HaventCar = "We Dont Have A Car For Rent";
        public static string CarImageAdded="Car image added";
        public static string CarImageDeleted = "Car Image Deleted";
        public static string CarImagesListed = "Car Images Listed";
        public static string CarImageListedById = "Car Image Listed By Id";
        public static string CarImageUpdated = "Car Image Updated";
        public static string CarNameAlreadyExists = "Car Name Already Exists";
        public static string CountOfCarImagesCorrect="Araba resim sayısı fazla";
        public static string CarImageLimitExceeded = "Car Image Limit Exceted";
        public static string AuthorizationDenied="Access Denied";
        public static string UserRegistered="User Registered";
        public static string UserNotFound="User Not Found";
        public static string PasswordError = "Error Pasword!";
        public static string SuccessfulLogin = "Login Successful";
        public static string UserAlreadyExists = "User Already Exists";
        public static string AccessTokenCreated = "Acces Token Created";
        public static string CarUpdatedByTransaction="Car Updated By Transaction Aspect";
        internal static string CustomerDetailsListed;
        internal static string RentalDetailsListed;
    }
}
