using MyBikesFactory.Business.Delegates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactory.Business.Interfaces
{
    public interface IValidatable
    {
        event Notify GotInvalidNotification;
        bool IsValid();
        string InvalidMessage { get; set; }
    }
}
