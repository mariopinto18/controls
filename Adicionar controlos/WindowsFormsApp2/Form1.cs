using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // criar controlos visíveis na classe Form1
            private TextBox txtBox = new TextBox();
            private Button btnAdd = new Button();
            private Label lbl1 = new Label();

        public Form1()
        {
           InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
            {
            // na abertura do Form estou a personalizar os controlos  
            txtBox.Text = "";
            txtBox.Location = new System.Drawing.Point(150, 50);
            this.Controls.Add(txtBox);


            btnAdd.Text = "btnAdd";
            btnAdd.Location = new System.Drawing.Point(300, 200);
            btnAdd.Visible = true;
            this.Controls.Add(btnAdd);

            lbl1.Text = "Label de teste";
            lbl1.Location = new System.Drawing.Point(40, 50);
            this.Controls.Add(lbl1);

        }
        
    }
}
