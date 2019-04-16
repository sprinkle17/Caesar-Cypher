using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string[] cypher = new string[36]{"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","0","1","2","3","4","5","6","7","8","9"};
            string input = textBoxInput.Text.ToUpper();
            char [] characters = input.ToCharArray();
            string newstring = "";
            int key = 5;

            if (checkBoxEncrypt.Checked)
            {
                for (int i = 0; i < cypher.Length; i++)
                {
                    foreach (char c in input)
                    {
                        if (c == '\'' || c == ' ')
                            continue;

                        if (key <= 0)
                            key = key + 36;

                        if (key >= 36)
                            key = key - 36;


                        newstring += cypher[key];
                    }
                }
                listBoxOutput.Text = newstring;
            }

            if (checkBoxDecrypt.Checked)
            {

            }
        }
    }
}
