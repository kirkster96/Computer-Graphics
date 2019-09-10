namespace Julia_sets
{
    partial class juliaSetForm
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.playDefault = new System.Windows.Forms.Button();
            this.userCoeff = new System.Windows.Forms.Button();
            this.c0label = new System.Windows.Forms.Label();
            this.c1Label = new System.Windows.Forms.Label();
            this.c0UserValue = new System.Windows.Forms.TextBox();
            this.c1UserValue = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.Location = new System.Drawing.Point(575, 20);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(1187, 978);
            this.picCanvas.TabIndex = 0;
            this.picCanvas.TabStop = false;
            // 
            // playDefault
            // 
            this.playDefault.Location = new System.Drawing.Point(70, 20);
            this.playDefault.Name = "playDefault";
            this.playDefault.Size = new System.Drawing.Size(400, 120);
            this.playDefault.TabIndex = 1;
            this.playDefault.Text = "Play Default";
            this.playDefault.UseVisualStyleBackColor = true;
            this.playDefault.Click += new System.EventHandler(this.runDefaultValue);
            // 
            // userCoeff
            // 
            this.userCoeff.Location = new System.Drawing.Point(70, 160);
            this.userCoeff.Name = "userCoeff";
            this.userCoeff.Size = new System.Drawing.Size(400, 120);
            this.userCoeff.TabIndex = 2;
            this.userCoeff.Text = "User\'s Coefficients";
            this.userCoeff.UseVisualStyleBackColor = true;
            this.userCoeff.Click += new System.EventHandler(this.UserCoeff_Click);
            // 
            // c0label
            // 
            this.c0label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c0label.Location = new System.Drawing.Point(68, 301);
            this.c0label.Name = "c0label";
            this.c0label.Size = new System.Drawing.Size(148, 80);
            this.c0label.TabIndex = 3;
            this.c0label.Text = "c0";
            this.c0label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c1Label
            // 
            this.c1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1Label.Location = new System.Drawing.Point(68, 395);
            this.c1Label.Name = "c1Label";
            this.c1Label.Size = new System.Drawing.Size(148, 80);
            this.c1Label.TabIndex = 4;
            this.c1Label.Text = "c1";
            this.c1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // c0UserValue
            // 
            this.c0UserValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c0UserValue.Location = new System.Drawing.Point(182, 301);
            this.c0UserValue.Name = "c0UserValue";
            this.c0UserValue.Size = new System.Drawing.Size(288, 75);
            this.c0UserValue.TabIndex = 7;
            // 
            // c1UserValue
            // 
            this.c1UserValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1UserValue.Location = new System.Drawing.Point(182, 400);
            this.c1UserValue.Name = "c1UserValue";
            this.c1UserValue.Size = new System.Drawing.Size(288, 75);
            this.c1UserValue.TabIndex = 8;
            // 
            // juliaSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1806, 1010);
            this.Controls.Add(this.c1UserValue);
            this.Controls.Add(this.c0UserValue);
            this.Controls.Add(this.c1Label);
            this.Controls.Add(this.c0label);
            this.Controls.Add(this.userCoeff);
            this.Controls.Add(this.playDefault);
            this.Controls.Add(this.picCanvas);
            this.Name = "juliaSetForm";
            this.Text = "Julia Set";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button playDefault;
        private System.Windows.Forms.Button userCoeff;
        private System.Windows.Forms.Label c0label;
        private System.Windows.Forms.Label c1Label;
        private System.Windows.Forms.TextBox c0UserValue;
        private System.Windows.Forms.TextBox c1UserValue;
    }
}

