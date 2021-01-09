
namespace Facility_CW
{
    partial class Faciliot
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.AttachBtn = new System.Windows.Forms.Button();
            this.GodModeBtn = new System.Windows.Forms.Button();
            this.InstaKillBtn = new System.Windows.Forms.Button();
            this.SetCashBtn = new System.Windows.Forms.Button();
            this.SetSpeedBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AttachBtn
            // 
            this.AttachBtn.Location = new System.Drawing.Point(12, 12);
            this.AttachBtn.Name = "AttachBtn";
            this.AttachBtn.Size = new System.Drawing.Size(389, 23);
            this.AttachBtn.TabIndex = 0;
            this.AttachBtn.Text = "Attach to game";
            this.AttachBtn.UseVisualStyleBackColor = true;
            this.AttachBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // GodModeBtn
            // 
            this.GodModeBtn.Location = new System.Drawing.Point(12, 41);
            this.GodModeBtn.Name = "GodModeBtn";
            this.GodModeBtn.Size = new System.Drawing.Size(389, 23);
            this.GodModeBtn.TabIndex = 1;
            this.GodModeBtn.Text = "God Mode";
            this.GodModeBtn.UseVisualStyleBackColor = true;
            this.GodModeBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // InstaKillBtn
            // 
            this.InstaKillBtn.Location = new System.Drawing.Point(12, 194);
            this.InstaKillBtn.Name = "InstaKillBtn";
            this.InstaKillBtn.Size = new System.Drawing.Size(389, 23);
            this.InstaKillBtn.TabIndex = 2;
            this.InstaKillBtn.Text = "InstaKill";
            this.InstaKillBtn.UseVisualStyleBackColor = true;
            this.InstaKillBtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // SetCashBtn
            // 
            this.SetCashBtn.Location = new System.Drawing.Point(12, 70);
            this.SetCashBtn.Name = "SetCashBtn";
            this.SetCashBtn.Size = new System.Drawing.Size(389, 23);
            this.SetCashBtn.TabIndex = 3;
            this.SetCashBtn.Text = "Set Cash";
            this.SetCashBtn.UseVisualStyleBackColor = true;
            this.SetCashBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // SetSpeedBtn
            // 
            this.SetSpeedBtn.Location = new System.Drawing.Point(12, 99);
            this.SetSpeedBtn.Name = "SetSpeedBtn";
            this.SetSpeedBtn.Size = new System.Drawing.Size(389, 23);
            this.SetSpeedBtn.TabIndex = 4;
            this.SetSpeedBtn.Text = "Set Speed";
            this.SetSpeedBtn.UseVisualStyleBackColor = true;
            this.SetSpeedBtn.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 128);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(389, 60);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Log:";
            // 
            // Faciliot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 262);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SetSpeedBtn);
            this.Controls.Add(this.SetCashBtn);
            this.Controls.Add(this.InstaKillBtn);
            this.Controls.Add(this.GodModeBtn);
            this.Controls.Add(this.AttachBtn);
            this.Name = "Faciliot";
            this.Text = "Facility:CW";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AttachBtn;
        private System.Windows.Forms.Button GodModeBtn;
        private System.Windows.Forms.Button InstaKillBtn;
        private System.Windows.Forms.Button SetCashBtn;
        private System.Windows.Forms.Button SetSpeedBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

