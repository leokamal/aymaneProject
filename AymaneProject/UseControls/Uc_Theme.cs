using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;

namespace AymaneProject.UseControls
{
    public partial class Uc_Theme : UserControl
    {
        public Uc_Theme()
        {
            InitializeComponent();
        }

        private void metroToggle1_CheckedChanged(object sender, EventArgs e)
        {
            this.metroLabel1.Text = (this.metroToggle1.Checked) ? "Light" : "Dark"; 
            if(this.Parent is MetroForm)
            {
                ((MetroForm)this.Parent).Theme = (!this.metroToggle1.Checked) ? MetroFramework.MetroThemeStyle.Light : MetroFramework.MetroThemeStyle.Dark;

                foreach (var ctrl in (this.Parent as MetroForm).Controls)
                {
                    if(ctrl is MetroLabel)
                        ((MetroLabel)ctrl).Theme = (!this.metroToggle1.Checked) ? MetroFramework.MetroThemeStyle.Light : MetroFramework.MetroThemeStyle.Dark;
                    if (ctrl is MetroButton)
                        ((MetroButton)ctrl).Theme = (!this.metroToggle1.Checked) ? MetroFramework.MetroThemeStyle.Light : MetroFramework.MetroThemeStyle.Dark;
                    if (ctrl is MetroComboBox)
                        ((MetroComboBox)ctrl).Theme = (!this.metroToggle1.Checked) ? MetroFramework.MetroThemeStyle.Light : MetroFramework.MetroThemeStyle.Dark;
                    if (ctrl is MetroCheckBox)
                        ((MetroCheckBox)ctrl).Theme = (!this.metroToggle1.Checked) ? MetroFramework.MetroThemeStyle.Light : MetroFramework.MetroThemeStyle.Dark;
                    if (ctrl is MetroRadioButton)
                        ((MetroRadioButton)ctrl).Theme = (!this.metroToggle1.Checked) ? MetroFramework.MetroThemeStyle.Light : MetroFramework.MetroThemeStyle.Dark;


              }












            }
            

        
        }
    }
}
