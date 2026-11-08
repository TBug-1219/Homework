namespace FieldDemo
{
    public partial class Form1 : Form
    {
        // Declare a private field to hold a name.
        private string name = "Charles";

        public Form1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(name);
        }

        private void dariusButton_Click(object sender, EventArgs e)
        {
            name = "Darius";
        }

        private void carmenButton_Click(object sender, EventArgs e)
        {
            name = "Carmen";
        }
    }
}