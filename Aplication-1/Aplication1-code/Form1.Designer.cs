
namespace Aplication1_code
{
    partial class frmFormApp
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
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.btnControl1 = new System.Windows.Forms.Button();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNuevo = new System.Windows.Forms.TextBox();
            this.lblNuevo = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInfo1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblInfo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblInfo1.Font = new System.Drawing.Font("Imprint MT Shadow", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(14)));
            this.lblInfo1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInfo1.Location = new System.Drawing.Point(75, 39);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(159, 25);
            this.lblInfo1.TabIndex = 0;
            this.lblInfo1.Text = "Apreta el boton: ";
            this.lblInfo1.MouseLeave += new System.EventHandler(this.lblInfo1_MouseLeave);
            this.lblInfo1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblInfo1_MouseMove);
            // 
            // btnControl1
            // 
            this.btnControl1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnControl1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnControl1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnControl1.Location = new System.Drawing.Point(238, 38);
            this.btnControl1.Name = "btnControl1";
            this.btnControl1.Size = new System.Drawing.Size(186, 24);
            this.btnControl1.TabIndex = 1;
            this.btnControl1.Text = "enviar";
            this.btnControl1.UseVisualStyleBackColor = false;
            this.btnControl1.Click += new System.EventHandler(this.btnControl1_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(254, 106);
            this.txtApellido.MaxLength = 15;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(170, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // txtNuevo
            // 
            this.txtNuevo.Location = new System.Drawing.Point(254, 168);
            this.txtNuevo.Multiline = true;
            this.txtNuevo.Name = "txtNuevo";
            this.txtNuevo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNuevo.Size = new System.Drawing.Size(170, 51);
            this.txtNuevo.TabIndex = 3;
            this.txtNuevo.Leave += new System.EventHandler(this.txtNuevo_Leave);
            // 
            // lblNuevo
            // 
            this.lblNuevo.AutoSize = true;
            this.lblNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevo.Location = new System.Drawing.Point(10, 181);
            this.lblNuevo.Name = "lblNuevo";
            this.lblNuevo.Size = new System.Drawing.Size(238, 18);
            this.lblNuevo.TabIndex = 4;
            this.lblNuevo.Text = "Escribe un mensaje en el Multiline: \r\n";
            this.lblNuevo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(113, 108);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(135, 18);
            this.lblNumero.TabIndex = 5;
            this.lblNumero.Text = "Ingrese un numero:";
            // 
            // frmFormApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(766, 367);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNuevo);
            this.Controls.Add(this.txtNuevo);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.btnControl1);
            this.Controls.Add(this.lblInfo1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFormApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFormApp_FormClosed);
            this.Load += new System.EventHandler(this.frmFormApp_Load);
            this.Click += new System.EventHandler(this.frmFormApp_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Button btnControl1;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNuevo;
        private System.Windows.Forms.Label lblNuevo;
        private System.Windows.Forms.Label lblNumero;
    }
}

