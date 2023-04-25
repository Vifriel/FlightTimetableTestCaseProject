using FlightTimetableTestCaseProject.Models;
using FlightTimetableTestCaseProject.ViewModels;
using System;
using System.Text.Json;
using System.Windows;

namespace FlightTimetableTestCaseProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly FlightTimetableByPassengerVMCollection _viewModel;

        public MainWindow()
        {
            InitializeComponent();

            _viewModel = new ();
            //_viewModel.FlightTimetableByPassengerCollection.Add(new FlightTimetableByPassenger() { Number = "123", Date = Convert.ToDateTime("21.02.19"), PassengerName = "Иванов Иван Иванович" });
            //_viewModel.FlightTimetableByPassengerCollection.Add(new FlightTimetableByPassenger() { Number = "223", Date = Convert.ToDateTime("21.02.19"), PassengerName = "Иванов Иван Иванович" });
            //_viewModel.FlightTimetableByPassengerCollection.Add(new FlightTimetableByPassenger() { Number = "323", Date = Convert.ToDateTime("21.02.19"), PassengerName = "Иванов Иван Иванович" });

            DataContext = _viewModel;

        }

        private async void SaveToFileButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ButtonsLogic.SaveButtonLogic saveButtonLogic = new();

                string content = JsonSerializer.Serialize(_viewModel);
                await saveButtonLogic.SaveFileAsync(_viewModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void AddFromFileButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ButtonsLogic.AddFromButtonLogic addFromButtonLogic = new();

                string content = JsonSerializer.Serialize(_viewModel);
                await addFromButtonLogic.GetDeserializedContentFromFileAsync(_viewModel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
