using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caballitos
{
    public partial class Caballito : UserControl
    {
        Spritesheet player;
        public Caballito()
        {
            InitializeComponent();

            this.player = new Spritesheet(Properties.Resources.HorseSpriteSheetWhite_2, 208, 129);
            pb_char.Image = this.player.curState;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        public void MoverCaballito()
        {
            player.playSprite(5, 5, 3);
            pb_char.Image = player.curState;

            //this.Refresh();
        }

        private void Caballito_Load(object sender, EventArgs e)
        {


            //player.playSprite(5, 13, 0);
            //pb_char.Image = player.curState;
        }

    }
}
