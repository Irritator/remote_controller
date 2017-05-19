using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Tv
    {
        private bool power;
        private int volume;
        private int channel;
        private bool muted;
        public Tv()
        {
            power = false;
            volume = 50;
            channel = 1;
            muted = false;
        }

        public void setChannel(int channel)
        {
            this.channel = channel;
        }
        public int getChannel()
        {
            return this.channel;
        }

        public void incVol()
        {
            volume++;
            if (volume > 100) volume = 100;
        }

        public void decVol()
        {
            volume--;
            if (volume < 0) volume = 0;
        }

        public void changePower()
        {
            power = !power;
        }

        public bool state()
        {
            return power;
        }
        public int getVol()
        {
            if (muted) return 0;
            return volume;
        }

        public void incChannel()
        {
            channel++;
        }

        public void decChannel()
        {
            if (channel > 1)
                channel--;
        }

        public void mute()
        {
            muted = !muted;
        }

        public bool working()
        {
            return power;
        }
    }
}
