namespace test
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            idTxt = new TextBox();
            lastsTxt = new TextBox();
            firstTxt = new TextBox();
            miTxt = new TextBox();
            courseTxt = new ComboBox();
            yearTxt = new ComboBox();
            saveBtn = new Button();
            clearBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(32, 54);
            label1.Name = "label1";
            label1.Size = new Size(99, 21);
            label1.TabIndex = 0;
            label1.Text = "STUDENT ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(32, 84);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 1;
            label2.Text = "LASTNAME:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 118);
            label3.Name = "label3";
            label3.Size = new Size(96, 21);
            label3.TabIndex = 2;
            label3.Text = "FIRSTNAME:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 149);
            label4.Name = "label4";
            label4.Size = new Size(31, 21);
            label4.TabIndex = 3;
            label4.Text = "MI:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(32, 181);
            label5.Name = "label5";
            label5.Size = new Size(73, 21);
            label5.TabIndex = 4;
            label5.Text = "COURSE:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(32, 211);
            label6.Name = "label6";
            label6.Size = new Size(50, 21);
            label6.TabIndex = 5;
            label6.Text = "YEAR:";
            // 
            // idTxt
            // 
            idTxt.Location = new Point(137, 52);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(185, 23);
            idTxt.TabIndex = 6;
            // 
            // lastsTxt
            // 
            lastsTxt.Location = new Point(137, 82);
            lastsTxt.Name = "lastsTxt";
            lastsTxt.Size = new Size(185, 23);
            lastsTxt.TabIndex = 7;
            // 
            // firstTxt
            // 
            firstTxt.Location = new Point(137, 116);
            firstTxt.Name = "firstTxt";
            firstTxt.Size = new Size(185, 23);
            firstTxt.TabIndex = 8;
            // 
            // miTxt
            // 
            miTxt.Location = new Point(137, 151);
            miTxt.Name = "miTxt";
            miTxt.Size = new Size(185, 23);
            miTxt.TabIndex = 9;
            // 
            // courseTxt
            // 
            courseTxt.AutoCompleteCustomSource.AddRange(new string[] { "BS Architecture", "BS Chemical Engineering", "BS Civil Engineering", "BS Computer Engineering", "BS Electrical Engineering", "BS Electronics Engineering", "BS Industrial Engineering", "BS Mechanical Engineering", "with Computational Science", "BS Mechanical Engineering", "with Mechatronics", "BS Mining Engineering", "BS Accounting Information Systems", "BS Management Accounting", "BS Business Administration", "Banking & Financial Management", "Business Analytics", "General Business Management", "Human Resource Management", "Marketing Management", "Operations Management", "Quality Management", "BS Hospitality Management", "BS Tourism Management", "BS Office Administration", "Associate in Office administration", "Bachelor in Public Administration", "AB Communication", "AB English with Applied Linguistics", "Bachelor of Elementary Education", "Bachelor of Secondary Education", "Major in English, Filipino, Mathematics and Science", "Bachelor of Multimedia Arts", "BS Biology", "BS Math with Applied Industrial Mathematics", "BS Psychology", "BS Computer Science", "BS Information Technology", "Master in Computer Science", "Master of Science in Computer Science", "Master in Information Technology" });
            courseTxt.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            courseTxt.FormattingEnabled = true;
            courseTxt.Items.AddRange(new object[] { "BS Architecture", "BS Chemical Engineering", "BS Civil Engineering", "BS Computer Engineering", "BS Electrical Engineering", "BS Electronics Engineering", "BS Industrial Engineering", "BS Mechanical Engineering", "with Computational Science", "BS Mechanical Engineering", "with Mechatronics", "BS Mining Engineering", "BS Accounting Information Systems", "BS Management Accounting", "BS Business Administration", "Banking & Financial Management", "Business Analytics", "General Business Management", "Human Resource Management", "Marketing Management", "Operations Management", "Quality Management", "BS Hospitality Management", "BS Tourism Management", "BS Office Administration", "Associate in Office administration", "Bachelor in Public Administration", "AB Communication", "AB English with Applied Linguistics", "Bachelor of Elementary Education", "Bachelor of Secondary Education", "Major in English, Filipino, Mathematics and Science", "Bachelor of Multimedia Arts", "BS Biology", "BS Math with Applied Industrial Mathematics", "BS Psychology", "BS Computer Science", "BS Information Technology", "Master in Computer Science", "Master of Science in Computer Science", "Master in Information Technology" });
            courseTxt.Location = new Point(137, 183);
            courseTxt.Name = "courseTxt";
            courseTxt.Size = new Size(185, 23);
            courseTxt.TabIndex = 10;
            // 
            // yearTxt
            // 
            yearTxt.FormattingEnabled = true;
            yearTxt.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            yearTxt.Location = new Point(137, 213);
            yearTxt.Name = "yearTxt";
            yearTxt.Size = new Size(185, 23);
            yearTxt.TabIndex = 11;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            saveBtn.AutoSize = true;
            saveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveBtn.Location = new Point(70, 273);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 34);
            saveBtn.TabIndex = 13;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            clearBtn.AutoSize = true;
            clearBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            clearBtn.Location = new Point(220, 273);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(75, 34);
            clearBtn.TabIndex = 14;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 322);
            Controls.Add(clearBtn);
            Controls.Add(saveBtn);
            Controls.Add(yearTxt);
            Controls.Add(courseTxt);
            Controls.Add(miTxt);
            Controls.Add(firstTxt);
            Controls.Add(lastsTxt);
            Controls.Add(idTxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox idTxt;
        private TextBox lastsTxt;
        private TextBox firstTxt;
        private TextBox miTxt;
        private ComboBox courseTxt;
        private ComboBox yearTxt;
        private Button saveBtn;
        private Button clearBtn;
    }
}