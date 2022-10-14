using Core.Controllers;
using System;
using System.Windows.Forms;

namespace XMLtoExcel.Forms
{
    public partial class LoggerForm : Form
    {
        public LoggerForm()
        {
            InitializeComponent();
        }

        private void LoggerForm_Load(object sender, EventArgs e)
        {
            memoLogger.Text = LogerController.GetMessage();
        }
    }
}
