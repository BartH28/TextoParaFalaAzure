
namespace TextoParaFala
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
            this.texto = new System.Windows.Forms.TextBox();
            this.botao = new System.Windows.Forms.Button();
            this.vozes = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // texto
            // 
            this.texto.Location = new System.Drawing.Point(54, 32);
            this.texto.Multiline = true;
            this.texto.Name = "texto";
            this.texto.Size = new System.Drawing.Size(620, 246);
            this.texto.TabIndex = 0;
            // 
            // botao
            // 
            this.botao.Location = new System.Drawing.Point(306, 303);
            this.botao.Name = "botao";
            this.botao.Size = new System.Drawing.Size(209, 69);
            this.botao.TabIndex = 1;
            this.botao.Text = "Salvar Audio";
            this.botao.UseVisualStyleBackColor = true;
            this.botao.Click += new System.EventHandler(this.button1_Click);
            // 
            // vozes
            // 
            this.vozes.FormattingEnabled = true;
            this.vozes.ItemHeight = 20;
            this.vozes.Items.AddRange(new object[] {
            "Francisca",
            "Antonio",
            "Daniel ",
            "Eloisa"});
            this.vozes.Location = new System.Drawing.Point(54, 303);
            this.vozes.Name = "vozes";
            this.vozes.Size = new System.Drawing.Size(150, 104);
            this.vozes.TabIndex = 2;
            this.vozes.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 3;
            this.button1.Text = "addFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vozes);
            this.Controls.Add(this.botao);
            this.Controls.Add(this.texto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texto;
        private System.Windows.Forms.Button botao;
        private System.Windows.Forms.ListBox vozes;
        private System.Windows.Forms.Button button1;
    }
}

