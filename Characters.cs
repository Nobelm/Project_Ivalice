using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Ivalice
{
    public class Characters
    {
        public string Name { get; set; }
        public Image Dead { get; set; }
        public Image Hurt { get; set; }
        public Image Spellcast_back { get; set; }
        public Image Spellcast_front { get; set; }
        public Image Spellcast_left { get; set; }
        public Image Spellcast_right { get; set; }
        public Image Walk_back { get; set; }
        public Image Walk_front { get; set; }
        public Image Walk_left { get; set; }
        public Image Walk_right { get; set; }
        public Image Attack_back { get; set; }
        public Image Attack_front { get; set; }
        public Image Attack_left { get; set; }
        public Image Attack_right { get; set; }
        public PictureBox Picbox { get; set; }
        public bool Created { get; set; }

        public void Set_Anim(Image selected_anim)
        {
            Picbox.Image = selected_anim;
        }



    }
}
