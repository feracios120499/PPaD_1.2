using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPaD_1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Dictionary<string, Form> chipers = new Dictionary<string, Form>();
        private void GenerateChiperForm()
        {
            chipers.Clear();
            chipers.Add("Проста одинарна перестановка", new FormTransposition());
            chipers.Add("Блокова одинарна перестановка", new FormBlockTransposition());
            chipers.Add("Таблична маршрутна перестановка", new FormTableTransposition());
            chipers.Add("Вертикальна перестановка", new FormVerticalTransposition());
            chipers.Add("Магічний квадрат", new FormMagicalTransposition());
            chipers.Add("Шифр подвійної перестановки", new FromDoubleTransposition());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GenerateChiperForm();
            comboBoxChipers.Items.AddRange(chipers.Keys.ToArray());
            comboBoxChipers.SelectedIndex = 0;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            var nameChiper = comboBoxChipers.SelectedItem.ToString();
            var form = chipers[nameChiper];
            form.Show();

            GenerateChiperForm();
        }
    }
}
