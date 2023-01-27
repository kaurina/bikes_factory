using MyBikesFactory.Business.Enums;
using MyBikesFactory.Business.Delegates;
using MyBikesFactory.Business.Interfaces;
using System.Xml.Serialization;

namespace MyBikesFactory.Business
{
    [Serializable]
    [XmlInclude(typeof(MountainBikes))]
    [XmlInclude(typeof(RoadBikes))]
    public abstract class Bikes : IValidatable
    {
        private int _serialNumber;
        private string _model;
        private EColor _color;
        private int _manufacturingYear;

        public event Notify? GotInvalidNotification;

        public int SerialNumber { get => _serialNumber; set => _serialNumber = value; }
        public string Model { get => _model; set => _model = value; }
        public EColor Color { get => _color; set => _color = value; }
        public int ManufacturingYear { get => _manufacturingYear; set => _manufacturingYear = value; }
        public string InvalidMessage { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Bikes()
        {
            _serialNumber = 0;
            _model = "";
            _color = EColor.Undefined;
            _manufacturingYear = 0;
        }

        public Bikes(int initialSerialNumber) : this()
        {
            _serialNumber = initialSerialNumber;
        }
        public override string ToString()
        {
            return $"Serial Number: {_serialNumber}, Model: {_model}, Color: {_color}, Manufacturing Year: {_manufacturingYear}";
        }

        public virtual bool IsValid()
        {
            if (_serialNumber == 0)
            {
                TriggerGotInvalid("Please enter an serial number greater than 0");
                return false;
            }
            else if (_model == "")
            {
                TriggerGotInvalid("Please enter a model!!!!!!!!!!!!");              
                    return false;
            }
            else if (!Validator.ValidateModel(_model))
            {
                TriggerGotInvalid("Model must be alphanumeric and max length of 5 characters");              
                    return false;
            }
            else if (_color == EColor.Undefined)
            {
                TriggerGotInvalid("Please select a color");
                return false;
            }

            else if (_manufacturingYear == 0)
            {
                TriggerGotInvalid("Please enter a manufacturing year");
                return false;
            }
            return true;
        }
        protected void GotInvalidChildNotification(string message)
        {
            TriggerGotInvalid(message);
        }
        private void TriggerGotInvalid (string message)
        {
            if (GotInvalidNotification == null)
                throw new Exception("Make sure an event handler is " +
                                    "assigned to GotINvalidNotification " +
                                    "before calling the IsValid method");

            GotInvalidNotification(message);
        }
    }
}
