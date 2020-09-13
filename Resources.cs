using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ivalice
{
    public class Resources
    {
        public static Characters Mariel_Char = new Characters();
        public static void Resources_Build()
        {
            Main_Form.Notify("Creating Characters");
            Mariel_Char.Name = "Mariel";
            Mariel_Char.Dead = Project_Ivalice.Properties.Resources.Mariel_Dead;
            Mariel_Char.Hurt = Project_Ivalice.Properties.Resources.Mariel_Hurt;
            Mariel_Char.Spellcast_back = Project_Ivalice.Properties.Resources.Mariel_Spellcast_Back;
            Mariel_Char.Spellcast_front = Project_Ivalice.Properties.Resources.Mariel_Spellcast_Front;
            Mariel_Char.Spellcast_left = Project_Ivalice.Properties.Resources.Mariel_Spellcast_Left;
            Mariel_Char.Spellcast_right = Project_Ivalice.Properties.Resources.Mariel_Spellcast_Right;

            Mariel_Char.Walk_back = Project_Ivalice.Properties.Resources.Mariel_Walk_back;
            Mariel_Char.Walk_front = Project_Ivalice.Properties.Resources.Mariel_Walk_Front;
            Mariel_Char.Walk_left = Project_Ivalice.Properties.Resources.Mariel_Walk_left;
            Mariel_Char.Walk_right = Project_Ivalice.Properties.Resources.Mariel_Walk_Right;

            Mariel_Char.Attack_back = Project_Ivalice.Properties.Resources.Mariel_Attack_Back;
            Mariel_Char.Attack_front = Project_Ivalice.Properties.Resources.Mariel_Attack_Front;
            Mariel_Char.Attack_left = Project_Ivalice.Properties.Resources.Mariel_Attack_Front;
            Mariel_Char.Attack_right = Project_Ivalice.Properties.Resources.Mariel_Attack_Right;
            Mariel_Char.Created = true;

        }

    }
}
