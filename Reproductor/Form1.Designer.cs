
namespace Reproductor
{
    partial class frmReproductor
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReproductor));
            this.wmpReproductor = new AxWMPLib.AxWindowsMediaPlayer();
            this.abrirToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.tspAbrir = new System.Windows.Forms.ToolStrip();
            this.ayudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ltbPlaylist = new System.Windows.Forms.ListBox();
            this.btnReproducirPausa = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnRetroceder = new System.Windows.Forms.Button();
            this.btnAvanzar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).BeginInit();
            this.tspAbrir.SuspendLayout();
            this.SuspendLayout();
            // 
            // wmpReproductor
            // 
            this.wmpReproductor.Enabled = true;
            this.wmpReproductor.Location = new System.Drawing.Point(11, 33);
            this.wmpReproductor.Name = "wmpReproductor";
            this.wmpReproductor.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpReproductor.OcxState")));
            this.wmpReproductor.Size = new System.Drawing.Size(472, 327);
            this.wmpReproductor.TabIndex = 0;
            this.wmpReproductor.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.wmpReproductor_PlayStateChange);
            this.wmpReproductor.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.wmpReproductor_MediaChange);
            // 
            // abrirToolStripButton
            // 
            this.abrirToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.abrirToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("abrirToolStripButton.Image")));
            this.abrirToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.abrirToolStripButton.Name = "abrirToolStripButton";
            this.abrirToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.abrirToolStripButton.Text = "&Abrir";
            this.abrirToolStripButton.Click += new System.EventHandler(this.abrirToolStripButton_Click);
            // 
            // tspAbrir
            // 
            this.tspAbrir.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.tspAbrir.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripButton,
            this.ayudaToolStripButton});
            this.tspAbrir.Location = new System.Drawing.Point(0, 0);
            this.tspAbrir.Name = "tspAbrir";
            this.tspAbrir.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.tspAbrir.Size = new System.Drawing.Size(978, 33);
            this.tspAbrir.TabIndex = 1;
            this.tspAbrir.Text = "toolStrip1";
            // 
            // ayudaToolStripButton
            // 
            this.ayudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ayudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripButton.Image")));
            this.ayudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ayudaToolStripButton.Name = "ayudaToolStripButton";
            this.ayudaToolStripButton.Size = new System.Drawing.Size(34, 28);
            this.ayudaToolStripButton.Text = "Ay&uda";
            // 
            // ltbPlaylist
            // 
            this.ltbPlaylist.FormattingEnabled = true;
            this.ltbPlaylist.ItemHeight = 20;
            this.ltbPlaylist.Location = new System.Drawing.Point(732, 51);
            this.ltbPlaylist.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ltbPlaylist.Name = "ltbPlaylist";
            this.ltbPlaylist.Size = new System.Drawing.Size(226, 484);
            this.ltbPlaylist.TabIndex = 2;
            this.ltbPlaylist.SelectedIndexChanged += new System.EventHandler(this.ltbPlaylist_SelectedIndexChanged);
            // 
            // btnReproducirPausa
            // 
            this.btnReproducirPausa.Location = new System.Drawing.Point(16, 588);
            this.btnReproducirPausa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReproducirPausa.Name = "btnReproducirPausa";
            this.btnReproducirPausa.Size = new System.Drawing.Size(112, 35);
            this.btnReproducirPausa.TabIndex = 3;
            this.btnReproducirPausa.Text = "Reproducir";
            this.btnReproducirPausa.UseVisualStyleBackColor = true;
            this.btnReproducirPausa.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(138, 588);
            this.btnParar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(112, 35);
            this.btnParar.TabIndex = 4;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(381, 588);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(112, 35);
            this.btnSiguiente.TabIndex = 5;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(260, 588);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(112, 35);
            this.btnAnterior.TabIndex = 6;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnRetroceder
            // 
            this.btnRetroceder.Location = new System.Drawing.Point(501, 588);
            this.btnRetroceder.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRetroceder.Name = "btnRetroceder";
            this.btnRetroceder.Size = new System.Drawing.Size(112, 35);
            this.btnRetroceder.TabIndex = 7;
            this.btnRetroceder.Text = "Retroceder";
            this.btnRetroceder.UseVisualStyleBackColor = true;
            this.btnRetroceder.Click += new System.EventHandler(this.btnRetroceder_Click);
            // 
            // btnAvanzar
            // 
            this.btnAvanzar.Location = new System.Drawing.Point(621, 588);
            this.btnAvanzar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAvanzar.Name = "btnAvanzar";
            this.btnAvanzar.Size = new System.Drawing.Size(112, 35);
            this.btnAvanzar.TabIndex = 8;
            this.btnAvanzar.Text = "Avanzar";
            this.btnAvanzar.UseVisualStyleBackColor = true;
            this.btnAvanzar.Click += new System.EventHandler(this.btnAvanzar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(740, 595);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            // 
            // frmReproductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAvanzar);
            this.Controls.Add(this.btnRetroceder);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.btnReproducirPausa);
            this.Controls.Add(this.ltbPlaylist);
            this.Controls.Add(this.tspAbrir);
            this.Controls.Add(this.wmpReproductor);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReproductor";
            this.Text = "Reproductor";
            ((System.ComponentModel.ISupportInitialize)(this.wmpReproductor)).EndInit();
            this.tspAbrir.ResumeLayout(false);
            this.tspAbrir.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmpReproductor;
        private System.Windows.Forms.ToolStripButton abrirToolStripButton;
        private System.Windows.Forms.ToolStrip tspAbrir;
        private System.Windows.Forms.ToolStripButton ayudaToolStripButton;
        private System.Windows.Forms.ListBox ltbPlaylist;
        private System.Windows.Forms.Button btnReproducirPausa;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnRetroceder;
        private System.Windows.Forms.Button btnAvanzar;
        private System.Windows.Forms.Label label1;
    }
}

