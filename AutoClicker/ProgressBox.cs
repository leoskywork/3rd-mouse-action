using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoClicker
{
    public partial class ProgressBox : Form
    {
        public event EventHandler ButtonAction;
        public ProgressBox()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            //this.DisableButtonShortTime(this.buttonCancel);
            this.ButtonAction?.Invoke(this, EventArgs.Empty);
            this.buttonCancel.Enabled = false;
        }

        public void ShowMessage(string message)
        {
            this.RunOnMainAsync(() =>
            {
                this.labelMessage.Text = message;
            });
        }

        //public void EnableAction(string text)
        //{
        //    this.buttonCancel.Text = text;
        //    this.buttonCancel.Enabled = true;
        //}

        public void ShowDefault(Control parent)
        {
            if (parent == null)
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
            else
            {
                this.StartPosition = FormStartPosition.Manual;
                this.Location = new Point(parent.Location.X + 100, parent.Location.Y + 100);
            }

            this.Show();
        }
    }
}
