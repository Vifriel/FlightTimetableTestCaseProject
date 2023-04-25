using Prism.Mvvm;
using System;

namespace FlightTimetableTestCaseProject.Models
{
    internal class FlightTimetableByPassenger : BindableBase
    {
        private string _number;
        public string Number
        {
            get { return _number; }
            set
            {
                _number = value;
                RaisePropertyChanged(nameof(Number));
            }
        }

        private DateTime _date;
        public DateTime Date
        {
            get { return _date; }
            set
            {
                _date = value;
                RaisePropertyChanged(nameof(Date));
            }
        }

        private string _passengerName;
        public string PassengerName
        {
            get { return _passengerName; }
            set
            {
                _passengerName = value;
                RaisePropertyChanged(nameof(PassengerName));
            }
        }
    }
}
