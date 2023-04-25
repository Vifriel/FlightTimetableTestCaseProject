using Microsoft.Win32;
using System.IO;

namespace FlightTimetableTestCaseProject.SharedLogic
{
    internal class CommonFileDialogSettings
    {
        public string InitialDirectory { get; } = Directory.GetDirectoryRoot(Directory.GetCurrentDirectory());
        public string Filter { get; } = "JSON-files (*.json)|*.json";
        public bool AddExtension { get; } = true;
        public string DefaultExt { get; } = ".json";

        public void ApplySettingsToFileDialog(FileDialog fd)
        {
            fd.InitialDirectory = this.InitialDirectory;
            fd.Filter = this.Filter;
            fd.AddExtension = this.AddExtension;
            fd.DefaultExt = this.DefaultExt;
        }
    }
}
