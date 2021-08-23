
namespace TutorX
{
    partial class TutorX_AddLectureMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorX_AddLectureMenu));
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Bottom_Margin = new System.Windows.Forms.Panel();
            this.Top_Margin = new System.Windows.Forms.Panel();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Left_Margin = new System.Windows.Forms.Panel();
            this.Right_Margin = new System.Windows.Forms.Panel();
            this.Top_Border = new System.Windows.Forms.Panel();
            this.Bottom_Border = new System.Windows.Forms.Panel();
            this.Right_Border = new System.Windows.Forms.Panel();
            this.Left_Border = new System.Windows.Forms.Panel();
            this.AddLessons_Label = new System.Windows.Forms.Label();
            this.Seperator_Panel = new System.Windows.Forms.Panel();
            this.Student_ComboBox = new System.Windows.Forms.ComboBox();
            this.Lesson_ComboBox = new System.Windows.Forms.ComboBox();
            this.Teacher_ComboBox = new System.Windows.Forms.ComboBox();
            this.Date_TextBox = new System.Windows.Forms.TextBox();
            this.AddStudent_Button = new System.Windows.Forms.Button();
            this.Mid_Panel.SuspendLayout();
            this.Top_Margin.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Mid_Panel.Controls.Add(this.AddStudent_Button);
            this.Mid_Panel.Controls.Add(this.Date_TextBox);
            this.Mid_Panel.Controls.Add(this.Teacher_ComboBox);
            this.Mid_Panel.Controls.Add(this.Lesson_ComboBox);
            this.Mid_Panel.Controls.Add(this.Student_ComboBox);
            this.Mid_Panel.Controls.Add(this.Seperator_Panel);
            this.Mid_Panel.Controls.Add(this.AddLessons_Label);
            this.Mid_Panel.Controls.Add(this.Left_Border);
            this.Mid_Panel.Controls.Add(this.Right_Border);
            this.Mid_Panel.Controls.Add(this.Bottom_Border);
            this.Mid_Panel.Controls.Add(this.Top_Border);
            this.Mid_Panel.Controls.Add(this.Bottom_Margin);
            this.Mid_Panel.Controls.Add(this.Top_Margin);
            this.Mid_Panel.Controls.Add(this.Left_Margin);
            this.Mid_Panel.Controls.Add(this.Right_Margin);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(347, 467);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Bottom_Margin
            // 
            this.Bottom_Margin.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Margin.Location = new System.Drawing.Point(10, 457);
            this.Bottom_Margin.Name = "Bottom_Margin";
            this.Bottom_Margin.Size = new System.Drawing.Size(327, 10);
            this.Bottom_Margin.TabIndex = 16;
            // 
            // Top_Margin
            // 
            this.Top_Margin.Controls.Add(this.Minimize_Button);
            this.Top_Margin.Controls.Add(this.Exit_Button);
            this.Top_Margin.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Margin.Location = new System.Drawing.Point(10, 0);
            this.Top_Margin.Name = "Top_Margin";
            this.Top_Margin.Size = new System.Drawing.Size(327, 47);
            this.Top_Margin.TabIndex = 15;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.FlatAppearance.BorderSize = 0;
            this.Minimize_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Minimize_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Minimize_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Minimize_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize_Button.Image = global::TutorX.Properties.Resources.TutorX_MinimizeIcon;
            this.Minimize_Button.Location = new System.Drawing.Point(269, 12);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(23, 23);
            this.Minimize_Button.TabIndex = 1;
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.FlatAppearance.BorderSize = 0;
            this.Exit_Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Exit_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Exit_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Exit_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit_Button.Image = global::TutorX.Properties.Resources.TutorX_ExitIcon;
            this.Exit_Button.Location = new System.Drawing.Point(298, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(23, 23);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Left_Margin
            // 
            this.Left_Margin.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Margin.Location = new System.Drawing.Point(0, 0);
            this.Left_Margin.Name = "Left_Margin";
            this.Left_Margin.Size = new System.Drawing.Size(10, 467);
            this.Left_Margin.TabIndex = 14;
            // 
            // Right_Margin
            // 
            this.Right_Margin.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Margin.Location = new System.Drawing.Point(337, 0);
            this.Right_Margin.Name = "Right_Margin";
            this.Right_Margin.Size = new System.Drawing.Size(10, 467);
            this.Right_Margin.TabIndex = 13;
            // 
            // Top_Border
            // 
            this.Top_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Top_Border.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Border.Location = new System.Drawing.Point(10, 47);
            this.Top_Border.Name = "Top_Border";
            this.Top_Border.Size = new System.Drawing.Size(327, 2);
            this.Top_Border.TabIndex = 17;
            // 
            // Bottom_Border
            // 
            this.Bottom_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Bottom_Border.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Bottom_Border.Location = new System.Drawing.Point(10, 455);
            this.Bottom_Border.Name = "Bottom_Border";
            this.Bottom_Border.Size = new System.Drawing.Size(327, 2);
            this.Bottom_Border.TabIndex = 18;
            // 
            // Right_Border
            // 
            this.Right_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Right_Border.Dock = System.Windows.Forms.DockStyle.Right;
            this.Right_Border.Location = new System.Drawing.Point(335, 49);
            this.Right_Border.Name = "Right_Border";
            this.Right_Border.Size = new System.Drawing.Size(2, 406);
            this.Right_Border.TabIndex = 19;
            // 
            // Left_Border
            // 
            this.Left_Border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Left_Border.Dock = System.Windows.Forms.DockStyle.Left;
            this.Left_Border.Location = new System.Drawing.Point(10, 49);
            this.Left_Border.Name = "Left_Border";
            this.Left_Border.Size = new System.Drawing.Size(2, 406);
            this.Left_Border.TabIndex = 20;
            // 
            // AddLessons_Label
            // 
            this.AddLessons_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddLessons_Label.Image = global::TutorX.Properties.Resources.create_lectures;
            this.AddLessons_Label.Location = new System.Drawing.Point(12, 49);
            this.AddLessons_Label.Name = "AddLessons_Label";
            this.AddLessons_Label.Size = new System.Drawing.Size(323, 82);
            this.AddLessons_Label.TabIndex = 21;
            // 
            // Seperator_Panel
            // 
            this.Seperator_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Seperator_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Seperator_Panel.Location = new System.Drawing.Point(12, 131);
            this.Seperator_Panel.Name = "Seperator_Panel";
            this.Seperator_Panel.Size = new System.Drawing.Size(323, 2);
            this.Seperator_Panel.TabIndex = 22;
            // 
            // Student_ComboBox
            // 
            this.Student_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Student_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.Student_ComboBox.FormattingEnabled = true;
            this.Student_ComboBox.Location = new System.Drawing.Point(22, 150);
            this.Student_ComboBox.Name = "Student_ComboBox";
            this.Student_ComboBox.Size = new System.Drawing.Size(302, 29);
            this.Student_ComboBox.TabIndex = 23;
            this.Student_ComboBox.Text = "  Student:";
            // 
            // Lesson_ComboBox
            // 
            this.Lesson_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Lesson_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Lesson_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.Lesson_ComboBox.FormattingEnabled = true;
            this.Lesson_ComboBox.Location = new System.Drawing.Point(22, 216);
            this.Lesson_ComboBox.Name = "Lesson_ComboBox";
            this.Lesson_ComboBox.Size = new System.Drawing.Size(302, 29);
            this.Lesson_ComboBox.TabIndex = 24;
            this.Lesson_ComboBox.Text = "  Lesson:";
            // 
            // Teacher_ComboBox
            // 
            this.Teacher_ComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Teacher_ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacher_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.Teacher_ComboBox.FormattingEnabled = true;
            this.Teacher_ComboBox.Location = new System.Drawing.Point(22, 282);
            this.Teacher_ComboBox.Name = "Teacher_ComboBox";
            this.Teacher_ComboBox.Size = new System.Drawing.Size(302, 29);
            this.Teacher_ComboBox.TabIndex = 25;
            this.Teacher_ComboBox.Text = "  Teacher:";
            // 
            // Date_TextBox
            // 
            this.Date_TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.Date_TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Date_TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.Date_TextBox.Location = new System.Drawing.Point(22, 348);
            this.Date_TextBox.Name = "Date_TextBox";
            this.Date_TextBox.Size = new System.Drawing.Size(302, 27);
            this.Date_TextBox.TabIndex = 26;
            this.Date_TextBox.Text = "  Date:";
            // 
            // AddStudent_Button
            // 
            this.AddStudent_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(61)))), ((int)(((byte)(159)))));
            this.AddStudent_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AddStudent_Button.FlatAppearance.BorderSize = 0;
            this.AddStudent_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddStudent_Button.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AddStudent_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(98)))), ((int)(((byte)(213)))));
            this.AddStudent_Button.Image = ((System.Drawing.Image)(resources.GetObject("AddStudent_Button.Image")));
            this.AddStudent_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddStudent_Button.Location = new System.Drawing.Point(12, 420);
            this.AddStudent_Button.Name = "AddStudent_Button";
            this.AddStudent_Button.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.AddStudent_Button.Size = new System.Drawing.Size(323, 35);
            this.AddStudent_Button.TabIndex = 27;
            this.AddStudent_Button.Text = "Add Student";
            this.AddStudent_Button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddStudent_Button.UseVisualStyleBackColor = false;
            this.AddStudent_Button.Click += new System.EventHandler(this.AddStudent_Button_Click);
            // 
            // TutorX_AddLectureMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(347, 467);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorX_AddLectureMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TutorX";
            this.Load += new System.EventHandler(this.TutorX_AddLectureMenu_Load);
            this.Mid_Panel.ResumeLayout(false);
            this.Mid_Panel.PerformLayout();
            this.Top_Margin.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Panel Bottom_Margin;
        private System.Windows.Forms.Panel Top_Margin;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.Panel Left_Margin;
        private System.Windows.Forms.Panel Right_Margin;
        private System.Windows.Forms.Panel Top_Border;
        private System.Windows.Forms.Panel Bottom_Border;
        private System.Windows.Forms.Panel Right_Border;
        private System.Windows.Forms.Panel Left_Border;
        private System.Windows.Forms.Panel Seperator_Panel;
        private System.Windows.Forms.Label AddLessons_Label;
        private System.Windows.Forms.ComboBox Student_ComboBox;
        private System.Windows.Forms.TextBox Date_TextBox;
        private System.Windows.Forms.ComboBox Teacher_ComboBox;
        private System.Windows.Forms.ComboBox Lesson_ComboBox;
        private System.Windows.Forms.Button AddStudent_Button;
    }
}