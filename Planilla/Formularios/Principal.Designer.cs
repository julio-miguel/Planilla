﻿namespace Planilla.Formularios
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.smRespaldar = new System.Windows.Forms.Button();
            this.smConfiguracion = new System.Windows.Forms.Button();
            this.menuconfiguracion = new System.Windows.Forms.Button();
            this.smRestaurar = new System.Windows.Forms.Button();
            this.btmGenerales = new System.Windows.Forms.Button();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.generalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnCargo = new System.Windows.Forms.Button();
            this.MenuHerramientas = new System.Windows.Forms.Button();
            this.msMenu = new System.Windows.Forms.Button();
            this.tsRespaldar = new System.Windows.Forms.ToolStripMenuItem();
            this.restaurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEmpleado = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // smRespaldar
            // 
            this.smRespaldar.Dock = System.Windows.Forms.DockStyle.Top;
            this.smRespaldar.Location = new System.Drawing.Point(0, 0);
            this.smRespaldar.Name = "smRespaldar";
            this.smRespaldar.Size = new System.Drawing.Size(174, 35);
            this.smRespaldar.TabIndex = 2;
            this.smRespaldar.Tag = "Respaldar";
            this.smRespaldar.Text = "Respaldar";
            this.toolTip.SetToolTip(this.smRespaldar, "Respaldar la información de la base de datos");
            this.smRespaldar.UseVisualStyleBackColor = true;
            this.smRespaldar.Click += new System.EventHandler(this.smRespaldar_Click);
            // 
            // smConfiguracion
            // 
            this.smConfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.smConfiguracion.Location = new System.Drawing.Point(0, 70);
            this.smConfiguracion.Name = "smConfiguracion";
            this.smConfiguracion.Size = new System.Drawing.Size(174, 35);
            this.smConfiguracion.TabIndex = 4;
            this.smConfiguracion.Tag = "Configuracion";
            this.smConfiguracion.Text = "Configuracion";
            this.toolTip.SetToolTip(this.smConfiguracion, "Información de la configuración");
            this.smConfiguracion.UseVisualStyleBackColor = true;
            this.smConfiguracion.Click += new System.EventHandler(this.smConfiguracion_Click);
            // 
            // menuconfiguracion
            // 
            this.menuconfiguracion.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuconfiguracion.Location = new System.Drawing.Point(0, 83);
            this.menuconfiguracion.Name = "menuconfiguracion";
            this.menuconfiguracion.Size = new System.Drawing.Size(174, 35);
            this.menuconfiguracion.TabIndex = 2;
            this.menuconfiguracion.Tag = "Configuración";
            this.menuconfiguracion.Text = "Configuracion";
            this.toolTip.SetToolTip(this.menuconfiguracion, "Configuración");
            this.menuconfiguracion.UseVisualStyleBackColor = true;
            // 
            // smRestaurar
            // 
            this.smRestaurar.Dock = System.Windows.Forms.DockStyle.Top;
            this.smRestaurar.Location = new System.Drawing.Point(0, 35);
            this.smRestaurar.Name = "smRestaurar";
            this.smRestaurar.Size = new System.Drawing.Size(174, 35);
            this.smRestaurar.TabIndex = 3;
            this.smRestaurar.Tag = "Restaurar";
            this.smRestaurar.Text = "Restaurar";
            this.toolTip.SetToolTip(this.smRestaurar, "Restaurar información de la base de datos");
            this.smRestaurar.UseVisualStyleBackColor = true;
            // 
            // btmGenerales
            // 
            this.btmGenerales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btmGenerales.Location = new System.Drawing.Point(0, 118);
            this.btmGenerales.Name = "btmGenerales";
            this.btmGenerales.Size = new System.Drawing.Size(174, 35);
            this.btmGenerales.TabIndex = 3;
            this.btmGenerales.Tag = "General";
            this.btmGenerales.Text = "General";
            this.toolTip.SetToolTip(this.btmGenerales, "Información general del sistema");
            this.btmGenerales.UseVisualStyleBackColor = true;
            this.btmGenerales.Click += new System.EventHandler(this.btmGenerales_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuario.Location = new System.Drawing.Point(0, 105);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(174, 35);
            this.btnUsuario.TabIndex = 5;
            this.btnUsuario.Tag = "Usuario";
            this.btnUsuario.Text = "Usuario";
            this.toolTip.SetToolTip(this.btnUsuario, "Información del usuario");
            this.btnUsuario.UseVisualStyleBackColor = true;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click_1);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsRespaldar,
            this.restaurarToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(90, 20);
            this.toolsMenu.Text = "&Herramientas";
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(53, 20);
            this.helpMenu.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generalToolStripMenuItem,
            this.toolsMenu,
            this.configuraciónToolStripMenuItem,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(975, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // generalToolStripMenuItem
            // 
            this.generalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.generalToolStripMenuItem.Name = "generalToolStripMenuItem";
            this.generalToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.generalToolStripMenuItem.Text = "General";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem1});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // configuraciónToolStripMenuItem1
            // 
            this.configuraciónToolStripMenuItem1.Name = "configuraciónToolStripMenuItem1";
            this.configuraciónToolStripMenuItem1.Size = new System.Drawing.Size(150, 22);
            this.configuraciónToolStripMenuItem1.Text = "Configuración";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(975, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.btnEmpleado);
            this.splitContainer1.Panel1.Controls.Add(this.btmGenerales);
            this.splitContainer1.Panel1.Controls.Add(this.menuconfiguracion);
            this.splitContainer1.Panel1.Controls.Add(this.MenuHerramientas);
            this.splitContainer1.Panel1.Controls.Add(this.msMenu);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.btnCargo);
            this.splitContainer1.Panel2.Controls.Add(this.btnUsuario);
            this.splitContainer1.Panel2.Controls.Add(this.smConfiguracion);
            this.splitContainer1.Panel2.Controls.Add(this.smRestaurar);
            this.splitContainer1.Panel2.Controls.Add(this.smRespaldar);
            this.splitContainer1.Size = new System.Drawing.Size(178, 407);
            this.splitContainer1.SplitterDistance = 211;
            this.splitContainer1.TabIndex = 4;
            // 
            // btnCargo
            // 
            this.btnCargo.BackColor = System.Drawing.Color.Transparent;
            this.btnCargo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCargo.Location = new System.Drawing.Point(0, 140);
            this.btnCargo.Name = "btnCargo";
            this.btnCargo.Size = new System.Drawing.Size(174, 35);
            this.btnCargo.TabIndex = 6;
            this.btnCargo.Tag = "Cargo";
            this.btnCargo.Text = "Cargo";
            this.toolTip.SetToolTip(this.btnCargo, "\r\n");
            this.btnCargo.UseVisualStyleBackColor = false;
            this.btnCargo.Click += new System.EventHandler(this.btnCargo_Click);
            // 
            // MenuHerramientas
            // 
            this.MenuHerramientas.Dock = System.Windows.Forms.DockStyle.Top;
            this.MenuHerramientas.Image = global::Planilla.Properties.Resources.generador2;
            this.MenuHerramientas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MenuHerramientas.Location = new System.Drawing.Point(0, 38);
            this.MenuHerramientas.Name = "MenuHerramientas";
            this.MenuHerramientas.Size = new System.Drawing.Size(174, 45);
            this.MenuHerramientas.TabIndex = 1;
            this.MenuHerramientas.Tag = "Herramientas";
            this.MenuHerramientas.Text = "Herramientas";
            this.MenuHerramientas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.MenuHerramientas, "Herramientas");
            this.MenuHerramientas.UseVisualStyleBackColor = true;
            this.MenuHerramientas.Click += new System.EventHandler(this.MenuHerramientas_Click);
            // 
            // msMenu
            // 
            this.msMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.msMenu.Image = global::Planilla.Properties.Resources.iconfinder_70_Menu_2123897__2_;
            this.msMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(174, 38);
            this.msMenu.TabIndex = 0;
            this.msMenu.Tag = "Mostrar";
            this.msMenu.Text = "Menus";
            this.msMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.msMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip.SetToolTip(this.msMenu, "Herramienas para guardar y respalda la información");
            this.msMenu.UseVisualStyleBackColor = true;
            this.msMenu.Click += new System.EventHandler(this.msMenu_Click);
            // 
            // tsRespaldar
            // 
            this.tsRespaldar.Image = global::Planilla.Properties.Resources.iconfinder_db_update_3213;
            this.tsRespaldar.Name = "tsRespaldar";
            this.tsRespaldar.Size = new System.Drawing.Size(125, 22);
            this.tsRespaldar.Tag = "Respaldar";
            this.tsRespaldar.Text = "Respaldar";
            this.tsRespaldar.ToolTipText = "Respaldar información de la base de datos";
            // 
            // restaurarToolStripMenuItem
            // 
            this.restaurarToolStripMenuItem.Image = global::Planilla.Properties.Resources.iconfinder_Database_Upload_49582;
            this.restaurarToolStripMenuItem.Name = "restaurarToolStripMenuItem";
            this.restaurarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.restaurarToolStripMenuItem.Text = "Restaurar";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleado.Location = new System.Drawing.Point(0, 153);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(174, 35);
            this.btnEmpleado.TabIndex = 4;
            this.btnEmpleado.Tag = "Empleado";
            this.btnEmpleado.Text = "Empleado";
            this.toolTip.SetToolTip(this.btnEmpleado, "Informacion del empleado");
            this.btnEmpleado.UseVisualStyleBackColor = false;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 453);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Principal";
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button menuconfiguracion;
        private System.Windows.Forms.Button MenuHerramientas;
        private System.Windows.Forms.Button msMenu;
        private System.Windows.Forms.Button smRestaurar;
        private System.Windows.Forms.Button smRespaldar;
        private System.Windows.Forms.Button smConfiguracion;
        private System.Windows.Forms.Button btmGenerales;
        private System.Windows.Forms.Button btnUsuario;
        private System.Windows.Forms.ToolStripMenuItem tsRespaldar;
        private System.Windows.Forms.ToolStripMenuItem restaurarToolStripMenuItem;        
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem generalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.Button btnCargo;
        private System.Windows.Forms.Button btnEmpleado;
    }
}



