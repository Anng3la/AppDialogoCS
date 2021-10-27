
namespace AppDialogoCS
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
            this.buttonAbrir = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAbrir
            // 
            this.buttonAbrir.Location = new System.Drawing.Point(12, 12);
            this.buttonAbrir.Name = "buttonAbrir";
            this.buttonAbrir.Size = new System.Drawing.Size(95, 43);
            this.buttonAbrir.TabIndex = 0;
            this.buttonAbrir.Text = "Abrir";
            this.buttonAbrir.UseVisualStyleBackColor = true;
            this.buttonAbrir.Click += new System.EventHandler(this.buttonAbrir_Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(138, 12);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(95, 43);
            this.buttonGuardar.TabIndex = 1;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 445);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonAbrir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAbrir;
        private System.Windows.Forms.Button buttonGuardar;
    }
}

