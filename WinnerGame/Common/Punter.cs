using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinnerGame.Common
{
    public abstract class Punter
    {

        public int Amount;

        public Bet PunterBet;

        public RadioButton PunterRadioButton;

        public string Name;

        public bool Winner;

        public TextBox PunterTextBox;

        public bool Busted;
    }
}
