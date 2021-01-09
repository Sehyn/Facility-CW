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
    public partial class Form1 : Form
    {

        Mem m = new Mem();


        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m.OpenProcess("BlackOpsColdWar");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            m.WriteMemory("BlackOpsColdWar.exe+0xFD6B7C8,0x398", "int", "1000");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            m.WriteMemory("BlackOpsColdWar.exe+0xFD6B7C8,0x8", "int", "1");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            m.WriteMemory("BlackOpsColdWar.exe+0xFD6B7C8,0x5CE4", "int", "13337");

        }
    }
}
