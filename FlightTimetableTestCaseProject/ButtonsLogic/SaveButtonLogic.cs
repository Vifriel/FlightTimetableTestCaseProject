using FlightTimetableTestCaseProject.SharedLogic;
using Microsoft.Win32;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace FlightTimetableTestCaseProject.ButtonsLogic
{
    internal class SaveButtonLogic
    {
        public async Task SaveFileAsync(ViewModels.FlightTimetableByPassengerVMCollection viewModel)
        {
            if (viewModel is null || viewModel.FlightTimetableByPassengerCollection is null || viewModel.FlightTimetableByPassengerCollection.Count == 0)
                    return;

            SaveFileDialog sfd = new SaveFileDialog();
            var fdSharedLogic = new CommonFileDialogSettings();
            fdSharedLogic.ApplySettingsToFileDialog(sfd);

            if (sfd.ShowDialog() == true)
            {

                using FileStream createStream = File.Create(sfd.FileName);
                await JsonSerializer.SerializeAsync(createStream, viewModel);
                await createStream.DisposeAsync();
                MessageBox.Show("Готово!");
            }
        }
    }
}
