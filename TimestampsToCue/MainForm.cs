using System;
using System.IO;
using System.Windows.Forms;
using TimestampsToCueLib;
using TimestampsToCueLib.TimestampProcessor;

namespace TimestampsToCue
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void browseFileBtn_Click(object sender, EventArgs e)
        {
            fileBrowserDialog.ShowDialog();
            var filePath = fileBrowserDialog.FileName;
            var fileName = Path.GetFileName(filePath);
            if (fileName.Contains('.'))
            {
                fileName = fileName.Substring(0, fileName.LastIndexOf('.'));
            }

            filePathTextBox.Text = filePath;
            titleBox.Text = fileName;
        }

        private void processBtn_Click(object sender, EventArgs e)
        {
            var filePath = fileBrowserDialog.FileName;
            var timestampsInput = timestampsTextBox.Text;
            var title = titleBox.Text;

            var timestampsInputSplit = timestampsInput.Split('\n');

            var cueInfo = new CueInfo
            {
                FilePath = filePath, 
                Title = title
            };

            var processor = new AutoProcessor(new TimeStampFormatConverter(), new ColonIndexCalculator());
            foreach (var timestampString in timestampsInputSplit)
            {
                var info = processor.ProcessTimestamp(timestampString);
                cueInfo.Elements.Add(info);
            }

            var output = cueInfo.ToString();
            outputTextBox.Text = output;
        }
    }

}
