using FlightTimetableTestCaseProject.Models;
using System.Collections.ObjectModel;

namespace FlightTimetableTestCaseProject.ViewModels
{
    internal class FlightTimetableByPassengerVMCollection
    {
        public ObservableCollection<FlightTimetableByPassenger> FlightTimetableByPassengerCollection { get; set; } = new();
    }
}
