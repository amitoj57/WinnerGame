using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinnerGame.Common;

namespace WinnerGame
{
    public partial class GameForm : Form
    {

        Fox[] foxes;
        Punter[] punters;
        Timer[] timers;
        Fox winnerFox;

        public GameForm()
        {
            InitializeComponent();
            PrepareAllGamePart();
        }

        private void PrepareAllGamePart()
        {
            PictureBox[] pictures = { picture1, picture2, picture3, picture4 };
            foxes = new Fox[pictures.Length];
            for (int index = 0; index < foxes.Length; index++)
            {
                foxes[index] = new Fox();
                foxes[index].Name = "Fox No: " + (index + 1);
                foxes[index].FoxPictureBox = pictures[index];
                foxes[index].TrackLength = 690;
            }

            TextBox[] texts = { text1, text2, text3 };
            RadioButton[] radioButtons = { radio1, radio2, radio3 };

            punters = new Punter[texts.Length];
            for (int index = 0; index < punters.Length; index++)
            {
                punters[index] = Factory.GetPunter(index + 1);
                punters[index].PunterRadioButton = radioButtons[index];
                punters[index].PunterRadioButton.Text = punters[index].Name;
                punters[index].PunterTextBox = texts[index];
                punters[index].Amount = 50;
            }

            npFoxNo.Minimum = 1;
            npFoxNo.Maximum = foxes.Length;
            npFoxNo.Value = 1;
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            if (btnOperation.Text.Contains("Place"))
            {
                PlaceTheBet();
            }
            else if(btnOperation.Text.Contains("Start"))
            {
                StartRace();
            }
        }

        private void PlaceTheBet()
        {
            int active = 0;
            int totalbet = 0;
            for (int index = 0; index < punters.Length; index++)
            {
                if (!punters[index].Busted)
                {
                    active++;
                    if (punters[index].PunterRadioButton.Checked)
                    {
                        string message = "";
                        if (punters[index].PunterBet != null)
                        {
                            message = string.Format(" {0} is Already Placed Bet For Race Game...", punters[index].Name);
                        }
                        else
                        {
                            int foxno = (int)npFoxNo.Value;
                            int amount = (int)npBetAmount.Value;
                            bool picked = false;
                            for (int i = 0; i < punters.Length; i++)
                            {
                                if (punters[i].PunterBet != null && punters[i].PunterBet.Fox == foxes[foxno - 1])
                                {
                                    picked = true;
                                    break;
                                }
                            }
                            if (picked)
                            {
                                message = string.Format("Fox No {0} is Picked By Another Punter", foxno);
                            }
                            else
                            {
                                punters[index].PunterBet = new Bet();
                                punters[index].PunterBet.Amount = amount;
                                punters[index].PunterBet.Fox = foxes[foxno - 1];
                            }
                        }
                        if (message.Length != 0)
                        {
                            MessageBox.Show(message);
                        }
                    }

                    if (punters[index].PunterBet != null)
                    {
                        totalbet++;
                    }
                }
            }
            SetupPunter();
            if (totalbet == active)
            {
                btnOperation.Text = "Start Race...";
                panelBet.Enabled = false;
            }
        }

        private void StartRace()
        {
            timers = new Timer[foxes.Length];
            for (int index = 0; index < foxes.Length; index++)
            {
                timers[index] = new Timer();
                timers[index].Interval = 12;
                timers[index].Tick += Ticking_Event;
            }
            foreach (Timer timer in timers)
            {
                timer.Start();
            }
            btnOperation.Enabled = false;
        }

