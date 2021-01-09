using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace Facility_CW
{
    public partial class Faciliot : Form
    {

        Mem m = new Mem();


        public Faciliot()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.OpenProcess("BlackOpsColdWar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.WriteMemory("BlackOpsColdWar.exe+0xFD6B7C8,0xE67", "byte", "0xA0");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.WriteMemory("BlackOpsColdWar.exe+0xFD6B7C8,0x8,0x398", "int", "1");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.WriteMemory("BlackOpsColdWar.exe+0xFD6B7C8,0x5CE4", "int", "13337");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            m.WriteMemory("BlackOpsColdWar.exe+0xFD6B7C8,0x5C30", "float", "5");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
