using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Net;
using System.Net.Sockets;
using System.Diagnostics;
using System.Windows.Forms;

namespace ProgramNet
{
    public static class Mesaj
    {
        public static void Success()
        {
            SoundPlayer player1 = new SoundPlayer("start.wav");
            player1.Play();
            MessageBox.Show("Netul Merge!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        public static void Fail()
        {
            SoundPlayer player2 = new SoundPlayer("fail.wav");
            player2.Play();
            MessageBox.Show("A picat netu!!!", "Prompt", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }
    }
}
