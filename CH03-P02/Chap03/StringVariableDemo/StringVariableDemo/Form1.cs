namespace StringVariableDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void showNameButton_Click(object sender, EventArgs e)
        {
            // Declare a string variable to hold the full name.
            string fullname;

            // Combine the names with a space between them. Assign the
            // result to the fullname varible.
            fullname = firstNameTextBox.Text + " " + lastNameTextBox.Text;

            // Display the fullname variable in the fullNameLabel control.
            fullNameLabel.Text = fullname;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}

