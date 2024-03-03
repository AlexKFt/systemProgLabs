using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace systemProgLab1
{
    public partial class Form1 : Form
    {
        Process childProcess = null;
        EventWaitHandle eventStart = new EventWaitHandle(false, EventResetMode.AutoReset, "StartEvent");
        EventWaitHandle eventConfirm = new EventWaitHandle(false, EventResetMode.AutoReset, "ConfirmEvent");
        EventWaitHandle eventClose = new EventWaitHandle(false, EventResetMode.AutoReset, "CloseProcKushch");
        EventWaitHandle eventExit = new EventWaitHandle(false, EventResetMode.AutoReset, "ExitProcKushch");

        int threadsCounter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {  
            if (childProcess==null || childProcess.HasExited)
            {
                threadsBox.Items.Clear();
                childProcess = Process.Start("ConsoleApplication.exe");
                eventConfirm.WaitOne();
                updateList("main");
                updateList("all threads");
                threadsCounter++;

            }
            else
            {
                int n = 0;
                try
                {
                    n = Int32.Parse(thredsPerCliccEdit.Text); 
                }
                catch 
                { }
 
                for (int i = 0; i < n; ++i)
                {
                    eventStart.Set();
                    eventConfirm.WaitOne();
                    updateList((threadsCounter++).ToString());
                }         
            }

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (childProcess==null || childProcess.HasExited)
            {
                threadsBox.Items.Clear();
            }
            else
            {
                eventClose.Set();
                eventConfirm.WaitOne();

                threadsBox.Items.RemoveAt(threadsCounter--);

                if (threadsBox.Items.Count == 1)
                {
                    threadsBox.Items.Clear();
                    threadsCounter = 0;
                }
                    
            }
        }

        private void updateList(string name)
        { 
            threadsBox.Items.Add(name);
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            int index = threadsBox.SelectedIndex;
            
            if (index == 1)
            {

            }
            else
            { 

            }
        }
    }
}
