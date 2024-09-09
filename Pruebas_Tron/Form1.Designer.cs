namespace Pruebas_Tron
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            PicMoto = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PicMoto).BeginInit();
            SuspendLayout();
            // 
            // PicMoto
            // 
            PicMoto.BackColor = Color.Transparent;
            PicMoto.Image = (Image)resources.GetObject("PicMoto.Image");
            PicMoto.Location = new Point(279, 142);
            PicMoto.Name = "PicMoto";
            PicMoto.Size = new Size(29, 27);
            PicMoto.SizeMode = PictureBoxSizeMode.StretchImage;
            PicMoto.TabIndex = 0;
            PicMoto.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InfoText;
            ClientSize = new Size(1046, 631);
            Controls.Add(PicMoto);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)PicMoto).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox PicMoto;
    }
}
