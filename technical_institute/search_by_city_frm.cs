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
    public partial class search_by_city_frm : Form
    {
        public search_by_city_frm()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_by_city_frm_Load(object sender, EventArgs e)
        {
            technical_master master_obj = new technical_master();
//            master_obj.load_acedamic_year(year_combo);
            master_obj.load_trade_name(trade_combo);
            gender_combo.Enabled = false;
            religion_combo.Enabled = false;
            search_result_txt.Enabled = false;
            search_result_txt.ReadOnly = true;


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            technical_master obj = new technical_master();
            obj.search_by_city_function(city_txt, trade_combo, year_combo, dataGridView1);
            search_result_txt.Text = ""+city_txt.Text.ToUpper();
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                gender_combo.Enabled = true;
            }
            else
                gender_combo.Enabled = false;
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                religion_combo.Enabled = true;
            }
            else
                religion_combo.Enabled = false;
        }
        private void gender_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            technical_master obj = new technical_master();
            obj.search_student_by_gender(city_txt, gender_combo, dataGridView1,trade_combo);
        }
    }
}
