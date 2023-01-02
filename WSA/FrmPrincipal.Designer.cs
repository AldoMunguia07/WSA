
namespace WSA
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.miUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehículosEnTransitoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasAnuladasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conductoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boletasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bitácoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administracinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encabezadoBoletaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respaldoDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónIndicadorDeBásculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tslbNombreUsuario = new System.Windows.Forms.ToolStripLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.White;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.procesoToolStripMenuItem,
            this.gestionToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.administracinToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1147, 26);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miUsuarioToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(95, 22);
            this.fileMenu.Text = "Opciones";
            // 
            // miUsuarioToolStripMenuItem
            // 
            this.miUsuarioToolStripMenuItem.Image = global::WSA.Properties.Resources.mi_usuario;
            this.miUsuarioToolStripMenuItem.Name = "miUsuarioToolStripMenuItem";
            this.miUsuarioToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.miUsuarioToolStripMenuItem.Text = "Mi usuario";
            this.miUsuarioToolStripMenuItem.Click += new System.EventHandler(this.miUsuarioToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::WSA.Properties.Resources.salir;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exitToolStripMenuItem.Text = "&Salir";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // procesoToolStripMenuItem
            // 
            this.procesoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehículosEnTransitoToolStripMenuItem,
            this.boletasToolStripMenuItem,
            this.entradasAnuladasToolStripMenuItem});
            this.procesoToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.procesoToolStripMenuItem.Name = "procesoToolStripMenuItem";
            this.procesoToolStripMenuItem.Size = new System.Drawing.Size(75, 22);
            this.procesoToolStripMenuItem.Text = "Pesaje";
            // 
            // vehículosEnTransitoToolStripMenuItem
            // 
            this.vehículosEnTransitoToolStripMenuItem.Image = global::WSA.Properties.Resources.entradaVehiculo;
            this.vehículosEnTransitoToolStripMenuItem.Name = "vehículosEnTransitoToolStripMenuItem";
            this.vehículosEnTransitoToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.vehículosEnTransitoToolStripMenuItem.Text = "Entradas de vehículos";
            this.vehículosEnTransitoToolStripMenuItem.Click += new System.EventHandler(this.vehículosEnTransitoToolStripMenuItem_Click);
            // 
            // boletasToolStripMenuItem
            // 
            this.boletasToolStripMenuItem.Image = global::WSA.Properties.Resources.boletas;
            this.boletasToolStripMenuItem.Name = "boletasToolStripMenuItem";
            this.boletasToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.boletasToolStripMenuItem.Text = "Boletas";
            this.boletasToolStripMenuItem.Click += new System.EventHandler(this.boletasToolStripMenuItem_Click);
            // 
            // entradasAnuladasToolStripMenuItem
            // 
            this.entradasAnuladasToolStripMenuItem.Image = global::WSA.Properties.Resources.anuladas;
            this.entradasAnuladasToolStripMenuItem.Name = "entradasAnuladasToolStripMenuItem";
            this.entradasAnuladasToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.entradasAnuladasToolStripMenuItem.Text = "Entradas anuladas";
            this.entradasAnuladasToolStripMenuItem.Click += new System.EventHandler(this.entradasAnuladasToolStripMenuItem_Click);
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.conductoresToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.barcosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.gestionToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(83, 22);
            this.gestionToolStripMenuItem.Text = "Gestión";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Image = global::WSA.Properties.Resources.clientes;
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.clienteToolStripMenuItem.Text = "Clientes";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // conductoresToolStripMenuItem
            // 
            this.conductoresToolStripMenuItem.Image = global::WSA.Properties.Resources.conductores;
            this.conductoresToolStripMenuItem.Name = "conductoresToolStripMenuItem";
            this.conductoresToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.conductoresToolStripMenuItem.Text = "Conductores";
            this.conductoresToolStripMenuItem.Click += new System.EventHandler(this.conductoresToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::WSA.Properties.Resources.Productos;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // barcosToolStripMenuItem
            // 
            this.barcosToolStripMenuItem.Image = global::WSA.Properties.Resources.barcos;
            this.barcosToolStripMenuItem.Name = "barcosToolStripMenuItem";
            this.barcosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.barcosToolStripMenuItem.Text = "Barcos";
            this.barcosToolStripMenuItem.Click += new System.EventHandler(this.barcosToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Image = global::WSA.Properties.Resources.usuarios;
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boletasToolStripMenuItem1,
            this.bitácoraToolStripMenuItem});
            this.reportesToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // boletasToolStripMenuItem1
            // 
            this.boletasToolStripMenuItem1.Image = global::WSA.Properties.Resources.boletas;
            this.boletasToolStripMenuItem1.Name = "boletasToolStripMenuItem1";
            this.boletasToolStripMenuItem1.Size = new System.Drawing.Size(143, 22);
            this.boletasToolStripMenuItem1.Text = "Boletas";
            this.boletasToolStripMenuItem1.Click += new System.EventHandler(this.boletasToolStripMenuItem1_Click);
            // 
            // bitácoraToolStripMenuItem
            // 
            this.bitácoraToolStripMenuItem.Image = global::WSA.Properties.Resources.bitacora;
            this.bitácoraToolStripMenuItem.Name = "bitácoraToolStripMenuItem";
            this.bitácoraToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.bitácoraToolStripMenuItem.Text = "Bitácora";
            this.bitácoraToolStripMenuItem.Click += new System.EventHandler(this.bitácoraToolStripMenuItem_Click);
            // 
            // administracinToolStripMenuItem
            // 
            this.administracinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bitacoraToolStripMenuItem,
            this.encabezadoBoletaToolStripMenuItem,
            this.respaldoDeBaseDeDatosToolStripMenuItem,
            this.configuraciónIndicadorDeBásculaToolStripMenuItem,
            this.históricoToolStripMenuItem});
            this.administracinToolStripMenuItem.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administracinToolStripMenuItem.Name = "administracinToolStripMenuItem";
            this.administracinToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.administracinToolStripMenuItem.Text = "Administración";
            // 
            // bitacoraToolStripMenuItem
            // 
            this.bitacoraToolStripMenuItem.Image = global::WSA.Properties.Resources.bitacora;
            this.bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            this.bitacoraToolStripMenuItem.Size = new System.Drawing.Size(387, 22);
            this.bitacoraToolStripMenuItem.Text = "Bitácora";
            this.bitacoraToolStripMenuItem.Click += new System.EventHandler(this.bitacoraToolStripMenuItem_Click);
            // 
            // encabezadoBoletaToolStripMenuItem
            // 
            this.encabezadoBoletaToolStripMenuItem.Image = global::WSA.Properties.Resources.encabezado;
            this.encabezadoBoletaToolStripMenuItem.Name = "encabezadoBoletaToolStripMenuItem";
            this.encabezadoBoletaToolStripMenuItem.Size = new System.Drawing.Size(387, 22);
            this.encabezadoBoletaToolStripMenuItem.Text = "Encabezado de boleta";
            this.encabezadoBoletaToolStripMenuItem.Click += new System.EventHandler(this.encabezadoBoletaToolStripMenuItem_Click);
            // 
            // respaldoDeBaseDeDatosToolStripMenuItem
            // 
            this.respaldoDeBaseDeDatosToolStripMenuItem.Image = global::WSA.Properties.Resources.backup;
            this.respaldoDeBaseDeDatosToolStripMenuItem.Name = "respaldoDeBaseDeDatosToolStripMenuItem";
            this.respaldoDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(387, 22);
            this.respaldoDeBaseDeDatosToolStripMenuItem.Text = "Respaldo de base de datos";
            this.respaldoDeBaseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.respaldoDeBaseDeDatosToolStripMenuItem_Click);
            // 
            // configuraciónIndicadorDeBásculaToolStripMenuItem
            // 
            this.configuraciónIndicadorDeBásculaToolStripMenuItem.Image = global::WSA.Properties.Resources.indicador;
            this.configuraciónIndicadorDeBásculaToolStripMenuItem.Name = "configuraciónIndicadorDeBásculaToolStripMenuItem";
            this.configuraciónIndicadorDeBásculaToolStripMenuItem.Size = new System.Drawing.Size(387, 22);
            this.configuraciónIndicadorDeBásculaToolStripMenuItem.Text = "Configuración de indicador de báscula";
            this.configuraciónIndicadorDeBásculaToolStripMenuItem.Click += new System.EventHandler(this.configuraciónIndicadorDeBásculaToolStripMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Image = global::WSA.Properties.Resources.historico;
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(387, 22);
            this.históricoToolStripMenuItem.Text = "Histórico";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.históricoToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.White;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbNombreUsuario});
            this.toolStrip.Location = new System.Drawing.Point(0, 26);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1147, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // tslbNombreUsuario
            // 
            this.tslbNombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tslbNombreUsuario.Name = "tslbNombreUsuario";
            this.tslbNombreUsuario.Size = new System.Drawing.Size(103, 22);
            this.tslbNombreUsuario.Text = "Nombre usuario";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 561);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AWS - Advance Weighing System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conductoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vehículosEnTransitoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletasToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel tslbNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administracinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encabezadoBoletaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem respaldoDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradasAnuladasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónIndicadorDeBásculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boletasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bitácoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
    }
}



