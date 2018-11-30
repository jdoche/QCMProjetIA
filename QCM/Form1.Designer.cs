namespace QCM
{
    partial class Form1
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
            this.tbQuestion = new System.Windows.Forms.TextBox();
            this.cbA = new System.Windows.Forms.CheckBox();
            this.cbB = new System.Windows.Forms.CheckBox();
            this.cbC = new System.Windows.Forms.CheckBox();
            this.cbD = new System.Windows.Forms.CheckBox();
            this.bValider = new System.Windows.Forms.Button();
            this.pbOk = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).BeginInit();
            this.SuspendLayout();
            // 
            // tbQuestion
            // 
            this.tbQuestion.Location = new System.Drawing.Point(41, 94);
            this.tbQuestion.Name = "tbQuestion";
            this.tbQuestion.Size = new System.Drawing.Size(567, 20);
            this.tbQuestion.TabIndex = 0;
            this.tbQuestion.TextChanged += new System.EventHandler(this.tbQuestion_TextChanged);
            // 
            // cbA
            // 
            this.cbA.AutoSize = true;
            this.cbA.Location = new System.Drawing.Point(41, 192);
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(45, 17);
            this.cbA.TabIndex = 1;
            this.cbA.Text = "cbA";
            this.cbA.UseVisualStyleBackColor = true;
            this.cbA.CheckedChanged += new System.EventHandler(this.cbA_CheckedChanged);
            // 
            // cbB
            // 
            this.cbB.AutoSize = true;
            this.cbB.Location = new System.Drawing.Point(41, 252);
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(45, 17);
            this.cbB.TabIndex = 2;
            this.cbB.Text = "cbB";
            this.cbB.UseVisualStyleBackColor = true;
            this.cbB.CheckedChanged += new System.EventHandler(this.cbB_CheckedChanged);
            // 
            // cbC
            // 
            this.cbC.AutoSize = true;
            this.cbC.Location = new System.Drawing.Point(41, 312);
            this.cbC.Name = "cbC";
            this.cbC.Size = new System.Drawing.Size(45, 17);
            this.cbC.TabIndex = 3;
            this.cbC.Text = "cbC";
            this.cbC.UseVisualStyleBackColor = true;
            this.cbC.CheckedChanged += new System.EventHandler(this.cbC_CheckedChanged);
            // 
            // cbD
            // 
            this.cbD.AutoSize = true;
            this.cbD.Location = new System.Drawing.Point(41, 365);
            this.cbD.Name = "cbD";
            this.cbD.Size = new System.Drawing.Size(46, 17);
            this.cbD.TabIndex = 4;
            this.cbD.Text = "cbD";
            this.cbD.UseVisualStyleBackColor = true;
            this.cbD.CheckedChanged += new System.EventHandler(this.cbD_CheckedChanged);
            // 
            // bValider
            // 
            this.bValider.Location = new System.Drawing.Point(272, 426);
            this.bValider.Name = "bValider";
            this.bValider.Size = new System.Drawing.Size(75, 23);
            this.bValider.TabIndex = 5;
            this.bValider.Text = "Valider";
            this.bValider.UseVisualStyleBackColor = true;
            this.bValider.Click += new System.EventHandler(this.bValider_Click);
            // 
            // pbOk
            // 
            this.pbOk.Image = global::QCM.Properties.Resources.checked1;
            this.pbOk.Location = new System.Drawing.Point(260, 243);
            this.pbOk.Name = "pbOk";
            this.pbOk.Size = new System.Drawing.Size(52, 55);
            this.pbOk.TabIndex = 6;
            this.pbOk.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 495);
            this.Controls.Add(this.pbOk);
            this.Controls.Add(this.bValider);
            this.Controls.Add(this.cbD);
            this.Controls.Add(this.cbC);
            this.Controls.Add(this.cbB);
            this.Controls.Add(this.cbA);
            this.Controls.Add(this.tbQuestion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbOk)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbQuestion;
        private System.Windows.Forms.CheckBox cbA;
        private System.Windows.Forms.CheckBox cbB;
        private System.Windows.Forms.CheckBox cbC;
        private System.Windows.Forms.CheckBox cbD;
        private System.Windows.Forms.Button bValider;
        private System.Windows.Forms.PictureBox pbOk;
    }
}

