using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Project_Ivalice
{
    public partial class Main_Form : Form
    {
        static List<string> Trace_messages_list = new List<string>();
        static bool processing_mesage = false;
        public static Thread Resources_thread = new Thread(() => Resources.Resources_Build());
        //public static Point Matrix_Points = new Point[][];
                                              // x    y
        static Point[,] Board_Points = new Point[10, 8];

        public Main_Form()
        {
            InitializeComponent();
            Trace_Timer.Enabled = true;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            Notify("Initializing Threads");
            Resources_thread.Start();
            Notify("Getting Coords");
            int x = 0, y = 0;
            foreach (Control box in this.Controls)
            {
                if (box is PictureBox)
                {
                    char[] name = box.Name.ToCharArray();
                    
                    if (name.Length > 7 && Char.IsDigit(name[5]) && Char.IsDigit(name[7]))
                    {
                        x = int.Parse(name[5].ToString());
                        y = int.Parse(name[7].ToString());
                        Board_Points[x, y] = Get_Pctbx_Point((PictureBox)box);

                    }
                }
            }

            Creating_Characters();
        }

        private Point Get_Pctbx_Point(PictureBox box)
        {
            Point retval = new Point(0, 0);

            retval.X = box.Location.X + 15;
            retval.Y = box.Location.Y + 15;

            return retval;
        }

        private async void Creating_Characters()
        {
            Notify("Adding Chars");
            while(!Resources.Mariel_Char.Created)
            {
                await Task.Delay(10);
            }
            Char1.Image = Resources.Mariel_Char.Walk_right;
            Char1.Size = new Size(65, 64);
            Char1.Location = Board_Points[0, 0];
            Char1.Visible = true;
            Char1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void Trace_Timer_Tick(object sender, EventArgs e)
        {
            if (Trace_messages_list.Count > 0 && !processing_mesage)
            {
                processing_mesage = true;
                Trace(Trace_messages_list[0]);
                Trace_messages_list.RemoveAt(0);
                processing_mesage = false;
            }
        }

        public void Trace(string mensage)
        {
            Log_Message_rtxtbx.AppendText(mensage + "\n");
            Log_Message_rtxtbx.SelectionStart = Log_Message_rtxtbx.Text.Length;
            Log_Message_rtxtbx.ScrollToCaret();
        }

        public static void Notify(string trace)
        {
            Trace_messages_list.Add(trace);
        }
    }
}
