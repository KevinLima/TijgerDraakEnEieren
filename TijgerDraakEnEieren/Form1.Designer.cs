namespace TijgerDraakEnEieren
{
    partial class Form1
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
                components.Dispose( );
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.label1 = new System.Windows.Forms.Label();
            this.AI_Knop = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.huidgeSpelerBox = new System.Windows.Forms.PictureBox();
            this.v6 = new System.Windows.Forms.PictureBox();
            this.v7 = new System.Windows.Forms.PictureBox();
            this.v8 = new System.Windows.Forms.PictureBox();
            this.v3 = new System.Windows.Forms.PictureBox();
            this.v4 = new System.Windows.Forms.PictureBox();
            this.v5 = new System.Windows.Forms.PictureBox();
            this.v0 = new System.Windows.Forms.PictureBox();
            this.v1 = new System.Windows.Forms.PictureBox();
            this.v2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.huidgeSpelerBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Huidige Speler";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // AI_Knop
            // 
            this.AI_Knop.BackColor = System.Drawing.SystemColors.Control;
            this.AI_Knop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AI_Knop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AI_Knop.Location = new System.Drawing.Point(12, 364);
            this.AI_Knop.Name = "AI_Knop";
            this.AI_Knop.Size = new System.Drawing.Size(123, 29);
            this.AI_Knop.TabIndex = 1;
            this.AI_Knop.Text = "AI";
            this.AI_Knop.UseVisualStyleBackColor = false;
            this.AI_Knop.Click += new System.EventHandler(this.speelTegenDeComputer);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Control;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.ResetKnop);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(382, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Copyright © 2014 Kevin Lima";
            // 
            // huidgeSpelerBox
            // 
            this.huidgeSpelerBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.huidgeSpelerBox.Image = global::TijgerDraakEnEieren.Properties.Resources.blackdragon;
            this.huidgeSpelerBox.Location = new System.Drawing.Point(23, 38);
            this.huidgeSpelerBox.Name = "huidgeSpelerBox";
            this.huidgeSpelerBox.Size = new System.Drawing.Size(100, 100);
            this.huidgeSpelerBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.huidgeSpelerBox.TabIndex = 13;
            this.huidgeSpelerBox.TabStop = false;
            // 
            // v6
            // 
            this.v6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v6.Location = new System.Drawing.Point(175, 290);
            this.v6.Name = "v6";
            this.v6.Size = new System.Drawing.Size(120, 120);
            this.v6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v6.TabIndex = 12;
            this.v6.TabStop = false;
            this.v6.Tag = "6";
            this.v6.Click += new System.EventHandler(this.UserKlik);
            // 
            // v7
            // 
            this.v7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v7.Location = new System.Drawing.Point(301, 290);
            this.v7.Name = "v7";
            this.v7.Size = new System.Drawing.Size(120, 120);
            this.v7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v7.TabIndex = 11;
            this.v7.TabStop = false;
            this.v7.Tag = "7";
            this.v7.Click += new System.EventHandler(this.UserKlik);
            // 
            // v8
            // 
            this.v8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v8.Location = new System.Drawing.Point(427, 290);
            this.v8.Name = "v8";
            this.v8.Size = new System.Drawing.Size(120, 120);
            this.v8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v8.TabIndex = 10;
            this.v8.TabStop = false;
            this.v8.Tag = "8";
            this.v8.Click += new System.EventHandler(this.UserKlik);
            // 
            // v3
            // 
            this.v3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v3.Location = new System.Drawing.Point(175, 164);
            this.v3.Name = "v3";
            this.v3.Size = new System.Drawing.Size(120, 120);
            this.v3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v3.TabIndex = 9;
            this.v3.TabStop = false;
            this.v3.Tag = "3";
            this.v3.Click += new System.EventHandler(this.UserKlik);
            // 
            // v4
            // 
            this.v4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v4.Location = new System.Drawing.Point(301, 164);
            this.v4.Name = "v4";
            this.v4.Size = new System.Drawing.Size(120, 120);
            this.v4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v4.TabIndex = 8;
            this.v4.TabStop = false;
            this.v4.Tag = "4";
            this.v4.Click += new System.EventHandler(this.UserKlik);
            // 
            // v5
            // 
            this.v5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v5.Location = new System.Drawing.Point(427, 164);
            this.v5.Name = "v5";
            this.v5.Size = new System.Drawing.Size(120, 120);
            this.v5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v5.TabIndex = 7;
            this.v5.TabStop = false;
            this.v5.Tag = "5";
            this.v5.Click += new System.EventHandler(this.UserKlik);
            // 
            // v0
            // 
            this.v0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v0.Location = new System.Drawing.Point(175, 38);
            this.v0.Name = "v0";
            this.v0.Size = new System.Drawing.Size(120, 120);
            this.v0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v0.TabIndex = 6;
            this.v0.TabStop = false;
            this.v0.Tag = "0";
            this.v0.Click += new System.EventHandler(this.UserKlik);
            // 
            // v1
            // 
            this.v1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v1.Location = new System.Drawing.Point(301, 38);
            this.v1.Name = "v1";
            this.v1.Size = new System.Drawing.Size(120, 120);
            this.v1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v1.TabIndex = 5;
            this.v1.TabStop = false;
            this.v1.Tag = "1";
            this.v1.Click += new System.EventHandler(this.UserKlik);
            // 
            // v2
            // 
            this.v2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.v2.Location = new System.Drawing.Point(427, 38);
            this.v2.Name = "v2";
            this.v2.Size = new System.Drawing.Size(120, 120);
            this.v2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.v2.TabIndex = 4;
            this.v2.TabStop = false;
            this.v2.Tag = "2";
            this.v2.Click += new System.EventHandler(this.UserKlik);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 440);
            this.Controls.Add(this.huidgeSpelerBox);
            this.Controls.Add(this.v6);
            this.Controls.Add(this.v7);
            this.Controls.Add(this.v8);
            this.Controls.Add(this.v3);
            this.Controls.Add(this.v4);
            this.Controls.Add(this.v5);
            this.Controls.Add(this.v0);
            this.Controls.Add(this.v1);
            this.Controls.Add(this.v2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AI_Knop);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Tijger Draak en Eieren";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.huidgeSpelerBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.v2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AI_Knop;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox v2;
        private System.Windows.Forms.PictureBox v1;
        private System.Windows.Forms.PictureBox v0;
        private System.Windows.Forms.PictureBox v5;
        private System.Windows.Forms.PictureBox v4;
        private System.Windows.Forms.PictureBox v3;
        private System.Windows.Forms.PictureBox v8;
        private System.Windows.Forms.PictureBox v7;
        private System.Windows.Forms.PictureBox v6;
        private System.Windows.Forms.PictureBox huidgeSpelerBox;
    }
}

