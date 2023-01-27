using MyBikesFactory.Business.Interfaces;
using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public static class Validator
    {
        public static bool CheckValidity(IValidatable objectToCheck)//will create a log to display issues. interfaces can be used as ?? : example of polymorphism. 2 classes can have something in common
        {
            bool result = objectToCheck.IsValid();
            if (!result)
                System.Diagnostics.Debug.WriteLine("The object "+ objectToCheck+ " has a problem "+
                                                    objectToCheck.InvalidMessage);

            return result;
        }

        public static bool ValidateId(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, "^[0-9]+$");
        }
        public static bool ValidateUniqueId(string inputToCheck, List<Bikes> listOfBikes)
        {
            int serialNumber = Convert.ToInt32(inputToCheck);
            foreach (var bike in listOfBikes)
            {
                if (bike.SerialNumber == serialNumber)
                    return false;
            }
            return true;

            //return !listOfBikes.Any(s => b.SerialNumber == Convert.ToInt32(inputToCheck));
        }
        public static bool ValidateModel(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^\w{5}$");
        }
        public static bool ValidateYear(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^[0-9]{4}$");
        }
    }
}
