
namespace Engenhos.Exercicio2
{
    partial class Aplicativo
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
            this.components = new System.ComponentModel.Container();
            this.FlashlightImg = new System.Windows.Forms.Panel();
            this.OnOffBt = new System.Windows.Forms.Button();
            this.BatChangeBt = new System.Windows.Forms.Button();
            this.OnOffBtStatus = new System.Windows.Forms.Label();
            this.BatteryStatus = new System.Windows.Forms.Label();
            this.FlashlightStatus = new System.Windows.Forms.Label();
            this.BatTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FlashlightImg
            // 
            this.FlashlightImg.BackgroundImage = global::Engenhos.Exercicio2.Properties.Resources.FlashlightOff;
            this.FlashlightImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlashlightImg.Location = new System.Drawing.Point(12, 12);
            this.FlashlightImg.Name = "FlashlightImg";
            this.FlashlightImg.Size = new System.Drawing.Size(250, 250);
            this.FlashlightImg.TabIndex = 0;
            // 
            // OnOffBt
            // 
            this.OnOffBt.Location = new System.Drawing.Point(12, 311);
            this.OnOffBt.Name = "OnOffBt";
            this.OnOffBt.Size = new System.Drawing.Size(122, 23);
            this.OnOffBt.TabIndex = 1;
            this.OnOffBt.Text = "button1";
            this.OnOffBt.UseVisualStyleBackColor = true;
            this.OnOffBt.Click += new System.EventHandler(this.OnOffBt_Click);
            // 
            // BatChangeBt
            // 
            this.BatChangeBt.Location = new System.Drawing.Point(12, 340);
            this.BatChangeBt.Name = "BatChangeBt";
            this.BatChangeBt.Size = new System.Drawing.Size(122, 23);
            this.BatChangeBt.TabIndex = 2;
            this.BatChangeBt.Text = "button2";
            this.BatChangeBt.UseVisualStyleBackColor = true;
            this.BatChangeBt.Click += new System.EventHandler(this.BatChangeBt_Click);
            // 
            // OnOffBtStatus
            // 
            this.OnOffBtStatus.AutoSize = true;
            this.OnOffBtStatus.Location = new System.Drawing.Point(140, 315);
            this.OnOffBtStatus.Name = "OnOffBtStatus";
            this.OnOffBtStatus.Size = new System.Drawing.Size(38, 15);
            this.OnOffBtStatus.TabIndex = 3;
            this.OnOffBtStatus.Text = "label1";
            // 
            // BatteryStatus
            // 
            this.BatteryStatus.AutoSize = true;
            this.BatteryStatus.Location = new System.Drawing.Point(140, 344);
            this.BatteryStatus.Name = "BatteryStatus";
            this.BatteryStatus.Size = new System.Drawing.Size(38, 15);
            this.BatteryStatus.TabIndex = 4;
            this.BatteryStatus.Text = "label2";
            // 
            // FlashlightStatus
            // 
            this.FlashlightStatus.AutoSize = true;
            this.FlashlightStatus.Location = new System.Drawing.Point(12, 280);
            this.FlashlightStatus.Name = "FlashlightStatus";
            this.FlashlightStatus.Size = new System.Drawing.Size(38, 15);
            this.FlashlightStatus.TabIndex = 5;
            this.FlashlightStatus.Text = "label3";
            // 
            // BatTimer
            // 
            this.BatTimer.Interval = 1000;
            this.BatTimer.Tick += new System.EventHandler(this.BatTimer_Tick);
            // 
            // Aplicativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 376);
            this.Controls.Add(this.FlashlightStatus);
            this.Controls.Add(this.BatteryStatus);
            this.Controls.Add(this.OnOffBtStatus);
            this.Controls.Add(this.BatChangeBt);
            this.Controls.Add(this.OnOffBt);
            this.Controls.Add(this.FlashlightImg);
            this.Name = "Aplicativo";
            this.Text = "Lanterna";
            this.Load += new System.EventHandler(this.Aplicativo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel FlashlightImg;
        private System.Windows.Forms.Button OnOffBt;
        private System.Windows.Forms.Button BatChangeBt;
        private System.Windows.Forms.Label OnOffBtStatus;
        private System.Windows.Forms.Label BatteryStatus;
        private System.Windows.Forms.Label FlashlightStatus;
        private System.Windows.Forms.Timer BatTimer;
    }
}

