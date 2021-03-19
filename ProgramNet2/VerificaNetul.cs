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

namespace ProgramNet
{
    public delegate void VerificEventHandler(object sender, VerificNetEventArgs args);
    public class VerificaNetul
    {
        public event VerificEventHandler Verific;

        public void AvailabilityChanged(object sender, VerificNetEventArgs args, ref int merge, ref int numerge)
        {
            if ((merge == 0 && numerge == 0) || (merge == 0 && numerge == 1))
            {
                if (args.ConnectedToInternet())
                {
                    Mesaj.Success();
                    merge = 1; numerge = 0;
                }
            }
            else
            {
                if ((merge == 0 && numerge == 0) || (merge == 1 && numerge == 0))
                {
                    if (!args.ConnectedToInternet())
                    {
                        Mesaj.Fail();
                        merge = 0; numerge = 1;
                    }
                }
            }
        }

        public void AddVerificNetul(VerificEventHandler v)
        {
            Verific += v;
        }
        public void OnAvailabilityChanged(object sender, VerificNetEventArgs args)
        {
            if (Verific != null) Verific(this, args);
        }
        public void ResetEvent()
        {
            Verific = null;
        }
    }
}
