namespace reflexTrainer
{
    partial class settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(settings));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reading = new System.Windows.Forms.CheckBox();
            this.tone = new System.Windows.Forms.CheckBox();
            this.save = new System.Windows.Forms.Button();
            this.unmute = new System.Windows.Forms.Button();
            this.mute = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reading);
            this.groupBox1.Controls.Add(this.tone);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(151, 68);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dźwięk";
            // 
            // reading
            // 
            this.reading.AutoSize = true;
            this.reading.Location = new System.Drawing.Point(6, 42);
            this.reading.Name = "reading";
            this.reading.Size = new System.Drawing.Size(105, 17);
            this.reading.TabIndex = 6;
            this.reading.Text = "Wyłącz czytanie";
            this.reading.UseVisualStyleBackColor = true;
            this.reading.CheckedChanged += new System.EventHandler(this.reading_CheckedChanged);
            // 
            // tone
            // 
            this.tone.AutoSize = true;
            this.tone.Location = new System.Drawing.Point(6, 19);
            this.tone.Name = "tone";
            this.tone.Size = new System.Drawing.Size(98, 17);
            this.tone.TabIndex = 5;
            this.tone.Text = "Wycisz dźwięki";
            this.tone.UseVisualStyleBackColor = true;
            this.tone.CheckedChanged += new System.EventHandler(this.tone_CheckedChanged);
            // 
            // save
            // 
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(178, 86);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(104, 32);
            this.save.TabIndex = 1;
            this.save.Text = "Zapisz";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // unmute
            // 
            this.unmute.Location = new System.Drawing.Point(178, 12);
            this.unmute.Name = "unmute";
            this.unmute.Size = new System.Drawing.Size(104, 30);
            this.unmute.TabIndex = 2;
            this.unmute.Text = "Włącz dźwięk";
            this.unmute.UseVisualStyleBackColor = true;
            this.unmute.Click += new System.EventHandler(this.unmute_Click);
            // 
            // mute
            // 
            this.mute.Location = new System.Drawing.Point(178, 48);
            this.mute.Name = "mute";
            this.mute.Size = new System.Drawing.Size(104, 32);
            this.mute.TabIndex = 3;
            this.mute.Text = "Wyłącz dźwięk";
            this.mute.UseVisualStyleBackColor = true;
            this.mute.Click += new System.EventHandler(this.mute_Click);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 130);
            this.Controls.Add(this.mute);
            this.Controls.Add(this.unmute);
            this.Controls.Add(this.save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ustawienia";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox tone;
        private System.Windows.Forms.CheckBox reading;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button unmute;
        private System.Windows.Forms.Button mute;
    }
}