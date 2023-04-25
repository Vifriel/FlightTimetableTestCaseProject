using FlightTimetableTestCaseProject.SharedLogic;
using FlightTimetableTestCaseProject.ViewModels;
using Microsoft.Win32;
using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows;

namespace FlightTimetableTestCaseProject.ButtonsLogic
{
    internal class AddFromButtonLogic
    {
        public async Task GetDeserializedContentFromFileAsync(FlightTimetableByPassengerVMCollection vm)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var fdSharedLogic = new CommonFileDialogSettings();
            fdSharedLogic.ApplySettingsToFileDialog(ofd);

            if (ofd.ShowDialog() == true)
            {
                using (FileStream fs = File.OpenRead(ofd.FileName))
                {
                    await GetDeserializedContentFromFileStreamAsync(fs, vm);
                }
                MessageBox.Show("Готово!");
            }
        }

        private async Task GetDeserializedContentFromFileStreamAsync(FileStream fs, FlightTimetableByPassengerVMCollection vm)
        {
            var contentCollection = await JsonSerializer.DeserializeAsync<FlightTimetableByPassengerVMCollection>(fs);
            if (contentCollection == null || contentCollection.FlightTimetableByPassengerCollection == null || contentCollection.FlightTimetableByPassengerCollection.Count == 0)
            {
                throw new ArgumentNullException("Отсутствуют данные для импорта.");
            }

            vm.FlightTimetableByPassengerCollection.Clear();

            foreach (var item in contentCollection.FlightTimetableByPassengerCollection)
            {
                vm.FlightTimetableByPassengerCollection.Add(item);
            }
        }
    }
}
