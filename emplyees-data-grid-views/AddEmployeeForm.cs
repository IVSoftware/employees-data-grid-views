using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURSACH
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            buttonCancel.Click += (sender, e) => DialogResult = DialogResult.Cancel;
            buttonOK.Click += (sender, e) => DialogResult = DialogResult.OK;
            maskedTextBoxAge.Mask = "00";
            maskedTextBoxSalary.Mask = "000,000";
        }
        public string FirstName => textBoxName.Text;
        public string Surname => textBoxSurname.Text;
        public int Age => int.TryParse(maskedTextBoxAge.Text, out var id) ? id : -1;
        public decimal Salary =>  
            decimal
            .TryParse(maskedTextBoxSalary.Text.Replace(",", string.Empty), out var id) ? id : -1;
        public string? Position => textBoxPosition.Text;
    }
}
