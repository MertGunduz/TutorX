
namespace TutorX
{
    partial class TutorX_ShowDatabaseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TutorX_ShowDatabaseMenu));
            this.Mid_Panel = new System.Windows.Forms.Panel();
            this.Dynamic_DataGridView = new System.Windows.Forms.DataGridView();
            this.Top_Panel = new System.Windows.Forms.Panel();
            this.Specifier_Label = new System.Windows.Forms.Label();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.Mid_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dynamic_DataGridView)).BeginInit();
            this.Top_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mid_Panel
            // 
            this.Mid_Panel.Controls.Add(this.Dynamic_DataGridView);
            this.Mid_Panel.Controls.Add(this.Top_Panel);
            this.Mid_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mid_Panel.Location = new System.Drawing.Point(0, 0);
            this.Mid_Panel.Name = "Mid_Panel";
            this.Mid_Panel.Size = new System.Drawing.Size(791, 462);
            this.Mid_Panel.TabIndex = 0;
            // 
            // Dynamic_DataGridView
            // 
            this.Dynamic_DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dynamic_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dynamic_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Dynamic_DataGridView.Location = new System.Drawing.Point(0, 47);
            this.Dynamic_DataGridView.Name = "Dynamic_DataGridView";
            this.Dynamic_DataGridView.Size = new System.Drawing.Size(791, 415);
            this.Dynamic_DataGridView.TabIndex = 10;
            this.Dynamic_DataGridView.MouseEnter += new System.EventHandler(this.Dynamic_DataGridView_MouseEnter);
            // 
            // Top_Panel
            // 
            this.Top_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(27)))), ((int)(((byte)(62)))));
            this.Top_Panel.Controls.Add(this.Specifier_Label);
            this.Top_Panel.Controls.Add(this.Minimize_Button);
            this.Top_Panel.Controls.Add(this.Exit_Button);
            this.Top_Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Top_Panel.Location = new System.Drawing.Point(0, 0);
            this.Top_Panel.Name = "Top_Panel";
            this.Top_Panel.Size = new System.Drawing.Size(791, 47);
            this.Top_Panel.TabIndex = 9;
            // 
            // Specifier_Label
            // 
            this.Specifier_Label.Dock = System.Windows.Forms.DockStyle.Left;
            this.Specifier_Label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Specifier_Label.Location = new System.Drawing.Point(0, 0);
            this.Specifier_Label.Name = "Specifier_Label";
            this.Specifier_Label.Size = new System.Drawing.Size(589, 47);
            this.Specifier_Label.TabIndex = 4;
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
            this.Minimize_Button.Location = new System.Drawing.Point(727, 12);
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
            this.Exit_Button.Location = new System.Drawing.Point(756, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(23, 23);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // TutorX_ShowDatabaseMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(791, 462);
            this.Controls.Add(this.Mid_Panel);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TutorX_ShowDatabaseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TutorX";
            this.Mid_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dynamic_DataGridView)).EndInit();
            this.Top_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mid_Panel;
        private System.Windows.Forms.Panel Top_Panel;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Button Exit_Button;
        private System.Windows.Forms.DataGridView Dynamic_DataGridView;
        private System.Windows.Forms.Label Specifier_Label;
    }
}