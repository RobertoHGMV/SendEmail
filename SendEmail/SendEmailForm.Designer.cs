namespace SendEmail
{
    partial class SendEmailForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtEmailFrom = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtPassword = new MetroFramework.Controls.MetroTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtEmailTo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtUserName = new MetroFramework.Controls.MetroTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtMessage = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtSubject = new MetroFramework.Controls.MetroTextBox();
            this.listBoxAttachments = new MetroFramework.Controls.MetroListView();
            this.btnAttachment = new MetroFramework.Controls.MetroButton();
            this.cmdOk = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSend = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmailFrom
            // 
            // 
            // 
            // 
            this.txtEmailFrom.CustomButton.Image = null;
            this.txtEmailFrom.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.txtEmailFrom.CustomButton.Name = "";
            this.txtEmailFrom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailFrom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailFrom.CustomButton.TabIndex = 1;
            this.txtEmailFrom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailFrom.CustomButton.UseSelectable = true;
            this.txtEmailFrom.CustomButton.Visible = false;
            this.txtEmailFrom.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmailFrom.Lines = new string[0];
            this.txtEmailFrom.Location = new System.Drawing.Point(16, 61);
            this.txtEmailFrom.MaxLength = 100;
            this.txtEmailFrom.Name = "txtEmailFrom";
            this.txtEmailFrom.PasswordChar = '\0';
            this.txtEmailFrom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailFrom.SelectedText = "";
            this.txtEmailFrom.SelectionLength = 0;
            this.txtEmailFrom.SelectionStart = 0;
            this.txtEmailFrom.ShortcutsEnabled = true;
            this.txtEmailFrom.Size = new System.Drawing.Size(345, 23);
            this.txtEmailFrom.TabIndex = 0;
            this.txtEmailFrom.UseSelectable = true;
            this.txtEmailFrom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailFrom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.metroLabel2);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.metroLabel1);
            this.groupBox1.Controls.Add(this.txtEmailFrom);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(745, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Credenciais do Remetente";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(16, 33);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(60, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "E-mail";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(382, 33);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Senha";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtPassword.CustomButton.Image = null;
            this.txtPassword.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.txtPassword.CustomButton.Name = "";
            this.txtPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPassword.CustomButton.TabIndex = 1;
            this.txtPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPassword.CustomButton.UseSelectable = true;
            this.txtPassword.CustomButton.Visible = false;
            this.txtPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPassword.Lines = new string[0];
            this.txtPassword.Location = new System.Drawing.Point(382, 61);
            this.txtPassword.MaxLength = 100;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Size = new System.Drawing.Size(345, 23);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSelectable = true;
            this.txtPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.metroLabel3);
            this.groupBox2.Controls.Add(this.txtEmailTo);
            this.groupBox2.Controls.Add(this.metroLabel4);
            this.groupBox2.Controls.Add(this.txtUserName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(23, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 110);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.Location = new System.Drawing.Point(382, 33);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(155, 25);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "E-mail Destinatário";
            // 
            // txtEmailTo
            // 
            this.txtEmailTo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtEmailTo.CustomButton.Image = null;
            this.txtEmailTo.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.txtEmailTo.CustomButton.Name = "";
            this.txtEmailTo.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmailTo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmailTo.CustomButton.TabIndex = 1;
            this.txtEmailTo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmailTo.CustomButton.UseSelectable = true;
            this.txtEmailTo.CustomButton.Visible = false;
            this.txtEmailTo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtEmailTo.Lines = new string[0];
            this.txtEmailTo.Location = new System.Drawing.Point(382, 61);
            this.txtEmailTo.MaxLength = 100;
            this.txtEmailTo.Name = "txtEmailTo";
            this.txtEmailTo.PasswordChar = '\0';
            this.txtEmailTo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmailTo.SelectedText = "";
            this.txtEmailTo.SelectionLength = 0;
            this.txtEmailTo.SelectionStart = 0;
            this.txtEmailTo.ShortcutsEnabled = true;
            this.txtEmailTo.Size = new System.Drawing.Size(345, 23);
            this.txtEmailTo.TabIndex = 2;
            this.txtEmailTo.UseSelectable = true;
            this.txtEmailTo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmailTo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.Location = new System.Drawing.Point(16, 33);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(145, 25);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Nome Remetente";
            // 
            // txtUserName
            // 
            // 
            // 
            // 
            this.txtUserName.CustomButton.Image = null;
            this.txtUserName.CustomButton.Location = new System.Drawing.Point(323, 1);
            this.txtUserName.CustomButton.Name = "";
            this.txtUserName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserName.CustomButton.TabIndex = 1;
            this.txtUserName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserName.CustomButton.UseSelectable = true;
            this.txtUserName.CustomButton.Visible = false;
            this.txtUserName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtUserName.Lines = new string[0];
            this.txtUserName.Location = new System.Drawing.Point(16, 61);
            this.txtUserName.MaxLength = 100;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserName.SelectedText = "";
            this.txtUserName.SelectionLength = 0;
            this.txtUserName.SelectionStart = 0;
            this.txtUserName.ShortcutsEnabled = true;
            this.txtUserName.Size = new System.Drawing.Size(345, 23);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.UseSelectable = true;
            this.txtUserName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.btnAttachment);
            this.groupBox3.Controls.Add(this.listBoxAttachments);
            this.groupBox3.Controls.Add(this.metroLabel5);
            this.groupBox3.Controls.Add(this.txtSubject);
            this.groupBox3.Controls.Add(this.txtMessage);
            this.groupBox3.Controls.Add(this.metroLabel6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(23, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 297);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.Location = new System.Drawing.Point(16, 53);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 25);
            this.metroLabel5.TabIndex = 3;
            this.metroLabel5.Text = "Mensagem";
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtMessage.CustomButton.Image = null;
            this.txtMessage.CustomButton.Location = new System.Drawing.Point(493, 1);
            this.txtMessage.CustomButton.Name = "";
            this.txtMessage.CustomButton.Size = new System.Drawing.Size(115, 115);
            this.txtMessage.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtMessage.CustomButton.TabIndex = 1;
            this.txtMessage.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtMessage.CustomButton.UseSelectable = true;
            this.txtMessage.CustomButton.Visible = false;
            this.txtMessage.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtMessage.Lines = new string[0];
            this.txtMessage.Location = new System.Drawing.Point(118, 54);
            this.txtMessage.MaxLength = 1000;
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMessage.SelectedText = "";
            this.txtMessage.SelectionLength = 0;
            this.txtMessage.SelectionStart = 0;
            this.txtMessage.ShortcutsEnabled = true;
            this.txtMessage.Size = new System.Drawing.Size(609, 117);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.UseSelectable = true;
            this.txtMessage.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtMessage.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.Location = new System.Drawing.Point(16, 25);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 25);
            this.metroLabel6.TabIndex = 1;
            this.metroLabel6.Text = "Assunto";
            // 
            // txtSubject
            // 
            this.txtSubject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.txtSubject.CustomButton.Image = null;
            this.txtSubject.CustomButton.Location = new System.Drawing.Point(587, 1);
            this.txtSubject.CustomButton.Name = "";
            this.txtSubject.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSubject.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSubject.CustomButton.TabIndex = 1;
            this.txtSubject.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSubject.CustomButton.UseSelectable = true;
            this.txtSubject.CustomButton.Visible = false;
            this.txtSubject.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSubject.Lines = new string[0];
            this.txtSubject.Location = new System.Drawing.Point(118, 25);
            this.txtSubject.MaxLength = 100;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.PasswordChar = '\0';
            this.txtSubject.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSubject.SelectedText = "";
            this.txtSubject.SelectionLength = 0;
            this.txtSubject.SelectionStart = 0;
            this.txtSubject.ShortcutsEnabled = true;
            this.txtSubject.Size = new System.Drawing.Size(609, 23);
            this.txtSubject.TabIndex = 0;
            this.txtSubject.UseSelectable = true;
            this.txtSubject.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSubject.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // listBoxAttachments
            // 
            this.listBoxAttachments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxAttachments.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listBoxAttachments.FullRowSelect = true;
            this.listBoxAttachments.Location = new System.Drawing.Point(118, 177);
            this.listBoxAttachments.Name = "listBoxAttachments";
            this.listBoxAttachments.OwnerDraw = true;
            this.listBoxAttachments.Size = new System.Drawing.Size(609, 98);
            this.listBoxAttachments.TabIndex = 4;
            this.listBoxAttachments.UseCompatibleStateImageBehavior = false;
            this.listBoxAttachments.UseSelectable = true;
            // 
            // btnAttachment
            // 
            this.btnAttachment.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAttachment.Location = new System.Drawing.Point(16, 177);
            this.btnAttachment.Name = "btnAttachment";
            this.btnAttachment.Size = new System.Drawing.Size(95, 38);
            this.btnAttachment.TabIndex = 5;
            this.btnAttachment.Text = "Anexo";
            this.btnAttachment.UseSelectable = true;
            this.btnAttachment.Click += new System.EventHandler(this.btnAttachment_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdOk.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.cmdOk.Location = new System.Drawing.Point(23, 600);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(75, 38);
            this.cmdOk.TabIndex = 4;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseSelectable = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.Location = new System.Drawing.Point(673, 600);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 38);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Limpar";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSend.Location = new System.Drawing.Point(572, 600);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(95, 38);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseSelectable = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // SendEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 651);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SendEmailForm";
            this.Text = "Enviar E-mail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtEmailFrom;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtPassword;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtEmailTo;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtUserName;
        private System.Windows.Forms.GroupBox groupBox3;
        private MetroFramework.Controls.MetroListView listBoxAttachments;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtMessage;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtSubject;
        private MetroFramework.Controls.MetroButton btnAttachment;
        private MetroFramework.Controls.MetroButton cmdOk;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSend;
    }
}

