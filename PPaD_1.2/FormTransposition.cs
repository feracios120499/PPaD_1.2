using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TranspositionLibrary;

namespace PPaD_1._2
{
    public partial class FormTransposition : Form
    {
        public FormTransposition()
        {
            InitializeComponent();
        }
        Transposition chiper = new Transposition();
        private void ButtonEncrypt_Click(object sender, EventArgs e)
        {
            if (textBoxEncryptOriginal.TextLength == 0)
                return;
            chiper.SetKey(textBoxKey.Text);
            var encrypt = chiper.Encrypt(textBoxEncryptOriginal.Text);

            textBoxEncrypt.Text = encrypt;
        }

        private void ButtonDecrypt_Click(object sender, EventArgs e)
        {
            if (textBoxDecryptOriginal.TextLength == 0)
                return;
            chiper.SetKey(textBoxKey.Text);
            var decrypt = chiper.Decrypt(textBoxDecryptOriginal.Text);

            textBoxDecrypt.Text = decrypt;
        }
    }
}
