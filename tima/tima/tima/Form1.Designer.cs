namespace tima
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
            login_button = new Button();
            login_textBox = new TextBox();
            password_textBox = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // login_button
            // 
            login_button.ForeColor = SystemColors.HotTrack;
            login_button.Location = new Point(417, 304);
            login_button.Name = "login_button";
            login_button.Size = new Size(75, 23);
            login_button.TabIndex = 0;
            login_button.Text = "Войти";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // login_textBox
            // 
            login_textBox.BackColor = SystemColors.InactiveCaption;
            login_textBox.Location = new Point(406, 193);
            login_textBox.Name = "login_textBox";
            login_textBox.Size = new Size(100, 23);
            login_textBox.TabIndex = 1;
            // 
            // password_textBox
            // 
            password_textBox.BackColor = SystemColors.InactiveCaption;
            password_textBox.Location = new Point(406, 247);
            password_textBox.Name = "password_textBox";
            password_textBox.Size = new Size(100, 23);
            password_textBox.TabIndex = 2;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(313, 196);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(306, 250);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Введите пароль";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(942, 571);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(password_textBox);
            Controls.Add(login_textBox);
            Controls.Add(login_button);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_button;
        private TextBox login_textBox;
        private TextBox password_textBox;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label1;
        private Label label2;
    }
}