using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AymaneProject
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;

            for(int i = 0; i < 10; i++)
            {
                Button btn = new Button();

                btn.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btn.Name = "button"+i;
                btn.Size = new System.Drawing.Size(151, 116);
                btn.TabIndex = i;
                btn.Text = "button"+i;
                btn.UseVisualStyleBackColor = true;

                //add Button to FlowLayoutPanel
                this.flowLayoutPanel1.Controls.Add(btn);
            }
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
           this.Theme = (!this.metroToggle1.Checked) ? MetroFramework.MetroThemeStyle.Light: MetroFramework.MetroThemeStyle.Dark;
        }
    }
}
