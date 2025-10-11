namespace Sari_Sari_Store_Inventory_Systemm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstAvailable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = txtItem.Text;
            string number = txtNumber.Text;

            if (!string.IsNullOrEmpty(item) && !string.IsNullOrEmpty(number))
            {
                if (chkAvailable.Checked)
                {
                    lstAvailable.Items.Add(item + " " + number);
                }
                else
                {
                    lstUnavailable.Items.Add(item + " " + number);
                }

            }

        }
       
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstAvailable.SelectedItem != null || lstUnavailable != null)
            {
                if (lstAvailable.SelectedItem != null)
                {
                    lstAvailable.Items.Remove(lstAvailable.SelectedItem);
                    MessageBox.Show("Item Removed Successfully");
                }
                if (lstUnavailable.SelectedItem != null)
                {
                    lstUnavailable.Items.Remove(lstUnavailable.SelectedItem);
                    MessageBox.Show("Item Removed Successfully");
                }
                else if (lstUnavailable.SelectedItem != null)
                {
                    lstUnavailable.Items.Remove(lstUnavailable.SelectedItem);
                }
                
                else
                {
                    MessageBox.Show("Please select an item to remove.");
                }   
            }
        }
    }
}
