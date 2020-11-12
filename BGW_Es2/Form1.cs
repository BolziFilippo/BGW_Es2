using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BGW_Es2
{
    public partial class frm_Main : Form
    {
        BackgroundWorker bgw2, bgw3;
        public frm_Main()
        {
            InitializeComponent();
        }

        private void btn_A2_Click(object sender, EventArgs e)
        {
            bgw3 = new BackgroundWorker();
            bgw3.WorkerReportsProgress = true;
            bgw3.WorkerSupportsCancellation = true;
            bgw3.DoWork += bgw1_DoWork;
            bgw3.ProgressChanged += bgw1_ProgressChanged;
            bgw3.RunWorkerCompleted += bgw1_RunWorkerCompleted;

            bgw2 = new BackgroundWorker();
            bgw2.WorkerReportsProgress = true;
            bgw2.WorkerSupportsCancellation = true;
            bgw2.DoWork += bgw1_DoWork;
            bgw2.ProgressChanged += bgw1_ProgressChanged;
            bgw2.RunWorkerCompleted += bgw1_RunWorkerCompleted;

            bgw3.RunWorkerAsync(txt_box1);
            bgw2.RunWorkerAsync(txt_box2);





        }

        private void bgw1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bgw = sender as BackgroundWorker;
            TextBox tb = e.Argument as TextBox;
            for (int i = 0; i < 10 ; i++)
            {
                Thread.Sleep(100);
                bgw.ReportProgress(i, tb);
                if(bgw.CancellationPending)
                {
                    e.Result = (false, tb);
                    return;
                }

            }
            e.Result = (true, tb);

        }

        private void bgw1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            TextBox tb = e.UserState as TextBox;
            tb.Text = e.ProgressPercentage + Environment.NewLine + tb.Text;
        }

        private void btn_S2_Click(object sender, EventArgs e)
        {
            bgw3.CancelAsync();
            bgw2.CancelAsync();

        }

        private void bgw1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            var (completato, tb) = (ValueTuple<bool, TextBox>)e.Result;
            tb.Text = completato ? "concluso" + Environment.NewLine + tb.Text:
            "Cancellato" + Environment.NewLine + tb.Text;
        }

        

        List<BackgroundWorker> bgw_list = new List<BackgroundWorker>();

        private void btn_S100_Click(object sender, EventArgs e)
        {
            foreach(var bgw in bgw_list)
            {
                bgw.CancelAsync();
            }
        }
        // 
        private void txt_box1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_A100_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 100; i++)
            {
                BackgroundWorker bgw1 = new BackgroundWorker();
                bgw1.WorkerReportsProgress = true;
                bgw1.WorkerSupportsCancellation = true;
                bgw1.DoWork += bgw1_DoWork;
                bgw1.ProgressChanged += bgw1_ProgressChanged;
                bgw1.RunWorkerCompleted += bgw1_RunWorkerCompleted;
                bgw_list.Add(bgw1);

            }
            foreach(var bgw in bgw_list)
            {
                bgw.RunWorkerAsync(txt_box2);
            }
        }
    }
}
