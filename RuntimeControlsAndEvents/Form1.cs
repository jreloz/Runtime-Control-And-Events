using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RuntimeControlsAndEvents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            ControlLayoutPanel.VerticalScroll.Value = ControlLayoutPanel.VerticalScroll.Maximum;
        }





        int cnt = 1;
        ArrayList Values = new ArrayList();




        private void AddControl_Click(object sender, EventArgs e)
        {
            Panel PnlControl = new Panel();
            TextBox TxtDescription = new TextBox();
            Button BtnRemove = new Button();

            PnlControl.Width = 251;
            PnlControl.Height = 89;
            PnlControl.BackColor = Color.Gray;
            PnlControl.Name = "PnlControl" + cnt;

            TxtDescription.Multiline = true;
            //TxtDescription.ScrollBars = ScrollBars.Vertical;
            TxtDescription.Width = 243;
            TxtDescription.Height = 58;
            TxtDescription.Font = new Font("Segoe UI",10,FontStyle.Regular);
            TxtDescription.BorderStyle = BorderStyle.FixedSingle;
            TxtDescription.Location = new Point(3, 3);
            TxtDescription.Name = "TxtDescription" + cnt;

            BtnRemove.Width = 30;
            BtnRemove.Height = 25;
            BtnRemove.Location = new Point(216, 62);
            BtnRemove.BackColor = Color.IndianRed;
            BtnRemove.ForeColor = Color.White;
            BtnRemove.FlatStyle = FlatStyle.Flat;
            new Font("Segoe UI", 10, FontStyle.Regular);
            BtnRemove.FlatAppearance.BorderSize = 0;
            BtnRemove.Name = "BtnRemove" + cnt;
            BtnRemove.Text = "X";
            BtnRemove.Click += new EventHandler(BtnRemove_ClickEventHandler);

            PnlControl.Controls.Add(TxtDescription);
            PnlControl.Controls.Add(BtnRemove);
            cnt += 1;

            ControlLayoutPanel.Controls.Add(PnlControl);
            ControlLayoutPanel.AutoScrollPosition = new Point(PnlControl.Left, PnlControl.Top);
        }



        public void BtnRemove_ClickEventHandler(object sender, EventArgs e)
        {
            var a = ((Button)sender).Parent.Name;

            foreach (Panel ItemPanel in ControlLayoutPanel.Controls)
            {
                if (ItemPanel.Name == a)
                    ControlLayoutPanel.Controls.Remove(ItemPanel);
                ControlLayoutPanel.AutoScrollPosition = new Point(ItemPanel.Left, ItemPanel.Top);
            }
        }



        private void GetValue_Click(object sender, EventArgs e)
        {
            foreach (var val in Values)
            {
                MessageBox.Show(val.ToString());
            }
        }



        private void SetValue_Click(object sender, EventArgs e)
        {
            foreach (Control pn in ControlLayoutPanel.Controls.OfType<Panel>())
            {
                foreach (var DescVal in pn.Controls.OfType<TextBox>())
                {
                    Values.Add(DescVal.Text);
                }
            }

            MessageBox.Show("Values are Set");
        }



        private void ControlCount_Click(object sender, EventArgs e)
        {
            var c = ControlLayoutPanel.Controls.OfType<Panel>();
            MessageBox.Show("Total Parent Panel(s): " + c.Count());
        }

        private void AddForm_Click(object sender, EventArgs e)
        {
            NewLabel();

            Form NewForm = new Form();
            NewForm.Controls.Add(nl);

            NewForm.ShowDialog();


        }

        public Label nl = new Label();

        private void NewLabel()
        {
            nl.Text = "This is a text";
            nl.Location = new Point(100,100);
            nl.ForeColor = Color.Black;
        }
    }
    
}
