using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EncryptorCore;

namespace Encrytor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void EncryptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputTextBox.Text))
            {
                var encryptor = new SimpleEncryption();
                var inputText = InputTextBox.Text;
                var outputText = encryptor.EncryptText(inputText);
                OutputTextBox.Text = outputText;
            }
            else
            {
                MessageBox.Show("The input field is empty");
            }
        }

        private void DecryptBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(InputTextBox.Text))
            {
                var encryptor = new SimpleDecryption();
                var inputText = InputTextBox.Text;
                var outputText = encryptor.DecryptText(inputText);
                OutputTextBox.Text = outputText;
            }
            else
            {
                MessageBox.Show("The input field is empty");
            }
        }
    }
}
