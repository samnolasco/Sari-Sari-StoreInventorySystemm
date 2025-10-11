namespace Sari_Sari_Store_Inventory_Systemm
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
            label1 = new Label();
            panel1 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel2 = new Panel();
            lblUnavailable = new Label();
            lblAvailable = new Label();
            lstUnavailable = new ListBox();
            txtNumber = new TextBox();
            lblNumber = new Label();
            chkAvailable = new CheckBox();
            lstAvailable = new ListBox();
            btnAdd = new Button();
            txtItem = new TextBox();
            lblItem = new Label();
            btnRemove = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Lucida Fax", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(74, 34);
            label1.Name = "label1";
            label1.Size = new Size(387, 54);
            label1.TabIndex = 0;
            label1.Text = "SARI-SARI STORE INVENTORY \r\nMANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(516, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(157, 531);
            panel1.TabIndex = 1;
            // 
            // button8
            // 
            button8.Font = new Font("Lucida Bright", 9.75F);
            button8.Location = new Point(13, 273);
            button8.Name = "button8";
            button8.Size = new Size(133, 42);
            button8.TabIndex = 7;
            button8.Text = "Reports";
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Font = new Font("Lucida Bright", 9.75F);
            button7.Location = new Point(13, 331);
            button7.Name = "button7";
            button7.Size = new Size(133, 42);
            button7.TabIndex = 6;
            button7.Text = "Orders";
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Lucida Bright", 9.75F);
            button6.Location = new Point(13, 449);
            button6.Name = "button6";
            button6.Size = new Size(133, 42);
            button6.TabIndex = 5;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.Font = new Font("Lucida Bright", 9.75F);
            button5.Location = new Point(13, 387);
            button5.Name = "button5";
            button5.Size = new Size(133, 42);
            button5.TabIndex = 4;
            button5.Text = "Settings";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Lucida Bright", 9.75F);
            button4.Location = new Point(13, 214);
            button4.Name = "button4";
            button4.Size = new Size(133, 42);
            button4.TabIndex = 3;
            button4.Text = "Suppliers";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Lucida Bright", 9.75F);
            button3.Location = new Point(13, 157);
            button3.Name = "button3";
            button3.Size = new Size(133, 42);
            button3.TabIndex = 2;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Lucida Bright", 9.75F);
            button2.Location = new Point(13, 98);
            button2.Name = "button2";
            button2.Size = new Size(133, 42);
            button2.TabIndex = 1;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Lucida Bright", 9.75F);
            button1.Location = new Point(13, 40);
            button1.Name = "button1";
            button1.Size = new Size(133, 42);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(btnRemove);
            panel2.Controls.Add(lblUnavailable);
            panel2.Controls.Add(lblAvailable);
            panel2.Controls.Add(lstUnavailable);
            panel2.Controls.Add(txtNumber);
            panel2.Controls.Add(lblNumber);
            panel2.Controls.Add(chkAvailable);
            panel2.Controls.Add(lstAvailable);
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(txtItem);
            panel2.Controls.Add(lblItem);
            panel2.Location = new Point(25, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(462, 390);
            panel2.TabIndex = 2;
            // 
            // lblUnavailable
            // 
            lblUnavailable.AutoSize = true;
            lblUnavailable.Location = new Point(266, 202);
            lblUnavailable.Name = "lblUnavailable";
            lblUnavailable.Size = new Size(68, 15);
            lblUnavailable.TabIndex = 11;
            lblUnavailable.Text = "Unavailable";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Location = new Point(266, 14);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(55, 15);
            lblAvailable.TabIndex = 10;
            lblAvailable.Text = "Available";
            // 
            // lstUnavailable
            // 
            lstUnavailable.FormattingEnabled = true;
            lstUnavailable.ItemHeight = 15;
            lstUnavailable.Location = new Point(266, 220);
            lstUnavailable.Name = "lstUnavailable";
            lstUnavailable.Size = new Size(170, 154);
            lstUnavailable.TabIndex = 9;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(153, 128);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(92, 23);
            txtNumber.TabIndex = 8;
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.DarkRed;
            lblNumber.Font = new Font("Segoe UI", 10.5F);
            lblNumber.ForeColor = SystemColors.ButtonFace;
            lblNumber.Location = new Point(21, 132);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(121, 19);
            lblNumber.TabIndex = 7;
            lblNumber.Text = "Number of Stocks:";
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Location = new Point(103, 181);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(74, 19);
            chkAvailable.TabIndex = 6;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // lstAvailable
            // 
            lstAvailable.FormattingEnabled = true;
            lstAvailable.ItemHeight = 15;
            lstAvailable.Location = new Point(266, 32);
            lstAvailable.Name = "lstAvailable";
            lstAvailable.Size = new Size(170, 154);
            lstAvailable.TabIndex = 5;
            lstAvailable.SelectedIndexChanged += lstAvailable_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Brown;
            btnAdd.Location = new Point(75, 216);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(92, 84);
            txtItem.Name = "txtItem";
            txtItem.Size = new Size(153, 23);
            txtItem.TabIndex = 3;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.BackColor = Color.DarkRed;
            lblItem.Font = new Font("Segoe UI", 11F);
            lblItem.ForeColor = SystemColors.ButtonFace;
            lblItem.Location = new Point(21, 87);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(42, 20);
            lblItem.TabIndex = 2;
            lblItem.Text = "Item:";
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Gainsboro;
            btnRemove.Location = new Point(75, 297);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 42);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "REMOVE";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(672, 530);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button8;
        private Button button7;
        private Button button6;
        private Panel panel2;
        private TextBox txtItem;
        private Label lblItem;
        private ListBox lstAvailable;
        private Button btnAdd;
        private Label lblAvailable;
        private ListBox lstUnavailable;
        private TextBox txtNumber;
        private Label lblNumber;
        private CheckBox chkAvailable;
        private Label lblUnavailable;
        private Button btnRemove;
    }
}
