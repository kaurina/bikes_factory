using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class MountainBikes : Bikes
    {
        private ESuspensionType _suspensionType;
        public ESuspensionType SuspensionType { get => _suspensionType; set => _suspensionType = value; }
        public MountainBikes() : base()
        {
            _suspensionType = ESuspensionType.Undefined;
        }
        public MountainBikes(ESuspensionType suspensionType) : base()
        {
            _suspensionType = suspensionType;
        }
        public override string ToString()
        {
            return "Bike Type: Mountain Bike, " + base.ToString() + $", Suspension Type: {_suspensionType}";
        }
        public override bool IsValid()
        {
            bool isValidFromBase = base.IsValid();
            if (!isValidFromBase)
                return false;
            else if (_suspensionType == ESuspensionType.Undefined)
            {
                GotInvalidChildNotification("Please select a suspension type");
                return false;
            }
            return true;
        }
    }
}