        private void Ticking_Event(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            int index = -1;
            for (int i = 0; i < timers.Length; i++)
            {
                if (timer == timers[i])
                {
                    index = i;
                    break;
                }
            }
            if (index != -1)
            {
                PictureBox picture = foxes[index].FoxPictureBox;
                if (picture.Location.X  > foxes[index].TrackLength)
                {
                    
                    if (winnerFox == null)
                    {
                        winnerFox = foxes[index];
                    }
                    foreach (Timer tim in timers)
                    {
                        tim.Stop();
                    }
                }
                else
                {
                    int step = new Random().Next(1, 25);
                    picture.Location = new Point(picture.Location.X + step, picture.Location.Y);
                }
            }
            
            if (winnerFox != null)
            {
                MessageBox.Show(string.Format("{0} is won the Race!!!", winnerFox.Name));
                SetupPunter();
                for ( index = 0; index < punters.Length; index++)
                {
                    if (punters[index].PunterBet != null)
                    {
                        string text = "";
                        int amount = punters[index].PunterBet.Amount;
                        if (punters[index].PunterBet.Fox == winnerFox)
                        {
                            punters[index].Amount += amount;
                            text = string.Format("{0} won the Race and Now, has ${1} Amount For Bet", punters[index].Name, punters[index].Amount);
                            punters[index].Winner = true;
                        }
                        else
                        {
                            punters[index].Amount -= amount;
                            if (punters[index].Amount == 0)
                            {
                                text = "Punter Lost all Amount So BUSTED";
                                punters[index].Busted = true;
                                punters[index].PunterRadioButton.Enabled = false;
                            }
                            else
                            {
                                text = string.Format("{0} Lost ${1} Amount in the Race and Now, has ${1} Amount in Hand", punters[index].Name, amount, punters[index].Amount);
                            }
                        }
                        punters[index].PunterTextBox.Text = text;
                    }
                }

                winnerFox = null;
                timers = null;
                int inactive = 0;
                for ( index = 0; index < punters.Length; index++)
                {
                    if (punters[index].Busted)
                    {
                        inactive++;
                    }
                    else
                    {
                        RadioButton radio = punters[index].PunterRadioButton;
                        if (radio.Enabled && radio.Checked)
                        {
                            lblMax.Text = string.Format("{0} Max Bet Amount Limit is ${1}", punters[index].Name, punters[index].Amount);
                            btnOperation.Text = string.Format("Place A BET For Player {0}", punters[index].Name);
                            lblBet.Text = string.Format("Bet Amount of {0} is $", punters[index].Name);
                            lblFox.Text = string.Format("{0} Place Bet on Fox No", punters[index].Name);
                            npBetAmount.Maximum = punters[index].Amount;
                            npBetAmount.Minimum = 1;
                        }
                    }
                    punters[index].PunterBet = null;
                    punters[index].Winner = false;
                }                
                if (inactive == punters.Length)
                {
                    MessageBox.Show("ALL PUNTER ARE BUSTED.... GAME OVER!!!!");
                    Application.Exit();
                }
                else
                {
                    panelBet.Enabled = true;
                    btnOperation.Enabled = true;                    
                    MessageBox.Show("Now You Capable To Place More Bet For Game...");
                    SetupPunter();
                }
                
                for ( index = 0; index < foxes.Length; index++)
                {
                    PictureBox picture = foxes[index].FoxPictureBox;
                    picture.Location = new Point(2, picture.Location.Y);
                }
            }
        }

        private void radio_changed(object sender, EventArgs e)
        {
            SetupPunter();
        }

        private void SetupPunter()
        {
            for (int index = 0; index < punters.Length; index++)
            {
                Punter punter = punters[index];
                string message = "";
                if (punter.Busted)
                {
                    message = "Player BUSTED. Lose All Amount in Game";
                }
                else
                {
                    if (punter.PunterBet == null)
                    {
                        message = string.Format("{0} hasn't placed a Bet", punter.Name);
                    }
                    else
                    {
                        message = string.Format("{0} placed Bet Amount ${1} on {2}", punter.Name, punter.PunterBet.Amount, punter.PunterBet.Fox.Name);
                    }
                    if (punter.PunterRadioButton.Checked)
                    {
                        lblMax.Text = string.Format("{0} Max Bet Amount Limit is ${1}", punter.Name, punter.Amount);
                        btnOperation.Text = string.Format("Place BET For Player {0}", punter.Name);
                        lblBet.Text = string.Format("Bet Amount of {0} is $", punter.Name);
                        lblFox.Text = string.Format("{0} Place Bet on Fox No", punter.Name);
                        npBetAmount.Minimum = 1;
                        npBetAmount.Maximum = punter.Amount;
                        npBetAmount.Value = 1;
                    }
                }
                punter.PunterTextBox.Text = message;
            }
        }
    }
}
