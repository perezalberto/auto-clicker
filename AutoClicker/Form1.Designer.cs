namespace AutoClicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblEstadoIzquierdo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.NudIzquierdoTiempoEntreClicks = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.NudIzquierdoTiempoPorClicks = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMantenerIzquierdo = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblEstadoDerecho = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.PanelDerecho = new System.Windows.Forms.Panel();
            this.NudDerechoTiempoEntreClicks = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.NudDerechoTiempoPorClicks = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxMantenerDerecho = new System.Windows.Forms.CheckBox();
            this.AutoClicker = new System.Windows.Forms.NotifyIcon(this.components);
            this.timerIzquierdo = new System.Windows.Forms.Timer(this.components);
            this.timerDerecho = new System.Windows.Forms.Timer(this.components);
            this.menuNotifyIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.PanelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudIzquierdoTiempoEntreClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIzquierdoTiempoPorClicks)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelDerecho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDerechoTiempoEntreClicks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDerechoTiempoPorClicks)).BeginInit();
            this.menuNotifyIcon.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.lblEstadoIzquierdo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.PanelIzquierdo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbxMantenerIzquierdo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 205);
            this.panel1.TabIndex = 0;
            // 
            // lblEstadoIzquierdo
            // 
            this.lblEstadoIzquierdo.AutoSize = true;
            this.lblEstadoIzquierdo.Location = new System.Drawing.Point(58, 168);
            this.lblEstadoIzquierdo.Name = "lblEstadoIzquierdo";
            this.lblEstadoIzquierdo.Size = new System.Drawing.Size(45, 13);
            this.lblEstadoIzquierdo.TabIndex = 4;
            this.lblEstadoIzquierdo.Text = "Inactivo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Estado :";
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.Controls.Add(this.NudIzquierdoTiempoEntreClicks);
            this.PanelIzquierdo.Controls.Add(this.label4);
            this.PanelIzquierdo.Controls.Add(this.NudIzquierdoTiempoPorClicks);
            this.PanelIzquierdo.Controls.Add(this.label3);
            this.PanelIzquierdo.Location = new System.Drawing.Point(3, 78);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(214, 66);
            this.PanelIzquierdo.TabIndex = 2;
            // 
            // NudIzquierdoTiempoEntreClicks
            // 
            this.NudIzquierdoTiempoEntreClicks.Location = new System.Drawing.Point(140, 36);
            this.NudIzquierdoTiempoEntreClicks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudIzquierdoTiempoEntreClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudIzquierdoTiempoEntreClicks.Name = "NudIzquierdoTiempoEntreClicks";
            this.NudIzquierdoTiempoEntreClicks.Size = new System.Drawing.Size(62, 20);
            this.NudIzquierdoTiempoEntreClicks.TabIndex = 3;
            this.NudIzquierdoTiempoEntreClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tiempo entre clicks";
            // 
            // NudIzquierdoTiempoPorClicks
            // 
            this.NudIzquierdoTiempoPorClicks.Location = new System.Drawing.Point(140, 10);
            this.NudIzquierdoTiempoPorClicks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudIzquierdoTiempoPorClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudIzquierdoTiempoPorClicks.Name = "NudIzquierdoTiempoPorClicks";
            this.NudIzquierdoTiempoPorClicks.Size = new System.Drawing.Size(62, 20);
            this.NudIzquierdoTiempoPorClicks.TabIndex = 1;
            this.NudIzquierdoTiempoPorClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tiempo por click";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10);
            this.label1.Size = new System.Drawing.Size(221, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boton Izquierdo (<ctrl>+<alt>+L)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMantenerIzquierdo
            // 
            this.cbxMantenerIzquierdo.AutoSize = true;
            this.cbxMantenerIzquierdo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMantenerIzquierdo.Location = new System.Drawing.Point(13, 52);
            this.cbxMantenerIzquierdo.Name = "cbxMantenerIzquierdo";
            this.cbxMantenerIzquierdo.Size = new System.Drawing.Size(155, 20);
            this.cbxMantenerIzquierdo.TabIndex = 0;
            this.cbxMantenerIzquierdo.Text = "Mantener presionado";
            this.cbxMantenerIzquierdo.UseVisualStyleBackColor = true;
            this.cbxMantenerIzquierdo.CheckedChanged += new System.EventHandler(this.cbxMantenerIzquierdo_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.lblEstadoDerecho);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.PanelDerecho);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbxMantenerDerecho);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(223, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 205);
            this.panel2.TabIndex = 1;
            // 
            // lblEstadoDerecho
            // 
            this.lblEstadoDerecho.AutoSize = true;
            this.lblEstadoDerecho.Location = new System.Drawing.Point(59, 168);
            this.lblEstadoDerecho.Name = "lblEstadoDerecho";
            this.lblEstadoDerecho.Size = new System.Drawing.Size(45, 13);
            this.lblEstadoDerecho.TabIndex = 7;
            this.lblEstadoDerecho.Text = "Inactivo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Estado :";
            // 
            // PanelDerecho
            // 
            this.PanelDerecho.Controls.Add(this.NudDerechoTiempoEntreClicks);
            this.PanelDerecho.Controls.Add(this.label7);
            this.PanelDerecho.Controls.Add(this.NudDerechoTiempoPorClicks);
            this.PanelDerecho.Controls.Add(this.label8);
            this.PanelDerecho.Location = new System.Drawing.Point(4, 78);
            this.PanelDerecho.Name = "PanelDerecho";
            this.PanelDerecho.Size = new System.Drawing.Size(214, 66);
            this.PanelDerecho.TabIndex = 5;
            // 
            // NudDerechoTiempoEntreClicks
            // 
            this.NudDerechoTiempoEntreClicks.Location = new System.Drawing.Point(140, 36);
            this.NudDerechoTiempoEntreClicks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudDerechoTiempoEntreClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDerechoTiempoEntreClicks.Name = "NudDerechoTiempoEntreClicks";
            this.NudDerechoTiempoEntreClicks.Size = new System.Drawing.Size(62, 20);
            this.NudDerechoTiempoEntreClicks.TabIndex = 3;
            this.NudDerechoTiempoEntreClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tiempo entre clicks";
            // 
            // NudDerechoTiempoPorClicks
            // 
            this.NudDerechoTiempoPorClicks.Location = new System.Drawing.Point(140, 10);
            this.NudDerechoTiempoPorClicks.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NudDerechoTiempoPorClicks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NudDerechoTiempoPorClicks.Name = "NudDerechoTiempoPorClicks";
            this.NudDerechoTiempoPorClicks.Size = new System.Drawing.Size(62, 20);
            this.NudDerechoTiempoPorClicks.TabIndex = 1;
            this.NudDerechoTiempoPorClicks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiempo por click";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(221, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Boton Derecho (<ctrl>+<alt>+R)";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbxMantenerDerecho
            // 
            this.cbxMantenerDerecho.AutoSize = true;
            this.cbxMantenerDerecho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxMantenerDerecho.Location = new System.Drawing.Point(13, 52);
            this.cbxMantenerDerecho.Name = "cbxMantenerDerecho";
            this.cbxMantenerDerecho.Size = new System.Drawing.Size(155, 20);
            this.cbxMantenerDerecho.TabIndex = 1;
            this.cbxMantenerDerecho.Text = "Mantener presionado";
            this.cbxMantenerDerecho.UseVisualStyleBackColor = true;
            this.cbxMantenerDerecho.CheckedChanged += new System.EventHandler(this.cbxMantenerDerecho_CheckedChanged);
            // 
            // AutoClicker
            // 
            this.AutoClicker.ContextMenuStrip = this.menuNotifyIcon;
            this.AutoClicker.Icon = ((System.Drawing.Icon)(resources.GetObject("AutoClicker.Icon")));
            this.AutoClicker.Text = "AutoClicker";
            this.AutoClicker.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // timerIzquierdo
            // 
            this.timerIzquierdo.Interval = 1;
            this.timerIzquierdo.Tick += new System.EventHandler(this.timerIzquierdo_Tick);
            // 
            // timerDerecho
            // 
            this.timerDerecho.Interval = 1;
            this.timerDerecho.Tick += new System.EventHandler(this.timerDerecho_Tick);
            // 
            // menuNotifyIcon
            // 
            this.menuNotifyIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuRestore,
            this.toolStripMenuClose});
            this.menuNotifyIcon.Name = "contextMenuStrip1";
            this.menuNotifyIcon.Size = new System.Drawing.Size(124, 48);
            // 
            // toolStripMenuRestore
            // 
            this.toolStripMenuRestore.Name = "toolStripMenuRestore";
            this.toolStripMenuRestore.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuRestore.Text = "Restaurar";
            this.toolStripMenuRestore.Click += new System.EventHandler(this.toolStripMenuRestore_Click);
            // 
            // toolStripMenuClose
            // 
            this.toolStripMenuClose.Name = "toolStripMenuClose";
            this.toolStripMenuClose.Size = new System.Drawing.Size(123, 22);
            this.toolStripMenuClose.Text = "Cerrar";
            this.toolStripMenuClose.Click += new System.EventHandler(this.toolStripMenuClose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(444, 205);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.PanelIzquierdo.ResumeLayout(false);
            this.PanelIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudIzquierdoTiempoEntreClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudIzquierdoTiempoPorClicks)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelDerecho.ResumeLayout(false);
            this.PanelDerecho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDerechoTiempoEntreClicks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudDerechoTiempoPorClicks)).EndInit();
            this.menuNotifyIcon.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbxMantenerIzquierdo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbxMantenerDerecho;
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.NumericUpDown NudIzquierdoTiempoEntreClicks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudIzquierdoTiempoPorClicks;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel PanelDerecho;
        private System.Windows.Forms.NumericUpDown NudDerechoTiempoEntreClicks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown NudDerechoTiempoPorClicks;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NotifyIcon AutoClicker;
        private System.Windows.Forms.Timer timerIzquierdo;
        private System.Windows.Forms.Timer timerDerecho;
        private System.Windows.Forms.Label lblEstadoIzquierdo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEstadoDerecho;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip menuNotifyIcon;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuRestore;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuClose;
    }
}

