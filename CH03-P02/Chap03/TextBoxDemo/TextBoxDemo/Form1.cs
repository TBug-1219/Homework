namespace TextBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void readInputButton_Click(object sender, EventArgs e)
        {
            // Assign the name entered by the user to the
            // outputLabel control's Text property.
            outputLabel.Text = nameTextBox.Text;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

