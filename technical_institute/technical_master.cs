using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace technical_institute
{
    class technical_master
    {
        SqlConnectionStringBuilder builder;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader reader;
        public void db_connect()
        {
            try
            {
                builder = new SqlConnectionStringBuilder();
                builder.DataSource = "(local)";
                builder.InitialCatalog = "technical_institute";
                builder.UserID = "sa";
                builder.Password = "sa12345";
                con = new SqlConnection(builder.ConnectionString);
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void get_serial(TextBox txt_obj)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select max(trade_id) from trade_tbl";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while(reader.Read())
                    {
                    string trade_id_var = reader[0].ToString();
                    if (trade_id_var != "")
                        {
                            txt_obj.Text = "" + (Int64.Parse(trade_id_var) + 1);
                        }
                    else
                        {
                            txt_obj.Text = "1";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void save_trade_details(TextBox trade_id_txt,TextBox trade_name_txt,TextBox trade_duration_txt,TextBox trade_fees_txt)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into trade_tbl(trade_id,trade_name) values("+trade_id_txt.Text+",'"+trade_name_txt.Text+"')";
                int i = cmd.ExecuteNonQuery();
                if (i == 1)
                {

                    cmd.Dispose();
                    cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "insert into trade_info_tbl(trade_id,trade_duration,trade_fees) values("+trade_id_txt.Text+",'"+trade_duration_txt.Text+"','"+trade_fees_txt.Text+"')";
                    int j = cmd.ExecuteNonQuery();
                    if (j == 1)
                    {
                        MessageBox.Show("Trade Information Saved...");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void load_trade_name(ComboBox trade_name_combo)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select trade_name from trade_tbl";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        trade_name_combo.Items.Add("" + reader[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void save_student_enquiry_details(TextBox enquiry_id_txt,TextBox student_name_txt,TextBox address_txt,TextBox contact_txt,ComboBox trade_combo,ComboBox gender_combo,TextBox education_txt,DateTimePicker enquiry_date_picker,TextBox email_id_txt)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "insert into student_enquiry_tbl() values()";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
        public void get_enquiry_id(TextBox enquiry_txt)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select max(enquiry_id) from student_enquiry_tbl";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string enquiry_id_var = reader[0].ToString();
                        if (enquiry_id_var != "")
                        {
                            enquiry_txt.Text = "" + (Int64.Parse(enquiry_id_var) + 1);
                        }
                        else
                        {
                            enquiry_txt.Text = "1";
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }

        }
        public void get_academic_year_id(TextBox serial_txt)
        {
            try
            {
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select max(academic_year_id) from academic_year_tbl";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        string academic_id_var = reader[0].ToString();
                        if (academic_id_var != "")
                        {
                            serial_txt.Text = "" + (Int64.Parse(academic_id_var) + 1);
                        }
                        else
                        {
                            serial_txt.Text = "1";
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }
    public void save_student_enquiry(TextBox enquiry_id_txt, TextBox student_name_txt ,TextBox address_txt,TextBox contact_txt,ComboBox trade_combo,ComboBox gender_combo,TextBox education_txt,DateTimePicker enquiry_date_picker,TextBox email_id_txt,TextBox city_txt)
    {
        db_connect();
        cmd=new SqlCommand();
        cmd.Connection=con;
        long date = enquiry_date_picker.Value.Date.Day;
        long month = enquiry_date_picker.Value.Month; 
        long year= enquiry_date_picker.Value.Date.Year;
        cmd.CommandText = "insert into student_enquiry_tbl (enquiry_id,student_name,address,contact_no,trade,gender,education,date_of_enquiry,email_id,date,month,year,city) values (" + enquiry_id_txt.Text + ",'" + student_name_txt.Text + "','" + address_txt.Text + "','" + contact_txt.Text + "','" + trade_combo.Text + "','" + gender_combo.Text + "','" + education_txt.Text + "','" + enquiry_date_picker.Text + "','" + email_id_txt.Text + "','" + date+"','" +month +"','" +year +"','"+city_txt.Text+"')";
        cmd.ExecuteNonQuery();
        MessageBox.Show("Student Record Saved...");
        student_name_txt.Text = "";
        address_txt.Text = "";
        contact_txt.Text = "";
        trade_combo.Text = "";
        gender_combo.Text = "";
        education_txt.Text = "";
        enquiry_id_txt.Text = "";
        enquiry_date_picker.Text = "";
        email_id_txt.Text="";
        city_txt.Text = "";
            }
    public void add_academic_year(ComboBox start_year_combo,ComboBox end_year_combo,DataGridView grid_obj,TextBox academic_id_txt)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            string academic_year=start_year_combo.Text+"-"+end_year_combo.Text;
            cmd.CommandText = "insert into academic_year_tbl(academic_year) values('" + academic_year + "')";
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Academic Year Added");

                string[] row = new string[]
                {
                    academic_id_txt.Text,academic_year
                };
                grid_obj.Rows.Add(row);
                academic_id_txt.Text = "";
                start_year_combo.SelectedText = "";
                end_year_combo.SelectedText = "";
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }
    public void load_academic_year(DataGridView grid_obj)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select * from academic_year_tbl";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] row = new string[]
                    {
                        reader[0].ToString(),reader[1].ToString()
                    };
                    grid_obj.Rows.Add(row);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }

    }
    public void load_acedamic_year(ComboBox ComboBox2)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select academic_year from academic_year_tbl";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ComboBox2.Items.Add("" + reader[0].ToString());
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }
    public void create_user(TextBox user_name_txt, TextBox password_txt, TextBox conf_password_txt, ComboBox sec_ques_combo, TextBox sec_ans_txt, TextBox contact_txt)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into user_tbl (use_name,password,security_question,security_answer,contact_number) values ('"+ user_name_txt.Text + "','" + password_txt.Text + "','" + sec_ques_combo.Text + "','" + sec_ans_txt.Text + "','" + contact_txt.Text + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Record Inserted Successfully.............");
            
        }
        catch (Exception ex)
        {
            MessageBox.Show("" + ex.Message);
        }

    }
    public void search_student_enquiry(ComboBox trade_combo,ComboBox by_year_combo,ComboBox by_month_combo,ComboBox by_month_year_combo,DateTimePicker by_date_picker,RadioButton btn1,RadioButton btn2,RadioButton btn3,DataGridView grid_obj,TextBox student_name_txt)
    {
        try
        {
            //string trade_name;
            //string by_year,by_month,by_month_year;
            //string by_date;
            //if (!String.IsNullOrEmpty(trade_combo.Text))
            //{
            //    trade_name = trade_combo.Text;
            //}
            //if (btn1.Checked == true)
            //{
            //    if (!String.IsNullOrEmpty(by_year_combo.Text))
            //    {
            //        search_by_year_function(trade_combo, grid_obj,by_year_combo);
            //        by_year = by_year_combo.Text;
            //    }
            //}
            //if (btn2.Checked == true)
            //{
            //    if (!String.IsNullOrEmpty(by_month_combo.Text) && !String.IsNullOrEmpty(by_month_year_combo.Text))
            //    {
            //        by_month = by_month_combo.Text;
            //        by_month_year = by_month_year_combo.Text;
            //        search_by_month_and_year(trade_combo, grid_obj,by_month_combo,by_month_year_combo);
            //    }
            //}
            //if (btn3.Checked == true)
            //{
            //    if (!String.IsNullOrEmpty(by_date_picker.Text))
            //    {
            //        by_date = by_date_picker.Text;
            //        search_by_date_function(trade_combo,grid_obj,by_date_picker);
            //    }
            //}
            int counter = 0;
            grid_obj.Rows.Clear();
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select student_name,address,contact_no,trade,education,date_of_enquiry from student_enquiry_tbl where student_name like '%"+student_name_txt.Text+"%' and trade like '%"+trade_combo.Text+"%'";
            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                grid_obj.Rows.Clear();
                while (reader.Read())
                {
                    counter = counter + 1;
                    string[] row = new string[]
                    {
                        ""+counter,reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),reader[5].ToString()
                    };
                    grid_obj.Rows.Add(row);

                }

            }
            else
            {
                grid_obj.Rows.Clear();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }
    public void search_by_date_function(ComboBox trade_combo,DataGridView grid_obj,DateTimePicker date_picker)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select student_name,address,contact_no,trade,education,date_of_enquiry from student_enquiry_tbl where trade like '" + trade_combo.Text + "' and date_of_enquiry like'"+date_picker.Text + "'";
            reader = cmd.ExecuteReader();
            int counter = 0;
            if (reader.HasRows)
            {
                grid_obj.Rows.Clear();
                while (reader.Read())
                {
                    counter = counter + 1;
                    string[] row = new string[]
                    {
                        ""+counter,reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),reader[5].ToString()
                    };

                    grid_obj.Rows.Add(row);
                }
            }
            else
            {
                grid_obj.Rows.Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void search_by_month_and_year(ComboBox trade_combo, DataGridView grid_obj, ComboBox month_combo, ComboBox year_combo,TextBox student_name_txt)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select student_name,address,contact_no,trade,education,date_of_enquiry from student_enquiry_tbl where trade like '%" + trade_combo.Text + "%' and year ='" + year_combo.Text + "' and student_name like '%" + student_name_txt.Text + "%' and month like '%"+month_combo.Text+"%'";
            reader = cmd.ExecuteReader();
            int counter = 0;
            if (reader.HasRows)
            {
                grid_obj.Rows.Clear();
                while (reader.Read())
                {
                    counter = counter + 1;
                    string[] row = new string[]
                    {
                        ""+counter,reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),reader[5].ToString()
                    };
                    grid_obj.Rows.Add(row);
                }

            }
            else
            {
                grid_obj.Rows.Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }
    public void load_trade_fees(ComboBox trade_combo, TextBox fees_txt)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select trade_info.trade_fees from trade_info_tbl as trade_info inner join trade_tbl as trade on trade_info.trade_id= trade.trade_id where trade.trade_name like '%"+trade_combo.Text+"%'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    fees_txt.Text = "" + reader[0].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void search_by_year_function(ComboBox trade_combo,DataGridView grid_obj,ComboBox year_combo,TextBox student_name_txt)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select student_name,address,contact_no,trade,education,date_of_enquiry from student_enquiry_tbl where trade like '%"+trade_combo.Text+"%' and year ='"+year_combo.Text+"' and student_name like '%"+student_name_txt.Text+"%'";
            reader = cmd.ExecuteReader();
            int counter = 0;
            if (reader.HasRows)
            {
                grid_obj.Rows.Clear();
                while (reader.Read())
                {
                    counter = counter + 1;
                    string[] row = new string[]
                    {
                        ""+counter,reader[0].ToString(),reader[1].ToString(),reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),reader[5].ToString()
                    };
                    grid_obj.Rows.Add(row);
                }

            }
            else
            {
                grid_obj.Rows.Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }
    public void user_login(TextBox username_txt,TextBox password_txt)
    {
        try
        {
            string is_true = "";
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select use_name,password from user_tbl where use_name like '"+username_txt.Text+"' and password like '"+password_txt.Text+"'" ;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                MessageBox.Show("Username =" + reader[0].ToString() + " and password = " + reader[1].ToString());
                is_true = "true";
                if (is_true == "true")
                {
                    login_frm.ActiveForm.Hide();
                    MessageBox.Show("Login Success");
                    main_form obj = new main_form();
                    obj.Show();
                }
                else
                {
                    username_txt.Text = "";
                    password_txt.Text = "";
                    is_true = "";
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void save_student_register_info(TextBox student_id_txt, TextBox register_no_txt, TextBox student_name_txt, TextBox father_name_txt, TextBox last_name_txt, TextBox father_full_name_txt, TextBox mother_name_txt, DateTimePicker birth_date_picker, TextBox age_txt, ComboBox gender_combo, ComboBox category_combo, ComboBox religion_combo, TextBox caste_txt, TextBox sub_caste_txt, ComboBox marrital_status_combo, DateTimePicker admission_date_picker, ComboBox father_occupation_combo, TextBox aadhar_id_txt, TextBox contact_no_txt, TextBox alternate_no_txt, TextBox email_id_txt, ComboBox trade_combo, CheckBox local_check_box, CheckBox perm_check_box, TextBox local_address_txt, TextBox local_city_txt, TextBox local_taluka_txt, TextBox local_district_txt, TextBox local_pin_code_txt, TextBox local_state_txt, TextBox permanent_address_txt, TextBox permanent_city_txt, TextBox permanent_taluka_txt, TextBox permanent_district_txt, TextBox permanent_pin_code_txt, TextBox permanent_state_txt, TextBox nationality_txt)
     {
        try
        {
            
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into student_tbl(student_id,register_no,student_name,father_name,last_name,father_full_name,mother_name,date_of_birth,age,gender,category,religion,caste,sub_cast,marital_status,admission_date,father_occupation,aadhar_id,contact_no,alternate_no,email_id,trade_name) values(" + student_id_txt.Text + "," + register_no_txt.Text + ",'" + student_name_txt.Text + "','" + father_name_txt.Text + "','" + last_name_txt.Text + "','" + father_full_name_txt.Text + "','" + mother_name_txt.Text + "','" + birth_date_picker.Text + "','" + age_txt.Text + "','" + gender_combo.Text + "','" + category_combo.Text + "','" + religion_combo.Text + "','" + caste_txt.Text + "','" + sub_caste_txt.Text + "','" + marrital_status_combo.Text + "','" + admission_date_picker.Text + "','" + father_occupation_combo.Text + "','" + aadhar_id_txt.Text+ "','" + contact_no_txt.Text + "','"+alternate_no_txt.Text+"','"+email_id_txt.Text+"','"+trade_combo.Text+"')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "insert into address_tbl (student_id,local_address,local_city,local_taluka,local_district,local_state,local_pin,permanent_address,permanent_city,permanent_taluka,permanent_district,permanent_state,permanent_pin,nationality) values ("+student_id_txt.Text+",'"+local_address_txt.Text+"','"+local_city_txt.Text+"','"+local_taluka_txt.Text+"','"+local_district_txt.Text+"','"+local_pin_code_txt.Text+"','"+local_state_txt.Text+"','"+permanent_address_txt.Text+"','"+permanent_city_txt.Text+"','"+permanent_taluka_txt.Text+"','"+permanent_district_txt.Text+"','"+permanent_pin_code_txt.Text+"','"+permanent_state_txt.Text+"','"+nationality_txt.Text+"')";
            int result = cmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("address record saved");
            } 
         }
        catch(Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void search_by_student_name_function(TextBox student_first_name, TextBox last_name, ComboBox trade_name, ComboBox year_combo, DataGridView grid_obj)
    {
        try
        {
            grid_obj.Rows.Clear();
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select stud.register_no,stud.student_name,stud.father_name,stud.last_name,stud.contact_no,stud.admission_date,stud.trade_name,address.local_address from student_tbl as stud inner join address_tbl as address on stud.student_id = address.student_id where stud.student_name like '%" + student_first_name.Text + "%' and  stud.last_name like '%" + last_name.Text + "%' and stud.trade_name like '%"+trade_name.Text+"%'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    string[] row = new string[]
                    {
                        reader[0].ToString(),reader[1].ToString()+" "+reader[2].ToString()+" "+reader[3].ToString(),""+reader[7].ToString(),reader[4].ToString(),""+reader[6].ToString(),"",reader[5].ToString()
                    };
                    grid_obj.Rows.Add(row);
                }
            }
            else
            {
                grid_obj.Rows.Clear();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void search_student_by_gender(TextBox city_txt, ComboBox gender_combo, DataGridView grid_obj,ComboBox trade_combo)
    {
        try
        {
            grid_obj.Rows.Clear();
            string student_id = null;

            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select stud.student_name,stud.father_name,stud.last_name,add_tbl.local_address,add_tbl.local_city,stud.contact_no,stud.trade_name,stud.gender,stud.admission_date from student_tbl as stud inner join address_tbl as add_tbl  on stud.student_id = add_tbl.student_id where add_tbl.local_city like '%" + city_txt.Text + "%' and gender like '" + gender_combo.Text + "%' and stud.trade_name like '%"+trade_combo.Text+"%'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    student_id = reader[0].ToString();
                    string[] row = new string[]
                    {
                       reader[0].ToString()+" "+reader[1].ToString()+" "+reader[2].ToString(),""+reader[3].ToString(),reader[4].ToString(),reader[5].ToString(),reader[6].ToString(),""+reader[7].ToString(),reader[8].ToString()
                    };
                    grid_obj.Rows.Add(row);
                }
            }
            else
            {
                grid_obj.Rows.Clear();
            }

        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void search_by_city_function(TextBox city_txt, ComboBox trade_combo, ComboBox year_combo, DataGridView grid_obj)
    {
        try
        {
            grid_obj.Rows.Clear();
            string student_id = null;
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select stud.student_name,stud.father_name,stud.last_name,add_tbl.local_address,add_tbl.local_city,stud.contact_no,stud.trade_name,stud.gender,stud.admission_date from student_tbl as stud inner join address_tbl as add_tbl  on stud.student_id = add_tbl.student_id where add_tbl.local_city like '%" + city_txt.Text + "%' and trade_name like '%" + trade_combo.Text + "%'";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    student_id = reader[0].ToString();
                    string[] row = new string[]
                    {
                       reader[0].ToString()+" "+reader[1].ToString()+" "+reader[2].ToString(),reader[3].ToString(),reader[4].ToString(),reader[5].ToString(),""+reader[6].ToString(),reader[7].ToString(),reader[8].ToString()
                    };
                    grid_obj.Rows.Add(row);
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void get_previous_register_no(TextBox register_no_txt)
    {
        int student_id = 0;
        string student_id_var = null;
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(student_id) from student_tbl";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    student_id_var = reader[0].ToString();
                    if (!String.IsNullOrEmpty(student_id_var))
                    {
                        student_id = int.Parse(student_id_var);
                    }
                }
            }
            reader.Close();
            cmd.CommandText = "select register_no from student_tbl where student_id=" + student_id;
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    register_no_txt.Text = "" + reader[0].ToString();
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error : " + ex.Message);
        }
    }

    public void get_student_id(TextBox serial_txt)
    {
        try
        {
            db_connect();
            cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select max(student_id) from student_tbl";
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while(reader.Read())
                {
                string trade_id_var = reader[0].ToString();
                if (trade_id_var != "")
                    {
                        serial_txt.Text = "" + (Int64.Parse(trade_id_var) + 1);
                    }
                else
                    {
                        serial_txt.Text = "1";
                    }

                }
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            }
        }

        public void search_student_for_receipt(TextBox student_name_txt,ComboBox trade_combo, DataGridView dataGridView1)
        {
            try
            {
                dataGridView1.Rows.Clear();
                db_connect();
                cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "select student_name trade_name from student_tbl  where student_name like '%"+student_name_txt.Text+"' and trade_name like '%" + trade_combo.Text + "%'";
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                      //  student_id = reader[0].ToString();
                        string[] row = new string[]
                    {
                       reader[2].ToString()+" "+reader[3].ToString()
                    };
                        dataGridView1.Rows.Add(row);
                    }
                }
                else
                {
                    dataGridView1.Rows.Clear();
                }

           
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :"+ ex.Message);
            }
        }

    }
    }