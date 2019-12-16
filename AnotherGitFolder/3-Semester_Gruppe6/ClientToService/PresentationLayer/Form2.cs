using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientToService.ControlLayer;

namespace ClientToService
{
   
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            ControlAuction aus = new ControlAuction();
            dataGridView1.DataSource = aus.ViewAuction();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(TxtBoxId.Text))
            {
                
                MessageBox.Show("Indtast Byd Pris!!!");
                TxtBoxId.Select();
            }

            else
            {

                string IdD = TxtBoxId.Text;

                int Id = Int32.Parse(IdD);

                ControlAuction aus = new ControlAuction();

                aus.DeleteAuction(Id);
                TxtBoxId.Text = String.Empty;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ControlAuction aus = new ControlAuction();
            dataGridView1.DataSource = aus.ViewAuction();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void auctionModelBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void BtnCreateAuction_Click(object sender, EventArgs e)
        {
            string Title = TxtBoxTitle.Text;
            string Description = TxtBoxDescription.Text;
            string Category = comboBox1.Text;
            string CurrentPriceD = TxtBoxCurrentPrice.Text;
            string MaxPriceD = TxtBoxMaxPrice.Text;
            string BidD = TxtByd.Text;
            string EndDateD = dateTimePicker1.Text;
            string StatusD = TxtBoxStatus.Text;
            string IdD = textBoxId2.Text;
            

            if (string.IsNullOrWhiteSpace(TxtByd.Text))
            {
                MessageBox.Show("Indtast Byd Pris!!!");
                TxtByd.Select();
            }

            else if (string.IsNullOrWhiteSpace(TxtBoxStatus.Text))
            {
                MessageBox.Show("Indtast Status!!!");
                TxtBoxStatus.Select();
            }


            else if (string.IsNullOrWhiteSpace(TxtBoxTitle.Text))
            {
                MessageBox.Show("Indtast titel!!!");
                TxtBoxTitle.Select();
            }

            else if (string.IsNullOrWhiteSpace(TxtBoxDescription.Text))
            {
                MessageBox.Show("Indtast beskrivelse!!!");
                TxtBoxDescription.Select();
            }

            else if (string.IsNullOrWhiteSpace(comboBox1.Text))
            {
                MessageBox.Show("Indtast katagori!!!");
                comboBox1.Select();
            }

            else if (string.IsNullOrWhiteSpace(TxtBoxCurrentPrice.Text))
            {
                MessageBox.Show("Indtast start pris!!!");
                TxtBoxCurrentPrice.Select();
            }

            else if (string.IsNullOrWhiteSpace(TxtBoxMaxPrice.Text))
            {
                MessageBox.Show("Indtast køb nu pris!!!");
                TxtBoxMaxPrice.Select();
            }

            else if (string.IsNullOrWhiteSpace(dateTimePicker1.Text))
            {
                MessageBox.Show("Indtast slut dato!!!");
                dateTimePicker1.Select();
            }

            else if (string.IsNullOrWhiteSpace(textBoxId2.Text))
            {
                MessageBox.Show("Indtast et id!!!");
                textBoxId2.Select();
            }

            else
            {

                decimal Bid = decimal.Parse(BidD);
                decimal CurrentPrice = decimal.Parse(CurrentPriceD);
                decimal MaxPrice = decimal.Parse(MaxPriceD);

                int Status = int.Parse(StatusD);
                int Id = int.Parse(IdD);

                DateTime EndDate = DateTime.Parse(EndDateD);


                ControlAuction aus = new ControlAuction();

                aus.EditAuction(Id, Bid, Status, CurrentPrice, MaxPrice, EndDate, Title, Description, Category);

                textBoxId2.Text = String.Empty;
                TxtBoxTitle.Text = String.Empty;
                TxtBoxDescription.Text = String.Empty;
                TxtBoxCurrentPrice.Text = String.Empty;
                TxtBoxStatus.Text = String.Empty;
                TxtBoxMaxPrice.Text = String.Empty;
                TxtByd.Text = String.Empty;
                dateTimePicker1.Text = String.Empty;
                comboBox1.Text = String.Empty;
            }
        }
        

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ButtonClose(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
