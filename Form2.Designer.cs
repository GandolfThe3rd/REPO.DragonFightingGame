namespace Dragon_Fighting_Game
{
    partial class frmFight
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
            this.rtbBattleLog = new System.Windows.Forms.RichTextBox();
            this.grpChar1 = new System.Windows.Forms.GroupBox();
            this.btnBlock = new System.Windows.Forms.Button();
            this.btnSpecial = new System.Windows.Forms.Button();
            this.lblHp1 = new System.Windows.Forms.Label();
            this.btnAttack = new System.Windows.Forms.Button();
            this.grpOpponent = new System.Windows.Forms.GroupBox();
            this.lblHp2 = new System.Windows.Forms.Label();
            this.lblSecondPlayer = new System.Windows.Forms.Label();
            this.grpLog = new System.Windows.Forms.GroupBox();
            this.btnRest = new System.Windows.Forms.Button();
            this.grpChar1.SuspendLayout();
            this.grpOpponent.SuspendLayout();
            this.grpLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbBattleLog
            // 
            this.rtbBattleLog.Location = new System.Drawing.Point(6, 21);
            this.rtbBattleLog.Name = "rtbBattleLog";
            this.rtbBattleLog.Size = new System.Drawing.Size(544, 138);
            this.rtbBattleLog.TabIndex = 0;
            this.rtbBattleLog.Text = "Battle Log Text Goes Here";
            // 
            // grpChar1
            // 
            this.grpChar1.BackColor = System.Drawing.Color.Transparent;
            this.grpChar1.Controls.Add(this.btnRest);
            this.grpChar1.Controls.Add(this.btnBlock);
            this.grpChar1.Controls.Add(this.btnSpecial);
            this.grpChar1.Controls.Add(this.lblHp1);
            this.grpChar1.Controls.Add(this.btnAttack);
            this.grpChar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpChar1.Location = new System.Drawing.Point(12, 12);
            this.grpChar1.Name = "grpChar1";
            this.grpChar1.Size = new System.Drawing.Size(242, 323);
            this.grpChar1.TabIndex = 1;
            this.grpChar1.TabStop = false;
            this.grpChar1.Text = "X, The Y Dragon\'s Turn";
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBlock.Location = new System.Drawing.Point(6, 251);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(230, 65);
            this.btnBlock.TabIndex = 4;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // btnSpecial
            // 
            this.btnSpecial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSpecial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSpecial.Location = new System.Drawing.Point(6, 180);
            this.btnSpecial.Name = "btnSpecial";
            this.btnSpecial.Size = new System.Drawing.Size(230, 65);
            this.btnSpecial.TabIndex = 3;
            this.btnSpecial.Text = "Special Attack";
            this.btnSpecial.UseVisualStyleBackColor = true;
            // 
            // lblHp1
            // 
            this.lblHp1.AutoSize = true;
            this.lblHp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHp1.Location = new System.Drawing.Point(57, 44);
            this.lblHp1.Name = "lblHp1";
            this.lblHp1.Size = new System.Drawing.Size(123, 38);
            this.lblHp1.TabIndex = 2;
            this.lblHp1.Text = "HP: 99";
            // 
            // btnAttack
            // 
            this.btnAttack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAttack.Location = new System.Drawing.Point(6, 109);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(230, 65);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            // 
            // grpOpponent
            // 
            this.grpOpponent.BackColor = System.Drawing.Color.Transparent;
            this.grpOpponent.Controls.Add(this.lblHp2);
            this.grpOpponent.Controls.Add(this.lblSecondPlayer);
            this.grpOpponent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpOpponent.Location = new System.Drawing.Point(277, 133);
            this.grpOpponent.Name = "grpOpponent";
            this.grpOpponent.Size = new System.Drawing.Size(291, 111);
            this.grpOpponent.TabIndex = 2;
            this.grpOpponent.TabStop = false;
            this.grpOpponent.Text = "Opponent: Name";
            // 
            // lblHp2
            // 
            this.lblHp2.AutoSize = true;
            this.lblHp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHp2.Location = new System.Drawing.Point(79, 63);
            this.lblHp2.Name = "lblHp2";
            this.lblHp2.Size = new System.Drawing.Size(123, 38);
            this.lblHp2.TabIndex = 5;
            this.lblHp2.Text = "HP: 99";
            // 
            // lblSecondPlayer
            // 
            this.lblSecondPlayer.AutoSize = true;
            this.lblSecondPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondPlayer.Location = new System.Drawing.Point(6, 18);
            this.lblSecondPlayer.Name = "lblSecondPlayer";
            this.lblSecondPlayer.Size = new System.Drawing.Size(275, 38);
            this.lblSecondPlayer.TabIndex = 5;
            this.lblSecondPlayer.Text = "X, The Y Dragon\r\n";
            // 
            // grpLog
            // 
            this.grpLog.BackColor = System.Drawing.Color.Transparent;
            this.grpLog.Controls.Add(this.rtbBattleLog);
            this.grpLog.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpLog.Location = new System.Drawing.Point(12, 341);
            this.grpLog.Name = "grpLog";
            this.grpLog.Size = new System.Drawing.Size(556, 165);
            this.grpLog.TabIndex = 3;
            this.grpLog.TabStop = false;
            this.grpLog.Text = "Battle Log";
            // 
            // btnRest
            // 
            this.btnRest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRest.Location = new System.Drawing.Point(6, 109);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(230, 207);
            this.btnRest.TabIndex = 5;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            // 
            // frmFight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Dragon_Fighting_Game.Properties.Resources._240966688_4763613430356384_2946048999633840585_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(580, 518);
            this.Controls.Add(this.grpLog);
            this.Controls.Add(this.grpOpponent);
            this.Controls.Add(this.grpChar1);
            this.Name = "frmFight";
            this.Text = "Fight";
            this.grpChar1.ResumeLayout(false);
            this.grpChar1.PerformLayout();
            this.grpOpponent.ResumeLayout(false);
            this.grpOpponent.PerformLayout();
            this.grpLog.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbBattleLog;
        private System.Windows.Forms.GroupBox grpChar1;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Label lblHp1;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Button btnSpecial;
        private System.Windows.Forms.GroupBox grpOpponent;
        private System.Windows.Forms.Label lblSecondPlayer;
        private System.Windows.Forms.Label lblHp2;
        private System.Windows.Forms.GroupBox grpLog;
        private System.Windows.Forms.Button btnRest;
    }
}