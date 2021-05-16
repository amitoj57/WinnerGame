
namespace WinnerGame
{
    partial class GameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.picture4 = new System.Windows.Forms.PictureBox();
            this.picture3 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.picture1 = new System.Windows.Forms.PictureBox();
            this.panelBet = new System.Windows.Forms.Panel();
            this.npFoxNo = new System.Windows.Forms.NumericUpDown();
            this.npBetAmount = new System.Windows.Forms.NumericUpDown();
            this.lblFox = new System.Windows.Forms.Label();
            this.lblBet = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.text3 = new System.Windows.Forms.TextBox();
            this.text2 = new System.Windows.Forms.TextBox();
            this.text1 = new System.Windows.Forms.TextBox();
            this.radio3 = new System.Windows.Forms.RadioButton();
            this.radio2 = new System.Windows.Forms.RadioButton();
            this.radio1 = new System.Windows.Forms.RadioButton();
            this.btnOperation = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).BeginInit();
            this.panelBet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npFoxNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.npBetAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.picture4);
            this.panel1.Controls.Add(this.picture3);
            this.panel1.Controls.Add(this.picture2);
            this.panel1.Controls.Add(this.picture1);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 309);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::WinnerGame.Properties.Resources.line;
            this.pictureBox6.Location = new System.Drawing.Point(109, -2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(10, 307);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::WinnerGame.Properties.Resources.line;
            this.pictureBox5.Location = new System.Drawing.Point(1019, 3);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(41, 307);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // picture4
            // 
            this.picture4.Image = global::WinnerGame.Properties.Resources.fox4;
            this.picture4.Location = new System.Drawing.Point(3, 246);
            this.picture4.Name = "picture4";
            this.picture4.Size = new System.Drawing.Size(100, 50);
            this.picture4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture4.TabIndex = 3;
            this.picture4.TabStop = false;
            // 
            // picture3
            // 
            this.picture3.Image = global::WinnerGame.Properties.Resources.fox3;
            this.picture3.Location = new System.Drawing.Point(3, 165);
            this.picture3.Name = "picture3";
            this.picture3.Size = new System.Drawing.Size(100, 50);
            this.picture3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture3.TabIndex = 2;
            this.picture3.TabStop = false;
            // 
            // picture2
            // 
            this.picture2.Image = global::WinnerGame.Properties.Resources.fox2;
            this.picture2.Location = new System.Drawing.Point(3, 84);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(100, 50);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 1;
            this.picture2.TabStop = false;
            // 
            // picture1
            // 
            this.picture1.Image = global::WinnerGame.Properties.Resources.fox1;
            this.picture1.Location = new System.Drawing.Point(3, 3);
            this.picture1.Name = "picture1";
            this.picture1.Size = new System.Drawing.Size(100, 50);
            this.picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture1.TabIndex = 0;
            this.picture1.TabStop = false;
            // 
            // panelBet
            // 
            this.panelBet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBet.Controls.Add(this.npFoxNo);
            this.panelBet.Controls.Add(this.npBetAmount);
            this.panelBet.Controls.Add(this.lblFox);
            this.panelBet.Controls.Add(this.lblBet);
            this.panelBet.Controls.Add(this.lblMax);
            this.panelBet.Controls.Add(this.text3);
            this.panelBet.Controls.Add(this.text2);
            this.panelBet.Controls.Add(this.text1);
            this.panelBet.Controls.Add(this.radio3);
            this.panelBet.Controls.Add(this.radio2);
            this.panelBet.Controls.Add(this.radio1);
            this.panelBet.Location = new System.Drawing.Point(12, 3);
            this.panelBet.Name = "panelBet";
            this.panelBet.Size = new System.Drawing.Size(1043, 307);
            this.panelBet.TabIndex = 2;
            // 
            // npFoxNo
            // 
            this.npFoxNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npFoxNo.Location = new System.Drawing.Point(867, 252);
            this.npFoxNo.Name = "npFoxNo";
            this.npFoxNo.Size = new System.Drawing.Size(120, 34);
            this.npFoxNo.TabIndex = 10;
            // 
            // npBetAmount
            // 
            this.npBetAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.npBetAmount.Location = new System.Drawing.Point(867, 187);
            this.npBetAmount.Name = "npBetAmount";
            this.npBetAmount.Size = new System.Drawing.Size(120, 34);
            this.npBetAmount.TabIndex = 9;
            // 
            // lblFox
            // 
            this.lblFox.AutoSize = true;
            this.lblFox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFox.Location = new System.Drawing.Point(453, 257);
            this.lblFox.Name = "lblFox";
            this.lblFox.Size = new System.Drawing.Size(282, 29);
            this.lblFox.TabIndex = 8;
            this.lblFox.Text = "AI Place Bet on Fox No";
            // 
            // lblBet
            // 
            this.lblBet.AutoSize = true;
            this.lblBet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBet.Location = new System.Drawing.Point(453, 192);
            this.lblBet.Name = "lblBet";
            this.lblBet.Size = new System.Drawing.Size(299, 29);
            this.lblBet.TabIndex = 7;
            this.lblBet.Text = "AI Place Bet of Amount $";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMax.Location = new System.Drawing.Point(17, 225);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(276, 29);
            this.lblMax.TabIndex = 6;
            this.lblMax.Text = "Max Amount Bet is $50";
            // 
            // text3
            // 
            this.text3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text3.Location = new System.Drawing.Point(150, 142);
            this.text3.Name = "text3";
            this.text3.Size = new System.Drawing.Size(837, 34);
            this.text3.TabIndex = 5;
            this.text3.Text = "BOB hasn\'t placed a bet";
            // 
            // text2
            // 
            this.text2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text2.Location = new System.Drawing.Point(150, 82);
            this.text2.Name = "text2";
            this.text2.Size = new System.Drawing.Size(837, 34);
            this.text2.TabIndex = 4;
            this.text2.Text = "JOE hasn\'t placed a bet";
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text1.Location = new System.Drawing.Point(150, 25);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(837, 34);
            this.text1.TabIndex = 3;
            this.text1.Text = "AI hasn\'t placed a bet";
            // 
            // radio3
            // 
            this.radio3.AutoSize = true;
            this.radio3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio3.Location = new System.Drawing.Point(22, 147);
            this.radio3.Name = "radio3";
            this.radio3.Size = new System.Drawing.Size(75, 29);
            this.radio3.TabIndex = 2;
            this.radio3.TabStop = true;
            this.radio3.Text = "BOB";
            this.radio3.UseVisualStyleBackColor = true;
            this.radio3.CheckedChanged += new System.EventHandler(this.radio_changed);
            // 
            // radio2
            // 
            this.radio2.AutoSize = true;
            this.radio2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio2.Location = new System.Drawing.Point(22, 87);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(73, 29);
            this.radio2.TabIndex = 1;
            this.radio2.TabStop = true;
            this.radio2.Text = "JOE";
            this.radio2.UseVisualStyleBackColor = true;
            this.radio2.CheckedChanged += new System.EventHandler(this.radio_changed);
            // 
            // radio1
            // 
            this.radio1.AutoSize = true;
            this.radio1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio1.Location = new System.Drawing.Point(22, 30);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(52, 29);
            this.radio1.TabIndex = 0;
            this.radio1.TabStop = true;
            this.radio1.Text = "AI";
            this.radio1.UseVisualStyleBackColor = true;
            this.radio1.CheckedChanged += new System.EventHandler(this.radio_changed);
            // 
            // btnOperation
            // 
            this.btnOperation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOperation.Location = new System.Drawing.Point(251, 333);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(515, 73);
            this.btnOperation.TabIndex = 3;
            this.btnOperation.Text = "Place A BET";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 736);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.panelBet);
            this.Controls.Add(this.panel1);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play & Win Game";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture1)).EndInit();
            this.panelBet.ResumeLayout(false);
            this.panelBet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.npFoxNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.npBetAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox picture4;
        private System.Windows.Forms.PictureBox picture3;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.PictureBox picture1;
        private System.Windows.Forms.Panel panelBet;
        private System.Windows.Forms.NumericUpDown npFoxNo;
        private System.Windows.Forms.NumericUpDown npBetAmount;
        private System.Windows.Forms.Label lblFox;
        private System.Windows.Forms.Label lblBet;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.TextBox text3;
        private System.Windows.Forms.TextBox text2;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.RadioButton radio3;
        private System.Windows.Forms.RadioButton radio2;
        private System.Windows.Forms.RadioButton radio1;
        private System.Windows.Forms.Button btnOperation;
    }
}

