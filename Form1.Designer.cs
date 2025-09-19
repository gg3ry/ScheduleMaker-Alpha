namespace ScheduleMaker_Alpha
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TeachersBtn = new Button();
            label0 = new Label();
            ClassRoomsBtn = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TeachersBtn
            // 
            TeachersBtn.Location = new Point(121, 73);
            TeachersBtn.Name = "TeachersBtn";
            TeachersBtn.Size = new Size(144, 62);
            TeachersBtn.TabIndex = 0;
            TeachersBtn.Text = "Teachers";
            TeachersBtn.UseVisualStyleBackColor = true;
            TeachersBtn.Click += TeachersBtn_Click;
            // 
            // label0
            // 
            label0.AutoSize = true;
            label0.BackColor = SystemColors.AppWorkspace;
            label0.ForeColor = Color.SpringGreen;
            label0.Location = new Point(134, 155);
            label0.Name = "label0";
            label0.Size = new Size(38, 15);
            label0.TabIndex = 1;
            label0.Text = "label1";
            label0.Visible = false;
            // 
            // ClassRoomsBtn
            // 
            ClassRoomsBtn.Location = new Point(343, 73);
            ClassRoomsBtn.Name = "ClassRoomsBtn";
            ClassRoomsBtn.Size = new Size(144, 62);
            ClassRoomsBtn.TabIndex = 2;
            ClassRoomsBtn.Text = "ClassRooms";
            ClassRoomsBtn.UseVisualStyleBackColor = true;
            ClassRoomsBtn.Click += ClassRoomsBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.AppWorkspace;
            label1.ForeColor = Color.SpringGreen;
            label1.Location = new Point(343, 155);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1333, 763);
            Controls.Add(label1);
            Controls.Add(ClassRoomsBtn);
            Controls.Add(label0);
            Controls.Add(TeachersBtn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button TeachersBtn;
        private Label label0;
        private Button ClassRoomsBtn;
        private Label label1;
    }
}
