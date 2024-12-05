namespace ToDoList
{
    partial class MainFormcs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAllTaks = new System.Windows.Forms.Button();
            this.todayPriorityButton = new System.Windows.Forms.Button();
            this.completedTasksButton = new System.Windows.Forms.Button();
            this.pendingTasksButton = new System.Windows.Forms.Button();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.imagePath = new System.Windows.Forms.Button();
            this.dtpDeadline = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.saveTaskButton = new System.Windows.Forms.Button();
            this.btnAddEditTask = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAllTaks);
            this.panel1.Controls.Add(this.todayPriorityButton);
            this.panel1.Controls.Add(this.completedTasksButton);
            this.panel1.Controls.Add(this.pendingTasksButton);
            this.panel1.Controls.Add(this.btnAddTask);
            this.panel1.Location = new System.Drawing.Point(29, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(165, 234);
            this.panel1.TabIndex = 0;
            // 
            // btnAllTaks
            // 
            this.btnAllTaks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAllTaks.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllTaks.Location = new System.Drawing.Point(14, 181);
            this.btnAllTaks.Name = "btnAllTaks";
            this.btnAllTaks.Size = new System.Drawing.Size(142, 35);
            this.btnAllTaks.TabIndex = 4;
            this.btnAllTaks.Text = "All Taks";
            this.btnAllTaks.UseVisualStyleBackColor = false;
            this.btnAllTaks.Click += new System.EventHandler(this.btnAllTaks_Click);
            // 
            // todayPriorityButton
            // 
            this.todayPriorityButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.todayPriorityButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todayPriorityButton.Location = new System.Drawing.Point(13, 137);
            this.todayPriorityButton.Name = "todayPriorityButton";
            this.todayPriorityButton.Size = new System.Drawing.Size(142, 35);
            this.todayPriorityButton.TabIndex = 3;
            this.todayPriorityButton.Text = "Today Priority";
            this.todayPriorityButton.UseVisualStyleBackColor = false;
            this.todayPriorityButton.Click += new System.EventHandler(this.todayPriorityButton_Click);
            // 
            // completedTasksButton
            // 
            this.completedTasksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.completedTasksButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completedTasksButton.Location = new System.Drawing.Point(13, 96);
            this.completedTasksButton.Name = "completedTasksButton";
            this.completedTasksButton.Size = new System.Drawing.Size(142, 32);
            this.completedTasksButton.TabIndex = 2;
            this.completedTasksButton.Text = "Completed Tasks";
            this.completedTasksButton.UseVisualStyleBackColor = false;
            this.completedTasksButton.Click += new System.EventHandler(this.completedTasksButton_Click);
            // 
            // pendingTasksButton
            // 
            this.pendingTasksButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pendingTasksButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pendingTasksButton.Location = new System.Drawing.Point(13, 55);
            this.pendingTasksButton.Name = "pendingTasksButton";
            this.pendingTasksButton.Size = new System.Drawing.Size(142, 32);
            this.pendingTasksButton.TabIndex = 1;
            this.pendingTasksButton.Text = "Pending Taks";
            this.pendingTasksButton.UseVisualStyleBackColor = false;
            this.pendingTasksButton.Click += new System.EventHandler(this.pendingTasksButton_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Location = new System.Drawing.Point(12, 15);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(142, 32);
            this.btnAddTask.TabIndex = 0;
            this.btnAddTask.Text = "Add Task";
            this.btnAddTask.UseVisualStyleBackColor = false;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(245, 12);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersWidth = 51;
            this.dgvTasks.RowTemplate.Height = 24;
            this.dgvTasks.Size = new System.Drawing.Size(932, 248);
            this.dgvTasks.TabIndex = 1;
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPreview);
            this.panel2.Controls.Add(this.imagePath);
            this.panel2.Controls.Add(this.dtpDeadline);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtDescription);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtTitle);
            this.panel2.Location = new System.Drawing.Point(29, 341);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(666, 278);
            this.panel2.TabIndex = 2;
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPreview.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(282, 202);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(104, 43);
            this.btnPreview.TabIndex = 11;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // imagePath
            // 
            this.imagePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.imagePath.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagePath.Location = new System.Drawing.Point(157, 202);
            this.imagePath.Name = "imagePath";
            this.imagePath.Size = new System.Drawing.Size(104, 43);
            this.imagePath.TabIndex = 9;
            this.imagePath.Text = "Upload";
            this.imagePath.UseVisualStyleBackColor = false;
            this.imagePath.Click += new System.EventHandler(this.imagePath_Click);
            // 
            // dtpDeadline
            // 
            this.dtpDeadline.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDeadline.Location = new System.Drawing.Point(132, 143);
            this.dtpDeadline.Name = "dtpDeadline";
            this.dtpDeadline.Size = new System.Drawing.Size(254, 22);
            this.dtpDeadline.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "Upload Image";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deadline";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(132, 82);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(518, 26);
            this.txtDescription.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bodoni MT", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(132, 22);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(518, 26);
            this.txtTitle.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(849, 277);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 42);
            this.button2.TabIndex = 12;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // saveTaskButton
            // 
            this.saveTaskButton.BackColor = System.Drawing.Color.Lime;
            this.saveTaskButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTaskButton.Location = new System.Drawing.Point(701, 277);
            this.saveTaskButton.Name = "saveTaskButton";
            this.saveTaskButton.Size = new System.Drawing.Size(142, 42);
            this.saveTaskButton.TabIndex = 10;
            this.saveTaskButton.Text = "Save";
            this.saveTaskButton.UseVisualStyleBackColor = false;
            this.saveTaskButton.Click += new System.EventHandler(this.saveTaskButton_Click);
            // 
            // btnAddEditTask
            // 
            this.btnAddEditTask.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEditTask.Location = new System.Drawing.Point(553, 277);
            this.btnAddEditTask.Name = "btnAddEditTask";
            this.btnAddEditTask.Size = new System.Drawing.Size(142, 42);
            this.btnAddEditTask.TabIndex = 13;
            this.btnAddEditTask.Text = "Edit";
            this.btnAddEditTask.UseVisualStyleBackColor = true;
            this.btnAddEditTask.Click += new System.EventHandler(this.btnAddEditTask_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(405, 277);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 42);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(701, 341);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(476, 278);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 15;
            this.pictureBoxPreview.TabStop = false;
            // 
            // MainFormcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1199, 631);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.saveTaskButton);
            this.Controls.Add(this.btnAddEditTask);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.panel1);
            this.Name = "MainFormcs";
            this.Text = "MainFormcs";
            this.Load += new System.EventHandler(this.MainFormcs_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button todayPriorityButton;
        private System.Windows.Forms.Button completedTasksButton;
        private System.Windows.Forms.Button pendingTasksButton;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.DataGridView dgvTasks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button saveTaskButton;
        private System.Windows.Forms.Button imagePath;
        private System.Windows.Forms.DateTimePicker dtpDeadline;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnAddEditTask;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAllTaks;
    }
}