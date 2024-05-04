using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Python.Runtime;
using System.Diagnostics;
using System.Windows.Forms;
using Python.Runtime;

namespace Crime_App
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PythonEngine.Initialize();
            Runtime.PythonDLL = @"env\Python.Runtime.dll";
            dynamic pythonModule = Py.Import("main.py");

            pythonModule.run_detection();
          
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void RunPythonScriptButton_Click(object sender, EventArgs e)
        {
            // Path to the Python interpreter
            string pythonPath = "python.exe";

            // Path to your Python script
            string scriptPath = "C:\\Users\\Public\\gun detection project\\main.py";

            // Create a process to run the Python script
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = pythonPath,
                Arguments = scriptPath,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true
            };

            // Start the process
            using (Process process = Process.Start(startInfo))
            {
                // Read the output (if needed)
                string output = process.StandardOutput.ReadToEnd();

                // Wait for the process to exit
                process.WaitForExit();

                // Display output (if needed)
                MessageBox.Show(output);
            }
        }
    
}
}
