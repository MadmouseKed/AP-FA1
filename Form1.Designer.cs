
namespace FA1
{
    partial class FormBattleSim
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelCombatant1 = new System.Windows.Forms.Panel();
            this.c1SetButton = new System.Windows.Forms.Button();
            this.c1HpBox = new System.Windows.Forms.TextBox();
            this.c1HPTXT = new System.Windows.Forms.TextBox();
            this.c1HitModBox = new System.Windows.Forms.TextBox();
            this.c1DmgModBox = new System.Windows.Forms.TextBox();
            this.c1HitModTXT = new System.Windows.Forms.TextBox();
            this.c1DmgModTXT = new System.Windows.Forms.TextBox();
            this.c1DiceBox = new System.Windows.Forms.TextBox();
            this.c1ActionsBox = new System.Windows.Forms.TextBox();
            this.c1ACBox = new System.Windows.Forms.TextBox();
            this.c1DiceTXT = new System.Windows.Forms.TextBox();
            this.c1ActionsTXT = new System.Windows.Forms.TextBox();
            this.c1ACTXT = new System.Windows.Forms.TextBox();
            this.combatant1Name = new System.Windows.Forms.TextBox();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.rnTXT = new System.Windows.Forms.MaskedTextBox();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.rnNumberBox = new System.Windows.Forms.TextBox();
            this.panelCombatant2 = new System.Windows.Forms.Panel();
            this.c2SetButton = new System.Windows.Forms.Button();
            this.c2HpBox = new System.Windows.Forms.TextBox();
            this.combatant2Name = new System.Windows.Forms.TextBox();
            this.c2HPTXT = new System.Windows.Forms.TextBox();
            this.c2DiceBox = new System.Windows.Forms.TextBox();
            this.c2HitBox = new System.Windows.Forms.TextBox();
            this.c2ACTXT = new System.Windows.Forms.TextBox();
            this.c2DmgBox = new System.Windows.Forms.TextBox();
            this.c2ActionsTXT = new System.Windows.Forms.TextBox();
            this.c2HitTXT = new System.Windows.Forms.TextBox();
            this.c2DiceTXT = new System.Windows.Forms.TextBox();
            this.c2DmgTXT = new System.Windows.Forms.TextBox();
            this.c2ACBox = new System.Windows.Forms.TextBox();
            this.c2ActionsBox = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.beginButton = new System.Windows.Forms.Button();
            this.NextTurn = new System.Windows.Forms.Button();
            this.panelCombatant1.SuspendLayout();
            this.panelCentral.SuspendLayout();
            this.panelCombatant2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCombatant1
            // 
            this.panelCombatant1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCombatant1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCombatant1.Controls.Add(this.c1SetButton);
            this.panelCombatant1.Controls.Add(this.c1HpBox);
            this.panelCombatant1.Controls.Add(this.c1HPTXT);
            this.panelCombatant1.Controls.Add(this.c1HitModBox);
            this.panelCombatant1.Controls.Add(this.c1DmgModBox);
            this.panelCombatant1.Controls.Add(this.c1HitModTXT);
            this.panelCombatant1.Controls.Add(this.c1DmgModTXT);
            this.panelCombatant1.Controls.Add(this.c1DiceBox);
            this.panelCombatant1.Controls.Add(this.c1ActionsBox);
            this.panelCombatant1.Controls.Add(this.c1ACBox);
            this.panelCombatant1.Controls.Add(this.c1DiceTXT);
            this.panelCombatant1.Controls.Add(this.c1ActionsTXT);
            this.panelCombatant1.Controls.Add(this.c1ACTXT);
            this.panelCombatant1.Controls.Add(this.combatant1Name);
            this.panelCombatant1.Location = new System.Drawing.Point(12, 12);
            this.panelCombatant1.Name = "panelCombatant1";
            this.panelCombatant1.Size = new System.Drawing.Size(344, 585);
            this.panelCombatant1.TabIndex = 0;
            this.panelCombatant1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // c1SetButton
            // 
            this.c1SetButton.Location = new System.Drawing.Point(70, 328);
            this.c1SetButton.Name = "c1SetButton";
            this.c1SetButton.Size = new System.Drawing.Size(150, 46);
            this.c1SetButton.TabIndex = 13;
            this.c1SetButton.Text = "Set Combatant";
            this.c1SetButton.UseVisualStyleBackColor = true;
            this.c1SetButton.Click += new System.EventHandler(this.c1SetButton_Click);
            // 
            // c1HpBox
            // 
            this.c1HpBox.Location = new System.Drawing.Point(136, 103);
            this.c1HpBox.Name = "c1HpBox";
            this.c1HpBox.Size = new System.Drawing.Size(154, 39);
            this.c1HpBox.TabIndex = 12;
            this.c1HpBox.Text = "10";
            // 
            // c1HPTXT
            // 
            this.c1HPTXT.Location = new System.Drawing.Point(31, 103);
            this.c1HPTXT.Name = "c1HPTXT";
            this.c1HPTXT.ReadOnly = true;
            this.c1HPTXT.Size = new System.Drawing.Size(99, 39);
            this.c1HPTXT.TabIndex = 11;
            this.c1HPTXT.Text = "Hp:";
            // 
            // c1HitModBox
            // 
            this.c1HitModBox.Location = new System.Drawing.Point(136, 283);
            this.c1HitModBox.Name = "c1HitModBox";
            this.c1HitModBox.Size = new System.Drawing.Size(154, 39);
            this.c1HitModBox.TabIndex = 10;
            this.c1HitModBox.Text = "1";
            // 
            // c1DmgModBox
            // 
            this.c1DmgModBox.Location = new System.Drawing.Point(136, 238);
            this.c1DmgModBox.Name = "c1DmgModBox";
            this.c1DmgModBox.Size = new System.Drawing.Size(154, 39);
            this.c1DmgModBox.TabIndex = 9;
            this.c1DmgModBox.Text = "1";
            // 
            // c1HitModTXT
            // 
            this.c1HitModTXT.Location = new System.Drawing.Point(31, 283);
            this.c1HitModTXT.Name = "c1HitModTXT";
            this.c1HitModTXT.ReadOnly = true;
            this.c1HitModTXT.Size = new System.Drawing.Size(99, 39);
            this.c1HitModTXT.TabIndex = 8;
            this.c1HitModTXT.Text = "Hit +";
            // 
            // c1DmgModTXT
            // 
            this.c1DmgModTXT.Location = new System.Drawing.Point(31, 238);
            this.c1DmgModTXT.Name = "c1DmgModTXT";
            this.c1DmgModTXT.ReadOnly = true;
            this.c1DmgModTXT.Size = new System.Drawing.Size(99, 39);
            this.c1DmgModTXT.TabIndex = 7;
            this.c1DmgModTXT.Text = "Dmg +";
            // 
            // c1DiceBox
            // 
            this.c1DiceBox.Location = new System.Drawing.Point(136, 193);
            this.c1DiceBox.Name = "c1DiceBox";
            this.c1DiceBox.Size = new System.Drawing.Size(154, 39);
            this.c1DiceBox.TabIndex = 6;
            this.c1DiceBox.Text = "6";
            this.c1DiceBox.TextChanged += new System.EventHandler(this.c1DiceBox_TextChanged);
            // 
            // c1ActionsBox
            // 
            this.c1ActionsBox.Location = new System.Drawing.Point(136, 148);
            this.c1ActionsBox.Name = "c1ActionsBox";
            this.c1ActionsBox.Size = new System.Drawing.Size(154, 39);
            this.c1ActionsBox.TabIndex = 5;
            this.c1ActionsBox.Text = "1";
            // 
            // c1ACBox
            // 
            this.c1ACBox.Location = new System.Drawing.Point(136, 58);
            this.c1ACBox.Name = "c1ACBox";
            this.c1ACBox.Size = new System.Drawing.Size(154, 39);
            this.c1ACBox.TabIndex = 4;
            this.c1ACBox.Text = "10";
            this.c1ACBox.TextChanged += new System.EventHandler(this.c1ACBox_TextChanged);
            // 
            // c1DiceTXT
            // 
            this.c1DiceTXT.Location = new System.Drawing.Point(31, 193);
            this.c1DiceTXT.Name = "c1DiceTXT";
            this.c1DiceTXT.ReadOnly = true;
            this.c1DiceTXT.Size = new System.Drawing.Size(99, 39);
            this.c1DiceTXT.TabIndex = 3;
            this.c1DiceTXT.Text = "Dice:";
            // 
            // c1ActionsTXT
            // 
            this.c1ActionsTXT.Location = new System.Drawing.Point(31, 148);
            this.c1ActionsTXT.Name = "c1ActionsTXT";
            this.c1ActionsTXT.ReadOnly = true;
            this.c1ActionsTXT.Size = new System.Drawing.Size(99, 39);
            this.c1ActionsTXT.TabIndex = 2;
            this.c1ActionsTXT.Text = "Actions:";
            // 
            // c1ACTXT
            // 
            this.c1ACTXT.Location = new System.Drawing.Point(31, 58);
            this.c1ACTXT.Name = "c1ACTXT";
            this.c1ACTXT.ReadOnly = true;
            this.c1ACTXT.Size = new System.Drawing.Size(99, 39);
            this.c1ACTXT.TabIndex = 1;
            this.c1ACTXT.Text = "AC:";
            this.c1ACTXT.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // combatant1Name
            // 
            this.combatant1Name.Location = new System.Drawing.Point(14, 11);
            this.combatant1Name.Name = "combatant1Name";
            this.combatant1Name.Size = new System.Drawing.Size(312, 39);
            this.combatant1Name.TabIndex = 0;
            this.combatant1Name.Text = "Combatant 1";
            this.combatant1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.combatant1Name.TextChanged += new System.EventHandler(this.combatant1Name_TextChanged);
            // 
            // panelCentral
            // 
            this.panelCentral.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCentral.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCentral.Controls.Add(this.rnTXT);
            this.panelCentral.Controls.Add(this.ResultBox);
            this.panelCentral.Controls.Add(this.rnNumberBox);
            this.panelCentral.Location = new System.Drawing.Point(362, 180);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(228, 417);
            this.panelCentral.TabIndex = 1;
            // 
            // rnTXT
            // 
            this.rnTXT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rnTXT.Location = new System.Drawing.Point(9, 13);
            this.rnTXT.Name = "rnTXT";
            this.rnTXT.ReadOnly = true;
            this.rnTXT.Size = new System.Drawing.Size(88, 39);
            this.rnTXT.TabIndex = 1;
            this.rnTXT.Text = "Round:";
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(9, 58);
            this.ResultBox.Multiline = true;
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(200, 340);
            this.ResultBox.TabIndex = 3;
            this.ResultBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // rnNumberBox
            // 
            this.rnNumberBox.Location = new System.Drawing.Point(103, 13);
            this.rnNumberBox.Name = "rnNumberBox";
            this.rnNumberBox.ReadOnly = true;
            this.rnNumberBox.Size = new System.Drawing.Size(106, 39);
            this.rnNumberBox.TabIndex = 0;
            this.rnNumberBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panelCombatant2
            // 
            this.panelCombatant2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelCombatant2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelCombatant2.Controls.Add(this.c2SetButton);
            this.panelCombatant2.Controls.Add(this.c2HpBox);
            this.panelCombatant2.Controls.Add(this.combatant2Name);
            this.panelCombatant2.Controls.Add(this.c2HPTXT);
            this.panelCombatant2.Controls.Add(this.c2DiceBox);
            this.panelCombatant2.Controls.Add(this.c2HitBox);
            this.panelCombatant2.Controls.Add(this.c2ACTXT);
            this.panelCombatant2.Controls.Add(this.c2DmgBox);
            this.panelCombatant2.Controls.Add(this.c2ActionsTXT);
            this.panelCombatant2.Controls.Add(this.c2HitTXT);
            this.panelCombatant2.Controls.Add(this.c2DiceTXT);
            this.panelCombatant2.Controls.Add(this.c2DmgTXT);
            this.panelCombatant2.Controls.Add(this.c2ACBox);
            this.panelCombatant2.Controls.Add(this.c2ActionsBox);
            this.panelCombatant2.Location = new System.Drawing.Point(596, 12);
            this.panelCombatant2.Name = "panelCombatant2";
            this.panelCombatant2.Size = new System.Drawing.Size(366, 585);
            this.panelCombatant2.TabIndex = 2;
            this.panelCombatant2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // c2SetButton
            // 
            this.c2SetButton.Location = new System.Drawing.Point(95, 328);
            this.c2SetButton.Name = "c2SetButton";
            this.c2SetButton.Size = new System.Drawing.Size(150, 46);
            this.c2SetButton.TabIndex = 25;
            this.c2SetButton.Text = "Set Combatant";
            this.c2SetButton.UseVisualStyleBackColor = true;
            this.c2SetButton.Click += new System.EventHandler(this.c2SetButton_Click);
            // 
            // c2HpBox
            // 
            this.c2HpBox.Location = new System.Drawing.Point(166, 103);
            this.c2HpBox.Name = "c2HpBox";
            this.c2HpBox.Size = new System.Drawing.Size(154, 39);
            this.c2HpBox.TabIndex = 24;
            this.c2HpBox.Text = "10";
            // 
            // combatant2Name
            // 
            this.combatant2Name.Location = new System.Drawing.Point(17, 11);
            this.combatant2Name.Name = "combatant2Name";
            this.combatant2Name.Size = new System.Drawing.Size(328, 39);
            this.combatant2Name.TabIndex = 0;
            this.combatant2Name.Text = "Combatant2";
            this.combatant2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.combatant2Name.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // c2HPTXT
            // 
            this.c2HPTXT.Location = new System.Drawing.Point(61, 103);
            this.c2HPTXT.Name = "c2HPTXT";
            this.c2HPTXT.ReadOnly = true;
            this.c2HPTXT.Size = new System.Drawing.Size(99, 39);
            this.c2HPTXT.TabIndex = 23;
            this.c2HPTXT.Text = "Hp:";
            // 
            // c2DiceBox
            // 
            this.c2DiceBox.Location = new System.Drawing.Point(166, 193);
            this.c2DiceBox.Name = "c2DiceBox";
            this.c2DiceBox.Size = new System.Drawing.Size(154, 39);
            this.c2DiceBox.TabIndex = 18;
            this.c2DiceBox.Text = "6";
            // 
            // c2HitBox
            // 
            this.c2HitBox.Location = new System.Drawing.Point(166, 283);
            this.c2HitBox.Name = "c2HitBox";
            this.c2HitBox.Size = new System.Drawing.Size(154, 39);
            this.c2HitBox.TabIndex = 22;
            this.c2HitBox.Text = "1";
            // 
            // c2ACTXT
            // 
            this.c2ACTXT.Location = new System.Drawing.Point(61, 58);
            this.c2ACTXT.Name = "c2ACTXT";
            this.c2ACTXT.ReadOnly = true;
            this.c2ACTXT.Size = new System.Drawing.Size(99, 39);
            this.c2ACTXT.TabIndex = 13;
            this.c2ACTXT.Text = "AC:";
            // 
            // c2DmgBox
            // 
            this.c2DmgBox.Location = new System.Drawing.Point(166, 238);
            this.c2DmgBox.Name = "c2DmgBox";
            this.c2DmgBox.Size = new System.Drawing.Size(154, 39);
            this.c2DmgBox.TabIndex = 21;
            this.c2DmgBox.Text = "1";
            // 
            // c2ActionsTXT
            // 
            this.c2ActionsTXT.Location = new System.Drawing.Point(61, 148);
            this.c2ActionsTXT.Name = "c2ActionsTXT";
            this.c2ActionsTXT.ReadOnly = true;
            this.c2ActionsTXT.Size = new System.Drawing.Size(99, 39);
            this.c2ActionsTXT.TabIndex = 14;
            this.c2ActionsTXT.Text = "Actions:";
            // 
            // c2HitTXT
            // 
            this.c2HitTXT.Location = new System.Drawing.Point(61, 283);
            this.c2HitTXT.Name = "c2HitTXT";
            this.c2HitTXT.ReadOnly = true;
            this.c2HitTXT.Size = new System.Drawing.Size(99, 39);
            this.c2HitTXT.TabIndex = 20;
            this.c2HitTXT.Text = "Hit +";
            // 
            // c2DiceTXT
            // 
            this.c2DiceTXT.Location = new System.Drawing.Point(61, 193);
            this.c2DiceTXT.Name = "c2DiceTXT";
            this.c2DiceTXT.ReadOnly = true;
            this.c2DiceTXT.Size = new System.Drawing.Size(99, 39);
            this.c2DiceTXT.TabIndex = 15;
            this.c2DiceTXT.Text = "Dice:";
            // 
            // c2DmgTXT
            // 
            this.c2DmgTXT.Location = new System.Drawing.Point(61, 238);
            this.c2DmgTXT.Name = "c2DmgTXT";
            this.c2DmgTXT.ReadOnly = true;
            this.c2DmgTXT.Size = new System.Drawing.Size(99, 39);
            this.c2DmgTXT.TabIndex = 19;
            this.c2DmgTXT.Text = "Dmg +";
            // 
            // c2ACBox
            // 
            this.c2ACBox.Location = new System.Drawing.Point(166, 58);
            this.c2ACBox.Name = "c2ACBox";
            this.c2ACBox.Size = new System.Drawing.Size(154, 39);
            this.c2ACBox.TabIndex = 16;
            this.c2ACBox.Text = "10";
            // 
            // c2ActionsBox
            // 
            this.c2ActionsBox.Location = new System.Drawing.Point(166, 148);
            this.c2ActionsBox.Name = "c2ActionsBox";
            this.c2ActionsBox.Size = new System.Drawing.Size(154, 39);
            this.c2ActionsBox.TabIndex = 17;
            this.c2ActionsBox.Text = "1";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardInputEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // fontDialog1
            // 
            this.fontDialog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // beginButton
            // 
            this.beginButton.Location = new System.Drawing.Point(390, 48);
            this.beginButton.Name = "beginButton";
            this.beginButton.Size = new System.Drawing.Size(150, 46);
            this.beginButton.TabIndex = 2;
            this.beginButton.Text = "Begin";
            this.beginButton.UseVisualStyleBackColor = true;
            this.beginButton.Click += new System.EventHandler(this.beginButton_Click);
            // 
            // NextTurn
            // 
            this.NextTurn.Location = new System.Drawing.Point(390, 100);
            this.NextTurn.Name = "NextTurn";
            this.NextTurn.Size = new System.Drawing.Size(150, 46);
            this.NextTurn.TabIndex = 4;
            this.NextTurn.Text = "Next";
            this.NextTurn.UseVisualStyleBackColor = true;
            this.NextTurn.Click += new System.EventHandler(this.NextTurn_Click);
            // 
            // FormBattleSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(974, 609);
            this.Controls.Add(this.NextTurn);
            this.Controls.Add(this.beginButton);
            this.Controls.Add(this.panelCombatant2);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelCombatant1);
            this.Name = "FormBattleSim";
            this.Text = "Battle Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelCombatant1.ResumeLayout(false);
            this.panelCombatant1.PerformLayout();
            this.panelCentral.ResumeLayout(false);
            this.panelCentral.PerformLayout();
            this.panelCombatant2.ResumeLayout(false);
            this.panelCombatant2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCombatant1;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Panel panelCombatant2;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TextBox combatant1Name;
        private System.Windows.Forms.TextBox combatant2Name;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.TextBox rnNumberBox;
        private System.Windows.Forms.TextBox c1ACTXT;
        private System.Windows.Forms.MaskedTextBox rnTXT;
        private System.Windows.Forms.TextBox c1DiceBox;
        private System.Windows.Forms.TextBox c1ActionsBox;
        private System.Windows.Forms.TextBox c1ACBox;
        private System.Windows.Forms.TextBox c1DiceTXT;
        private System.Windows.Forms.TextBox c1ActionsTXT;
        private System.Windows.Forms.TextBox c1HitModBox;
        private System.Windows.Forms.TextBox c1DmgModBox;
        private System.Windows.Forms.TextBox c1HitModTXT;
        private System.Windows.Forms.TextBox c1DmgModTXT;
        private System.Windows.Forms.TextBox c1HpBox;
        private System.Windows.Forms.TextBox c1HPTXT;
        private System.Windows.Forms.TextBox c2HpBox;
        private System.Windows.Forms.TextBox c2HPTXT;
        private System.Windows.Forms.TextBox c2DiceBox;
        private System.Windows.Forms.TextBox c2HitBox;
        private System.Windows.Forms.TextBox c2ACTXT;
        private System.Windows.Forms.TextBox c2DmgBox;
        private System.Windows.Forms.TextBox c2ActionsTXT;
        private System.Windows.Forms.TextBox c2HitTXT;
        private System.Windows.Forms.TextBox c2DiceTXT;
        private System.Windows.Forms.TextBox c2DmgTXT;
        private System.Windows.Forms.TextBox c2ACBox;
        private System.Windows.Forms.TextBox c2ActionsBox;
        private System.Windows.Forms.Button beginButton;
        private System.Windows.Forms.Button NextTurn;
        private System.Windows.Forms.Button c1SetButton;
        private System.Windows.Forms.Button c2SetButton;
    }
}

