using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace technical_institute
{
    public partial class recipt1 : Form
    {
       // private TextBox student_first_name_txt;
        public recipt1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            technical_master master_obj = new technical_master();
            master_obj.search_student_for_receipt(student_name_txt,trade_name_combo,dataGridView1);
       
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recipt1_Load(object sender, EventArgs e)
        {
            technical_master obj = new technical_master();
            obj.load_trade_name(trade_name_combo);
          //obj.load_acedamic_year(ComboBox2);
            obj.load_trade_name(trade_name_combo);
            for (int i = 1980; i <= 2100; i++)
            {
                year_combo.Items.Add("" + i);
            }


        }
    }
}
