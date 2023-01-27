using MyBikesFactory.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business
{
    public class RoadBikes : Bikes
    {
        private ETyreType _tyreType;

        public ETyreType TyreType { get => _tyreType; set => _tyreType = value; }
        public RoadBikes() : base()
        {
            _tyreType = ETyreType.Undefined;
        }
        public RoadBikes(ETyreType tyreType) : base()
        {
            _tyreType = tyreType;
        }
        public override string ToString()
        {
            return "Bike Type: Road, " + base.ToString() + $", Tyre Type: {_tyreType}";
        }
        public override bool IsValid()
        {
            bool isValidFromBase = base.IsValid();
            if (!isValidFromBase)
                return false;
            else if (_tyreType == ETyreType.Undefined)
            {
                GotInvalidChildNotification("Please select a tyre type");
                return false;
            }
            return true;
        }
    }
}
