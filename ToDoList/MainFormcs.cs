using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ToDoList
{
    public partial class MainFormcs : Form
    {
        string connString = "Data Source=FATHI\\SQLEXPRESS;Initial Catalog=TODOLIST;Integrated Security=True;Encrypt=False";
        private int loggedInUserId;
        private int selectedTaskId = 0;
        private string uploadedImagePath = null;
        public MainFormcs(int userId, string connconnectionString)
        {
            InitializeComponent();
            loggedInUserId = userId;
            LoadTasks();
            dgvTasks.CellValueChanged += dgvTasks_CellValueChanged; 
            dgvTasks.CellClick += dgvTasks_CellClick;

        }
        private void ResetForm()
        {
            selectedTaskId = 0;
            txtTitle.Text = "";
            txtDescription.Text = "";
            dtpDeadline.Value = DateTime.Now;
            uploadedImagePath = null;
            pictureBoxPreview.Image = null;
        }

        private void LoadTasks(string filter = "")
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT TaskId, Title, Description, Deadline, Status, ImagePath FROM Tasks WHERE UserId = @userId";

                if (filter == "Pending")
                    query += " AND Status = 'Pending'";
                else if (filter == "Completed")
                    query += " AND Status = 'Completed'";
                else if (filter == "Today")
                    query += " AND CAST(Deadline AS DATE) = CAST(GETDATE() AS DATE)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@userId", loggedInUserId);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable tasksTable = new DataTable();
                adapter.Fill(tasksTable);

                dgvTasks.DataSource = tasksTable;

                if (dgvTasks.Columns["StatusComboBox"] == null)
                {
                    DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
                    {
                        HeaderText = "Status",
                        DataPropertyName = "Status", 
                        DataSource = new string[] { "Pending", "Completed" }, 
                        Name = "StatusComboBox",
                        DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton
                    };

                    if (dgvTasks.Columns["Status"] != null)
                        dgvTasks.Columns.Remove("Status");

                    dgvTasks.Columns.Add(comboBoxColumn);
                }

                if (dgvTasks.Columns["ImagePath"] == null)
                {
                    DataGridViewTextBoxColumn imagePathColumn = new DataGridViewTextBoxColumn
                    {
                        HeaderText = "Image Path",
                        Name = "ImagePath",
                        Width = 250 
                    };
                    dgvTasks.Columns.Add(imagePathColumn);
                }

                foreach (DataGridViewRow row in dgvTasks.Rows)
                {
                    string imagePath = row.Cells["ImagePath"].Value as string;

                    if (imagePath != null)
                    {
                        row.Cells["ImagePath"].Value = imagePath;  
                    }
                    else
                    {
                        row.Cells["ImagePath"].Value = "No Image"; 
                    }
                }
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            ResetForm();
            selectedTaskId = 0;
        }

        private void saveTaskButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required!");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                if (selectedTaskId == 0) 
                {
                    string query = "INSERT INTO Tasks (UserId, Title, Description, Deadline, Status, ImagePath) VALUES (@userId, @title, @description, @deadline, @status, @imagePath)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userId", loggedInUserId);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@deadline", dtpDeadline.Value);
                    cmd.Parameters.AddWithValue("@status", "Pending");
                    cmd.Parameters.AddWithValue("@imagePath", uploadedImagePath ?? "");
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Task added successfully!");
                }
                else 
                {
                    string query = "UPDATE Tasks SET Title = @title, Description = @description, Deadline = @deadline, ImagePath = @imagePath WHERE TaskId = @taskId AND UserId = @userId";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@taskId", selectedTaskId);
                    cmd.Parameters.AddWithValue("@userId", loggedInUserId);
                    cmd.Parameters.AddWithValue("@title", txtTitle.Text);
                    cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                    cmd.Parameters.AddWithValue("@deadline", dtpDeadline.Value);
                    cmd.Parameters.AddWithValue("@imagePath", uploadedImagePath ?? "");
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Task updated successfully!");
                }
            }

            ResetForm();
            LoadTasks();
        }


        private void pendingTasksButton_Click(object sender, EventArgs e)
        {
            LoadTasks("Pending");
        }

        private void completedTasksButton_Click(object sender, EventArgs e)
        {
            LoadTasks("Completed");
        }

        private void todayPriorityButton_Click(object sender, EventArgs e)
        {
            LoadTasks("Today");
        }

        private void btnAddEditTask_Click(object sender, EventArgs e)
        {
            if (selectedTaskId == 0)
            {
                MessageBox.Show("Select a task to edit.", "No Task Selected");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "SELECT Title, Description, Deadline, ImagePath FROM Tasks WHERE TaskId = @taskId AND UserId = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taskId", selectedTaskId);
                cmd.Parameters.AddWithValue("@userId", loggedInUserId);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    txtTitle.Text = reader["Title"].ToString();
                    txtDescription.Text = reader["Description"].ToString();
                    dtpDeadline.Value = Convert.ToDateTime(reader["Deadline"]);
                    uploadedImagePath = reader["ImagePath"] as string;

                    if (!string.IsNullOrWhiteSpace(uploadedImagePath) && File.Exists(uploadedImagePath))
                    {
                        pictureBoxPreview.Image = Image.FromFile(uploadedImagePath);
                        pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        // Membuat bitmap kosong untuk digunakan sebagai background tulisan
                        Bitmap bmp = new Bitmap(pictureBoxPreview.Width, pictureBoxPreview.Height);
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            g.Clear(Color.Gray); // Background warna abu-abu
                            string message = "Gambar tidak tersedia karena sudah dihapus atau dipindahkan";
                            Font font = new Font("Arial", 10, FontStyle.Bold);
                            SizeF textSize = g.MeasureString(message, font);

                            // Menggambar teks di tengah
                            PointF textPosition = new PointF(
                                (bmp.Width - textSize.Width) / 2,
                                (bmp.Height - textSize.Height) / 2
                            );
                            g.DrawString(message, font, Brushes.Black, textPosition);
                        }
                        pictureBoxPreview.Image = bmp;
                        pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                }

                else
                {
                    MessageBox.Show("Task not found or you do not have permission.", "Error");
                }
                reader.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selectedTaskId == 0)
            {
                MessageBox.Show("Select a task to delete.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                string query = "DELETE FROM Tasks WHERE TaskId = @taskId AND UserId = @userId";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taskId", selectedTaskId);
                cmd.Parameters.AddWithValue("@userId", loggedInUserId);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Task deleted successfully!");
            }

            ResetForm(); 
            LoadTasks(); 
        }


        private void imagePath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    uploadedImagePath = openFileDialog.FileName;
                    pictureBoxPreview.Image = Image.FromFile(uploadedImagePath);
                    pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                    MessageBox.Show("Image uploaded and previewed successfully!");
                }
            }
        }
        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                
                selectedTaskId = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["TaskId"].Value);

                txtTitle.Text = dgvTasks.Rows[e.RowIndex].Cells["Title"].Value.ToString();
                txtDescription.Text = dgvTasks.Rows[e.RowIndex].Cells["Description"].Value.ToString();
                dtpDeadline.Value = Convert.ToDateTime(dgvTasks.Rows[e.RowIndex].Cells["Deadline"].Value);

                btnAddEditTask_Click(sender, e);
            }
        }


        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(uploadedImagePath))
            {
                MessageBox.Show("No image has been uploaded!");
                return;
            }

            try
            {
                pictureBoxPreview.Image = Image.FromFile(uploadedImagePath);
                pictureBoxPreview.SizeMode = PictureBoxSizeMode.Zoom;
                MessageBox.Show("Image preview loaded successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load image. Error: " + ex.Message);
            }
        }
        private void InitializeDataGridView()
        {
            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn
            {
                HeaderText = "Select",
                Name = "Select",
                Width = 50
            };
            dgvTasks.Columns.Add(checkBoxColumn);

            DataGridViewImageColumn imageColumn = new DataGridViewImageColumn
            {
                HeaderText = "Image",
                Name = "Image",
                ImageLayout = DataGridViewImageCellLayout.Zoom,
                Width = 100
            };
            dgvTasks.Columns.Add(imageColumn);

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Title", Name = "Title", Width = 200 });

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Description", Name = "Description", Width = 300 });

            dgvTasks.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Deadline", Name = "Deadline", Width = 150 });

            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "Status",
                Name = "Status",
                DataSource = new string[] { "Pending", "Complete" }, 
                Width = 100
            };
            dgvTasks.Columns.Add(statusColumn);

            dgvTasks.AutoGenerateColumns = false;
        }
        private void dgvTasks_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvTasks.Columns["StatusComboBox"].Index && e.RowIndex >= 0)
            {
                string newStatus = dgvTasks.Rows[e.RowIndex].Cells["StatusComboBox"].Value.ToString();
                int taskId = Convert.ToInt32(dgvTasks.Rows[e.RowIndex].Cells["TaskId"].Value);

                UpdateTaskStatusInDatabase(taskId, newStatus);

                MessageBox.Show($"Status task ID {taskId} telah diubah menjadi {newStatus}.", "Status Updated");
            }
        }

        private void UpdateTaskStatusInDatabase(int taskId, string newStatus)
        {
            string query = "UPDATE Tasks SET Status = @Status WHERE TaskId = @TaskId";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", newStatus);
                    cmd.Parameters.AddWithValue("@TaskId", taskId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void MainFormcs_Load(object sender, EventArgs e)
        {

        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAllTaks_Click(object sender, EventArgs e)
        {
            LoadTasks();
            MessageBox.Show("All tasks are loaded.", "All Tasks");
        }

    }
}
