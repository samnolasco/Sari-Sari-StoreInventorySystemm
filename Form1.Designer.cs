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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            pictureBox5 = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            button8 = new Button();
            button6 = new Button();
            panel2 = new Panel();
            label2 = new Label();
            listBox1 = new ListBox();
            btnRemove = new Button();
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(113, 32);
            label1.Name = "label1";
            label1.Size = new Size(524, 76);
            label1.TabIndex = 0;
            label1.Text = "SARI-SARI STORE INVENTORY \r\nMANAGEMENT SYSTEM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 224, 192);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(pictureBox5);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button8);
            panel1.Controls.Add(button6);
            panel1.Location = new Point(736, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(195, 768);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(255, 128, 128);
            button3.Font = new Font("Lucida Bright", 11.25F);
            button3.ForeColor = Color.FromArgb(255, 224, 192);
            button3.Location = new Point(14, 414);
            button3.Name = "button3";
            button3.Size = new Size(166, 50);
            button3.TabIndex = 2;
            button3.Text = "Stock";
            button3.UseVisualStyleBackColor = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Transparent;
            pictureBox5.Image = Properties.Resources._6;
            pictureBox5.Location = new Point(20, 100);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(147, 131);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 128, 128);
            button2.Font = new Font("Lucida Bright", 11.25F);
            button2.ForeColor = Color.FromArgb(255, 224, 192);
            button2.Location = new Point(14, 339);
            button2.Name = "button2";
            button2.Size = new Size(166, 47);
            button2.TabIndex = 1;
            button2.Text = "Products";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 128, 128);
            button1.Font = new Font("Lucida Bright", 11.25F);
            button1.ForeColor = Color.FromArgb(255, 224, 192);
            button1.Location = new Point(14, 262);
            button1.Name = "button1";
            button1.Size = new Size(166, 47);
            button1.TabIndex = 0;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(255, 128, 128);
            button8.Font = new Font("Lucida Bright", 11.25F);
            button8.ForeColor = Color.FromArgb(255, 224, 192);
            button8.Location = new Point(14, 489);
            button8.Name = "button8";
            button8.Size = new Size(166, 53);
            button8.TabIndex = 7;
            button8.Text = "Reports";
            button8.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Red;
            button6.Font = new Font("Lucida Bright", 9.75F);
            button6.Location = new Point(39, 680);
            button6.Name = "button6";
            button6.Size = new Size(133, 42);
            button6.TabIndex = 5;
            button6.Text = "Log Out";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(listBox1);
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
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(21, 154);
            panel2.Name = "panel2";
            panel2.Size = new Size(694, 604);
            panel2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.Location = new Point(547, 98);
            label2.Name = "label2";
            label2.Size = new Size(61, 17);
            label2.TabIndex = 14;
            label2.Text = "Quantity";
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9.75F);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 17;
            listBox1.Location = new Point(489, 118);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(170, 140);
            listBox1.TabIndex = 13;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.Gainsboro;
            btnRemove.Location = new Point(88, 374);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(128, 42);
            btnRemove.TabIndex = 12;
            btnRemove.Text = "REMOVE ITEM";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // lblUnavailable
            // 
            lblUnavailable.AutoSize = true;
            lblUnavailable.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblUnavailable.Location = new Point(446, 279);
            lblUnavailable.Name = "lblUnavailable";
            lblUnavailable.Size = new Size(77, 17);
            lblUnavailable.TabIndex = 11;
            lblUnavailable.Text = "Unavailable";
            // 
            // lblAvailable
            // 
            lblAvailable.AutoSize = true;
            lblAvailable.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            lblAvailable.Location = new Point(362, 98);
            lblAvailable.Name = "lblAvailable";
            lblAvailable.Size = new Size(62, 17);
            lblAvailable.TabIndex = 10;
            lblAvailable.Text = "Available";
            // 
            // lstUnavailable
            // 
            lstUnavailable.Font = new Font("Segoe UI", 9.75F);
            lstUnavailable.FormattingEnabled = true;
            lstUnavailable.ItemHeight = 17;
            lstUnavailable.Location = new Point(302, 300);
            lstUnavailable.Name = "lstUnavailable";
            lstUnavailable.Size = new Size(357, 157);
            lstUnavailable.TabIndex = 9;
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(166, 205);
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
            lblNumber.Location = new Point(34, 209);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(121, 19);
            lblNumber.TabIndex = 7;
            lblNumber.Text = "Number of Stocks:";
            // 
            // chkAvailable
            // 
            chkAvailable.AutoSize = true;
            chkAvailable.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chkAvailable.Location = new Point(116, 258);
            chkAvailable.Name = "chkAvailable";
            chkAvailable.Size = new Size(74, 19);
            chkAvailable.TabIndex = 6;
            chkAvailable.Text = "Available";
            chkAvailable.UseVisualStyleBackColor = true;
            // 
            // lstAvailable
            // 
            lstAvailable.Font = new Font("Segoe UI", 9.75F);
            lstAvailable.FormattingEnabled = true;
            lstAvailable.ItemHeight = 17;
            lstAvailable.Location = new Point(302, 118);
            lstAvailable.Name = "lstAvailable";
            lstAvailable.Size = new Size(170, 140);
            lstAvailable.TabIndex = 5;
            lstAvailable.SelectedIndexChanged += lstAvailable_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Brown;
            btnAdd.Location = new Point(88, 293);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(128, 42);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "ADD ITEM";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtItem
            // 
            txtItem.Location = new Point(105, 161);
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
            lblItem.Location = new Point(34, 164);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(42, 20);
            lblItem.TabIndex = 2;
            lblItem.Text = "Item:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._8;
            pictureBox2.Location = new Point(501, 374);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(275, 266);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(739, 141);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(83, 10);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(136, 135);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(933, 767);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "      ";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button8;
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
        private PictureBox pictureBox1;
        private Label label2;
        private ListBox listBox1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
