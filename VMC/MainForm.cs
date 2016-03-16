using System;
using System.Windows.Forms;
using System.Net;
using Behringer.X32;
using OSC;

namespace VMC
{  
    public partial class MainForm : Form
    {
        protected X32Console X32 { get; set; }
      

        public MainForm()
        {
            InitializeComponent();

            X32 = new X32Console();           
            X32.OnChannelFade += OnChannelFade;
            X32.OnChannelMute += OnChannelMute;
            X32.OnChannelPan += OnChannelPan;
            X32.OnChannelMute += X32_OnChannelMute;
            X32.OnConnect += OnConnect;
            X32.OnMeter += X32_OnMeter;      
            
            X32.Connect("192.168.1.3");
        }

        void X32_OnChannelMute(object sender, OSCPacket packet)
        {
            Console.WriteLine("Mute");
        }

        void X32_OnMeter(object sender, OSCPacket packet)
        {
            int meter = Convert.ToInt32(packet.Nodes[2]);

            switch (meter)
            {
                case 1:
                    this.BeginInvoke(new ThreadSafeOSC(UpdateMeter), packet.ToParams());
                    break;
                case 14:
                    this.BeginInvoke(new ThreadSafeOSC(UpdateMeter), packet.ToParams());
                    break;
                case 15:
                    this.BeginInvoke(new ThreadSafeOSC(UpdateMeter), packet.ToParams());
                    break;
                default:
                    break;
            }            
        }

        private void UpdateMeter(OSCPacket packet)
        {
            progressBar1.Value = packet.BlobElementToInt(0, 0);
        }

        private void OnConnect()
        {
            for (int i = 0; i < 8; i++)
            {
                X32.ControlRequest(X32.Channel[i].Strip.Fader);
                X32.ControlRequest(X32.Channel[i].Strip.Mute);
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            X32.RenewMeters[0] = !X32.RenewMeters[0];
        }

       
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            X32.Disconnect();
            Application.Exit();
        }
        
        #region [OnChannelFade]
        private void OnChannelFade(object sender, OSCPacket packet)
        {   
           this.BeginInvoke(new ThreadSafeOSC(ThreadSafeOnChannelFade), packet.ToParams());            
        }

        private void ThreadSafeOnChannelFade(OSCPacket packet)
        {
            TrackBar trackBar = GetTrackBarFromChannel(Convert.ToInt32(packet.Nodes[2]));
            trackBar.Tag = packet;
            trackBar.Value = (int)(packet.Arguments[0].ToFloat() * 100);
            
        }

        private TrackBar GetTrackBarFromChannel(int channel)
        {
            switch (channel)
            {
                case 1:
                case 9:
                case 17:
                case 25:
                    return fader1;

                case 2:
                case 10:
                case 18:
                case 26:
                    return fader2;

                case 3:
                case 11:
                case 19:
                case 27:
                    return fader3;

                case 4:
                case 12:
                case 20:
                case 28:
                    return fader4;

                case 5:
                case 13:
                case 21:
                case 29:
                    return fader5;

                case 6:
                case 14:
                case 22:
                case 30:
                    return fader6;

                case 7:
                case 15:
                case 23:
                case 31:
                    return fader7;

                case 8:
                case 16:
                case 24:
                case 32:
                    return fader8;

                default:
                    return null;
            }
        }

        private void HandleFaderValueChange(TrackBar fader, int channel)
        {
            if (fader.Tag == null)
            {
                X32.Channel[channel - 1].Strip.Fader.Value = (float)fader.Value / 100;
                X32.SendParameter(X32.Channel[channel - 1].Strip.Fader);
            }
            fader.Tag = null;
        }

        private void fader1_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader1, 1);
        }
        
        private void fader2_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader2, 2);
        }

        private void fader3_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader3, 3);
        }

        private void fader4_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader4, 4);
        }

        private void fader5_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader5, 5);
        }

        private void fader6_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader6, 6);
        }

        private void fader7_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader7, 7);
        }

        private void fader8_ValueChanged(object sender, EventArgs e)
        {
            HandleFaderValueChange(fader8, 8);
        }
        #endregion

        #region [OnChannelMute]
        private void OnChannelMute(object sender, OSCPacket packet)
        {
            btnMute1_Click(this, new EventArgs());
        }

        private void btnMute1_Click(object sender, EventArgs e)
        {
            X32.Channel[0].Strip.Mute.Toggle();
            if (X32.Channel[0].Strip.Mute.Value == X32OnOff.On)
                btnMute1.BackColor = System.Drawing.SystemColors.Control;
            else
                btnMute1.BackColor = System.Drawing.SystemColors.ControlDark;
            X32.SendParameter(X32.Channel[0].Strip.Mute);
        }
        #endregion

        #region [OnChannelPan]
        private void OnChannelPan(object sender, OSCPacket packet)
        {
            this.BeginInvoke(new ThreadSafeOSC(ThreadSafeOnChannelPan), packet.ToParams());  
        }

        private void ThreadSafeOnChannelPan(OSCPacket packet)
        {
            trackPan.Tag = packet;
            trackPan.Value = (int)(packet.Arguments[0].ToFloat() * 100);         
        }


        private void trackPan_ValueChanged(object sender, EventArgs e)
        {
            if (trackPan.Tag == null)
            {
                X32.Aux[4].Strip.Pan.Value = (float)trackPan.Value / 100;
                X32.SendParameter(X32.Aux[4].Strip.Pan);
                
            }
            trackPan.Tag = null;            
        }
        #endregion

        private void trackAuxSend_ValueChanged(object sender, EventArgs e)
        {           
            X32.Matrix[0].Strip.Fader.Value = (float)(trackAuxSend.Value) / 100;
            X32.SendParameter(X32.Matrix[0].Strip.Fader);
        }

        private void btnSOF_Click(object sender, EventArgs e)
        {
            X32.ControlRequest(X32.Channel[0].Strip.Mute);       
        }
    }
}
