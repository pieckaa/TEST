namespace test
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
            Column6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            dgvClassList = new DataGridView();
            addBtn = new Button();
            saveBtn = new Button();
            loadBtn = new Button();
            clearBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClassList).BeginInit();
            SuspendLayout();
            // 
            // Column6
            // 
            Column6.HeaderText = "YEAR";
            Column6.Name = "Column6";
            // 
            // Column5
            // 
            Column5.HeaderText = "COURSE";
            Column5.Name = "Column5";
            // 
            // Column4
            // 
            Column4.HeaderText = "MI";
            Column4.Name = "Column4";
            // 
            // Column3
            // 
            Column3.HeaderText = "FIRSTNAME";
            Column3.Name = "Column3";
            // 
            // Column2
            // 
            Column2.HeaderText = "LASTNAME";
            Column2.Name = "Column2";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // dgvClassList
            // 
            dgvClassList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClassList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvClassList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassList.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dgvClassList.Location = new Point(12, 12);
            dgvClassList.Name = "dgvClassList";
            dgvClassList.RowTemplate.Height = 25;
            dgvClassList.Size = new Size(776, 372);
            dgvClassList.TabIndex = 0;
            // 
            // addBtn
            // 
            addBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            addBtn.AutoSize = true;
            addBtn.Location = new Point(12, 403);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(89, 35);
            addBtn.TabIndex = 1;
            addBtn.Text = "ADD";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveBtn.AutoSize = true;
            saveBtn.Location = new Point(599, 403);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(82, 35);
            saveBtn.TabIndex = 3;
            saveBtn.Text = "SAVE";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // loadBtn
            // 
            loadBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            loadBtn.AutoSize = true;
            loadBtn.Location = new Point(706, 403);
            loadBtn.Name = "loadBtn";
            loadBtn.Size = new Size(82, 35);
            loadBtn.TabIndex = 4;
            loadBtn.Text = "LOAD";
            loadBtn.UseVisualStyleBackColor = true;
            loadBtn.Click += loadBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            clearBtn.AutoSize = true;
            clearBtn.Location = new Point(120, 403);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(89, 35);
            clearBtn.TabIndex = 5;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = true;
            clearBtn.Click += clearBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(clearBtn);
            Controls.Add(loadBtn);
            Controls.Add(saveBtn);
            Controls.Add(addBtn);
            Controls.Add(dgvClassList);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClassList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column1;
        private Button saveBtn;
        private Button loadBtn;
        private Button addBtn;
        public DataGridView dgvClassList;
        private Button clearBtn;
    }
}
