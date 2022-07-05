using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Educational_Practice
{
    public partial class Format : Form
    {
        public Format()
        {
            InitializeComponent();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Canon.Checked = false;
            Epson.Checked = false;
            Roland.Checked = false;
            Mimaki.Checked = false;
            HP.Checked = false;
            AZiroPlus.Checked = false;
            AZiro.Checked = false;
            AOne.Checked = false;
            ATwo.Checked = false;
            Inkjet.Checked = false;
            Latex.Checked = false;
            Textile.Checked = false;
            Solvent.Checked = false;
            Sublimation.Checked = false;
            Color.Checked = false;
            Monochrome.Checked = false;
            Roll.Checked = false;
            Sheet.Checked = false;
            WiFiModule.Checked = false;
            WiFiDirect.Checked = false;
            AirPrint.Checked = false;
            USBPC.Checked = false;
            LAN.Checked = false;
            USBFlashDrive.Checked = false;
            Small.Checked = false;
            Medium.Checked = false;
            Large.Checked = false;
            Paper.Checked = false;
            Cloth.Checked = false;
            Raster.Checked = false;
            Graphics.Checked = false;
            Glow.Checked = false;
            OK.Checked = false;
            RPK.Checked = false;
            Nevsky.Checked = false;
            Less.Checked = false;
            More.Checked = false;
            Tshirts.Checked = false;
            Flags.Checked = false;
            Drawings.Checked = false;
            Placard.Checked = false;
            Posters.Checked = false;
            Banners.Checked = false;
        }

    }
}
