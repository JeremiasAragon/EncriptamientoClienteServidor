namespace EncriptamientoClienteServidor
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.progressLabel = new MetroFramework.Controls.MetroLabel();
            this.progressBar = new MetroFramework.Controls.MetroProgressBar();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.toTextBox = new MetroFramework.Controls.MetroTextBox();
            this.fromTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.subnetTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.scanButton = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.allClientsCheckBox = new MetroFramework.Controls.MetroCheckBox();
            this.clientsListBox = new System.Windows.Forms.CheckedListBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.encryptionTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.messageTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(31, 78);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1195, 586);
            this.metroTabControl1.TabIndex = 8;
            this.metroTabControl1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.progressLabel);
            this.metroTabPage1.Controls.Add(this.progressBar);
            this.metroTabPage1.Controls.Add(this.metroTile2);
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.Controls.Add(this.toTextBox);
            this.metroTabPage1.Controls.Add(this.fromTextBox);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.subnetTextBox);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.scanButton);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel5);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.allClientsCheckBox);
            this.metroTabPage1.Controls.Add(this.clientsListBox);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.encryptionTypeComboBox);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.messageTextBox);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1187, 544);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Enviar Mensaje";
            this.metroTabPage1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(509, 416);
            this.progressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(228, 20);
            this.progressLabel.TabIndex = 29;
            this.progressLabel.Text = "Escaneando red, por favor espere...";
            this.progressLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progressLabel.Visible = false;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(509, 443);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(620, 36);
            this.progressBar.TabIndex = 28;
            this.progressBar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.progressBar.Visible = false;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile2.Location = new System.Drawing.Point(859, 298);
            this.metroTile2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(271, 94);
            this.metroTile2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile2.TabIndex = 27;
            this.metroTile2.Text = "Enviar Mensaje";
            this.metroTile2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile2.UseSelectable = true;
            this.metroTile2.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(509, 298);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(271, 94);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 26;
            this.metroTile1.Text = "Limpar Campos";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // toTextBox
            // 
            // 
            // 
            // 
            this.toTextBox.CustomButton.Image = null;
            this.toTextBox.CustomButton.Location = new System.Drawing.Point(52, 2);
            this.toTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.toTextBox.CustomButton.Name = "";
            this.toTextBox.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.toTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.toTextBox.CustomButton.TabIndex = 1;
            this.toTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toTextBox.CustomButton.UseSelectable = true;
            this.toTextBox.CustomButton.Visible = false;
            this.toTextBox.Lines = new string[0];
            this.toTextBox.Location = new System.Drawing.Point(172, 324);
            this.toTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toTextBox.MaxLength = 32767;
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.PasswordChar = '\0';
            this.toTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.toTextBox.SelectedText = "";
            this.toTextBox.SelectionLength = 0;
            this.toTextBox.SelectionStart = 0;
            this.toTextBox.ShortcutsEnabled = true;
            this.toTextBox.Size = new System.Drawing.Size(65, 28);
            this.toTextBox.TabIndex = 25;
            this.toTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.toTextBox.UseSelectable = true;
            this.toTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.toTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // fromTextBox
            // 
            // 
            // 
            // 
            this.fromTextBox.CustomButton.Image = null;
            this.fromTextBox.CustomButton.Location = new System.Drawing.Point(52, 2);
            this.fromTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fromTextBox.CustomButton.Name = "";
            this.fromTextBox.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.fromTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.fromTextBox.CustomButton.TabIndex = 1;
            this.fromTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.fromTextBox.CustomButton.UseSelectable = true;
            this.fromTextBox.CustomButton.Visible = false;
            this.fromTextBox.Lines = new string[] {
        "1"};
            this.fromTextBox.Location = new System.Drawing.Point(80, 324);
            this.fromTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromTextBox.MaxLength = 32767;
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.PasswordChar = '\0';
            this.fromTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fromTextBox.SelectedText = "";
            this.fromTextBox.SelectionLength = 0;
            this.fromTextBox.SelectionStart = 0;
            this.fromTextBox.ShortcutsEnabled = true;
            this.fromTextBox.Size = new System.Drawing.Size(65, 28);
            this.fromTextBox.TabIndex = 24;
            this.fromTextBox.Text = "1";
            this.fromTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.fromTextBox.UseSelectable = true;
            this.fromTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.fromTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(4, 326);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(48, 20);
            this.metroLabel8.TabIndex = 23;
            this.metroLabel8.Text = "Rango";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // subnetTextBox
            // 
            // 
            // 
            // 
            this.subnetTextBox.CustomButton.Image = null;
            this.subnetTextBox.CustomButton.Location = new System.Drawing.Point(396, 2);
            this.subnetTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.subnetTextBox.CustomButton.Name = "";
            this.subnetTextBox.CustomButton.Size = new System.Drawing.Size(31, 28);
            this.subnetTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subnetTextBox.CustomButton.TabIndex = 1;
            this.subnetTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subnetTextBox.CustomButton.UseSelectable = true;
            this.subnetTextBox.CustomButton.Visible = false;
            this.subnetTextBox.Lines = new string[0];
            this.subnetTextBox.Location = new System.Drawing.Point(80, 276);
            this.subnetTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.subnetTextBox.MaxLength = 32767;
            this.subnetTextBox.Name = "subnetTextBox";
            this.subnetTextBox.PasswordChar = '\0';
            this.subnetTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subnetTextBox.SelectedText = "";
            this.subnetTextBox.SelectionLength = 0;
            this.subnetTextBox.SelectionStart = 0;
            this.subnetTextBox.ShortcutsEnabled = true;
            this.subnetTextBox.Size = new System.Drawing.Size(323, 28);
            this.subnetTextBox.TabIndex = 22;
            this.subnetTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.subnetTextBox.UseSelectable = true;
            this.subnetTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subnetTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(4, 278);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(53, 20);
            this.metroLabel7.TabIndex = 21;
            this.metroLabel7.Text = "Subred";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // scanButton
            // 
            this.scanButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scanButton.Location = new System.Drawing.Point(267, 324);
            this.scanButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scanButton.Name = "scanButton";
            this.scanButton.Size = new System.Drawing.Size(140, 28);
            this.scanButton.TabIndex = 20;
            this.scanButton.Text = "Escanear Red";
            this.scanButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.scanButton.UseSelectable = true;
            this.scanButton.Click += new System.EventHandler(this.scanButton_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(509, 25);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(189, 25);
            this.metroLabel6.TabIndex = 18;
            this.metroLabel6.Text = "3. Redacte su mensaje";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(4, 361);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(317, 25);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "2. Seleccione el tipo de enciptamiento";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(4, 25);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(332, 25);
            this.metroLabel4.TabIndex = 16;
            this.metroLabel4.Text = "1. Seleccione el/los clientes para el envío";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(509, 74);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(114, 20);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Mensaje a enviar";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // allClientsCheckBox
            // 
            this.allClientsCheckBox.AutoSize = true;
            this.allClientsCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allClientsCheckBox.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.allClientsCheckBox.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.allClientsCheckBox.Location = new System.Drawing.Point(232, 74);
            this.allClientsCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.allClientsCheckBox.Name = "allClientsCheckBox";
            this.allClientsCheckBox.Size = new System.Drawing.Size(134, 20);
            this.allClientsCheckBox.TabIndex = 13;
            this.allClientsCheckBox.Text = "Seleccionar todos";
            this.allClientsCheckBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.allClientsCheckBox.UseSelectable = true;
            // 
            // clientsListBox
            // 
            this.clientsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.clientsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clientsListBox.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientsListBox.ForeColor = System.Drawing.Color.Silver;
            this.clientsListBox.FormattingEnabled = true;
            this.clientsListBox.Location = new System.Drawing.Point(4, 103);
            this.clientsListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientsListBox.Name = "clientsListBox";
            this.clientsListBox.Size = new System.Drawing.Size(398, 146);
            this.clientsListBox.TabIndex = 12;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 74);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(131, 20);
            this.metroLabel2.TabIndex = 11;
            this.metroLabel2.Text = "Clientes disponbiles";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // encryptionTypeComboBox
            // 
            this.encryptionTypeComboBox.FormattingEnabled = true;
            this.encryptionTypeComboBox.ItemHeight = 24;
            this.encryptionTypeComboBox.Items.AddRange(new object[] {
            "Cifrado por sustitución",
            "Cifrado por transposición"});
            this.encryptionTypeComboBox.Location = new System.Drawing.Point(4, 443);
            this.encryptionTypeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.encryptionTypeComboBox.Name = "encryptionTypeComboBox";
            this.encryptionTypeComboBox.PromptText = "Seleccione el tipo de cifrado...";
            this.encryptionTypeComboBox.Size = new System.Drawing.Size(397, 30);
            this.encryptionTypeComboBox.TabIndex = 10;
            this.encryptionTypeComboBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.encryptionTypeComboBox.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 416);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(102, 20);
            this.metroLabel1.TabIndex = 9;
            this.metroLabel1.Text = "Tipo de cifrado";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // messageTextBox
            // 
            // 
            // 
            // 
            this.messageTextBox.CustomButton.Image = null;
            this.messageTextBox.CustomButton.Location = new System.Drawing.Point(624, 1);
            this.messageTextBox.CustomButton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.messageTextBox.CustomButton.Name = "";
            this.messageTextBox.CustomButton.Size = new System.Drawing.Size(201, 186);
            this.messageTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.messageTextBox.CustomButton.TabIndex = 1;
            this.messageTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.messageTextBox.CustomButton.UseSelectable = true;
            this.messageTextBox.CustomButton.Visible = false;
            this.messageTextBox.Lines = new string[0];
            this.messageTextBox.Location = new System.Drawing.Point(509, 101);
            this.messageTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messageTextBox.MaxLength = 32767;
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.PasswordChar = '\0';
            this.messageTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.messageTextBox.SelectedText = "";
            this.messageTextBox.SelectionLength = 0;
            this.messageTextBox.SelectionStart = 0;
            this.messageTextBox.ShortcutsEnabled = true;
            this.messageTextBox.Size = new System.Drawing.Size(620, 153);
            this.messageTextBox.TabIndex = 8;
            this.messageTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.messageTextBox.UseSelectable = true;
            this.messageTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.messageTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1187, 544);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Mensajes Recibidos";
            this.metroTabPage2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 692);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "Encriptamiento Cliente Servidor";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox allClientsCheckBox;
        private System.Windows.Forms.CheckedListBox clientsListBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox encryptionTypeComboBox;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox messageTextBox;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTextBox subnetTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroButton scanButton;
        private MetroFramework.Controls.MetroTextBox toTextBox;
        private MetroFramework.Controls.MetroTextBox fromTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel progressLabel;
        private MetroFramework.Controls.MetroProgressBar progressBar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

