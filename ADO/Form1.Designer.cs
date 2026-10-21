namespace ADO
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
            dataGridView1 = new DataGridView();
            CustomersList = new ComboBox();
            label1 = new Label();
            GenderBox = new ListBox();
            label2 = new Label();
            button1 = new Button();
            CustomerId = new TextBox();
            Aufrufe = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(848, 568);
            dataGridView1.TabIndex = 1;
            // 
            // CustomersList
            // 
            CustomersList.FormattingEnabled = true;
            CustomersList.Location = new Point(900, 140);
            CustomersList.Name = "CustomersList";
            CustomersList.Size = new Size(242, 40);
            CustomersList.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(906, 104);
            label1.Name = "label1";
            label1.Size = new Size(78, 32);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // GenderBox
            // 
            GenderBox.FormattingEnabled = true;
            GenderBox.Location = new Point(900, 262);
            GenderBox.Name = "GenderBox";
            GenderBox.Size = new Size(240, 164);
            GenderBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(906, 227);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 5;
            label2.Text = "Geschlechter";
            // 
            // button1
            // 
            button1.Location = new Point(967, 462);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 6;
            button1.Text = "Refresh";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // CustomerId
            // 
            CustomerId.ForeColor = Color.Black;
            CustomerId.Location = new Point(917, 608);
            CustomerId.Name = "CustomerId";
            CustomerId.Size = new Size(200, 39);
            CustomerId.TabIndex = 7;
            // 
            // Aufrufe
            // 
            Aufrufe.AutoSize = true;
            Aufrufe.Location = new Point(927, 550);
            Aufrufe.Name = "Aufrufe";
            Aufrufe.Size = new Size(119, 32);
            Aufrufe.TabIndex = 8;
            Aufrufe.Text = "Aufrufe: 0";
            Aufrufe.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1274, 702);
            Controls.Add(Aufrufe);
            Controls.Add(CustomerId);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(GenderBox);
            Controls.Add(label1);
            Controls.Add(CustomersList);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private ComboBox CustomersList;
        private Label label1;
        private ListBox GenderBox;
        private Label label2;
        private Button button1;
        private TextBox CustomerId;
        private Label Aufrufe;
    }
}
