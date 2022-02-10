using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberValidation
{
    public partial class FormNumberValidation : Form
    {
        public FormNumberValidation()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int number = 0;
            bool valid = false;

            if (!int.TryParse(textBoxNumber.Text, out number))
            {
                MessageBox.Show("The value must be numeric!", "validation");
                textBoxNumber.Clear();
                textBoxNumber.Focus();

                return;
            }

            for(int i=0; i<listBoxData.Items.Count-1; i++)
            {
                if(listBoxData.Items[1].Equals(number))
                {
                    MessageBox.Show("Number Already Exists", "Duplicate Number");
                    valid = true;
                    break;
                }
            }
           
            if(listBoxData.Items.Contains(Convert.ToInt32(textBoxNumber.Text)))
            {
                MessageBox.Show("number already exist!","Duplicate Numbers");
            }
            else
            {
                listBoxData.Items.Add(number);
                textBoxNumber.Clear();
                textBoxNumber.Focus();
            }
        }

       

        private void listBoxData_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
    }
}
