using System.Data;
using System.Data.SqlClient;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        string constring = @"Data Source=MOHAMMEDBELLO;Initial Catalog=StudentManagement;Integrated Security=True";
        public int StudentID { get; set; }
        public Form1()
        {
            InitializeComponent();
            BindGrid();
        }
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM StudentDataTable", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataSet ds = new DataSet())
                        {
                            sda.Fill(ds);
                            dataGridView1.DataSource = ds.Tables[0];
                        }
                    }
                }
            }
        }
        private void update_Button(object sender, EventArgs e)
        {
            if (StudentID > 0 && isValid())
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("Update StudentDataTable set Firstname=@Firstname,Lastname=@Lastname,Phone=@Phone, Email=@Email, Class=@Class,DateOfBirth=@DateOfBirth where ID=@ID", con);
                cmd.Parameters.AddWithValue("@Firstname", studentFirstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", studentLastname.Text);
                cmd.Parameters.AddWithValue("@Phone", studentPhone.Text);
                cmd.Parameters.AddWithValue("@Email", studentEmail.Text);
                cmd.Parameters.AddWithValue("@Class", studentClass.Text);
                cmd.Parameters.AddWithValue("ID", StudentID);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(studentDateOfBirth.Text));
                cmd.ExecuteNonQuery();
                con.Close();
                BindGrid();
                MessageBox.Show("Student Registration is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Please select a student to update informations", "Select?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearTextBox()
        {
            studentFirstname.Text =
            studentLastname.Text =
            studentPhone.Text =
            studentEmail.Text =
            studentClass.Text =
            studentDateOfBirth.Text = "";
            studentFirstname.Focus();
        }
        private void register_Button(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into StudentDataTable values (@Firstname,@Lastname,@Phone,@Email,@Class,@DateOfBirth)", con);
                cmd.Parameters.AddWithValue("@Firstname", studentFirstname.Text);
                cmd.Parameters.AddWithValue("@Lastname", studentLastname.Text);
                cmd.Parameters.AddWithValue("@Phone", studentPhone.Text);
                cmd.Parameters.AddWithValue("@Email", studentEmail.Text);
                cmd.Parameters.AddWithValue("@Class", studentClass.Text);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateTime.Parse(studentDateOfBirth.Text));

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Student Registration is successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BindGrid();
                clearTextBox();
            }
        }

        private bool isValid()
        {
            if (studentFirstname.Text == string.Empty ||
                studentLastname.Text == string.Empty ||
                studentPhone.Text == string.Empty ||
                studentEmail.Text == string.Empty ||
                studentClass.Text == string.Empty ||
                studentDateOfBirth.Text == string.Empty
                )

            {
                MessageBox.Show("All details are required", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                SqlConnection con = new SqlConnection(constring);
                con.Open();


                SqlCommand cmd = new SqlCommand("Delete from StudentDataTable where Email=@KEYWORD", con);


                cmd.Parameters.AddWithValue("KEYWORD", studentEmail.Text);
                cmd.ExecuteNonQuery();
                BindGrid();
                con.Close();
                MessageBox.Show("Successfully Deleted");
                clearTextBox();
            }
            else
            {
                MessageBox.Show("Complete student data to Delete");
            }
        }
        private void clearButton_Click(object sender, EventArgs e)
        {
            clearTextBox();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from StudentDataTable where Email=@Email and Phone=@Phone", con);
            cmd.Parameters.AddWithValue("Email", searchEmail.Text);
            cmd.Parameters.AddWithValue("Phone", searchPhone.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            if (dt.Rows.Count == 0)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("No result");

            }
            else if (dt.Rows.Count != 0)
            {
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Search Successfull");

            }
        }
        private void reloadButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void deleteFromSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete from StudentDataTable where Email=@Email and Phone=@Phone", con);
            cmd.Parameters.AddWithValue("Email", searchEmail.Text);
            cmd.Parameters.AddWithValue("Phone", searchPhone.Text);
            con.Close();
            cmd.ExecuteNonQuery();
            BindGrid();
        }
        private void sortMethod(string studentClass)
        {
            SqlConnection con = new SqlConnection(constring);
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from StudentDataTable where Class=@Class", con);
            cmd.Parameters.AddWithValue("Class", studentClass);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void sortByClass1_Click(object sender, EventArgs e)
        {
            sortMethod("1");
        }
        private void sortByClass2_Click(object sender, EventArgs e)
        {
            sortMethod("2");
        }
        private void sortByclass3_Click(object sender, EventArgs e)
        {
            sortMethod("3");
        }
        private void sortByClass4_Click(object sender, EventArgs e)
        {
            sortMethod("4");
        }
        private void sortByclass5_Click(object sender, EventArgs e)
        {
            sortMethod("5");
        }
        private void sortByclass6_Click(object sender, EventArgs e)
        {
            sortMethod("6");
        }

        private void randomByClass_Click(object sender, EventArgs e)
        {
            sortMethod(randomSearch.Text);
        }

        private void loadStudentData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select * from StudentDataTable where Email = '" + randomSearch.Text + " '; ", con);

            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    string Firstname = myReader.GetString("FirstName");
                    string Lastname = myReader.GetString("Lastname");
                    string Phone = myReader.GetString("Phone");
                    string Email = myReader.GetString("Email");
                    string Class = myReader.GetString("Class");
                    DateTime DateOfBirth = myReader.GetDateTime("DateOfBirth");

                    studentFirstname.Text = Firstname;
                    studentLastname.Text = Lastname;
                    studentPhone.Text = Phone;
                    studentEmail.Text = Email;
                    studentClass.Text = Class;
                    studentDateOfBirth.Text = DateOfBirth.ToString();
                }
                else
                {
                    MessageBox.Show("No Data Available");
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                StudentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                studentFirstname.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                studentLastname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                studentPhone.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                studentEmail.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                studentClass.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                studentDateOfBirth.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            }
            catch (Exception error)
            {
                var err = error.Message;
                MessageBox.Show($"No Data available\n Reason: {err}");
            }

        }

        private void loadData_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Select * from StudentDataTable where Email = '" + searchEmail.Text + " ' and Phone = '" + searchPhone.Text + "'; ", con);

            SqlDataReader myReader;
            try
            {
                con.Open();
                myReader = cmd.ExecuteReader();
                if (myReader.Read())
                {
                    string Firstname = myReader.GetString("FirstName");
                    string Lastname = myReader.GetString("Lastname");
                    string Phone = myReader.GetString("Phone");
                    string Email = myReader.GetString("Email");
                    string Class = myReader.GetString("Class");
                    DateTime DateOfBirth = myReader.GetDateTime("DateOfBirth");

                    studentFirstname.Text = Firstname;
                    studentLastname.Text = Lastname;
                    studentPhone.Text = Phone;
                    studentEmail.Text = Email;
                    studentClass.Text = Class;
                    studentDateOfBirth.Text = DateOfBirth.ToString();
                    MessageBox.Show("Search Complete");
                }
                else
                {
                    MessageBox.Show("No Data Available");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}