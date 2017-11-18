using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using SendEmail.Services;

namespace SendEmail
{
    public partial class SendEmailForm : MetroFramework.Forms.MetroForm
    {
        private EmailService _emailService;

        public SendEmailForm()
        {
            InitializeComponent();
            _emailService = new EmailService();
        }

        private void ValidFields()
        {
            if (!_emailService.ValidMail(txtEmailFrom.Text))
                throw new Exception("Email do emitente inválido.");

            if (string.IsNullOrEmpty(txtPassword.Text))
                throw new Exception("Informe a senha do e-mail.");

            if (string.IsNullOrEmpty(txtUserName.Text))
                throw new Exception("Informe o nome do remetente.");

            if (!_emailService.ValidMail(txtEmailTo.Text))
                throw new Exception("Email do destinatário inválido.");

            if (string.IsNullOrEmpty(txtSubject.Text))
                throw new Exception("Informe o assunto do e-mail.");

            if (string.IsNullOrEmpty(txtMessage.Text))
                throw new Exception("Informe a mensagem do e-mail.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                txtEmailFrom.Text =
                    txtPassword.Text =
                        txtUserName.Text =
                            txtEmailTo.Text =
                                txtSubject.Text =
                                    txtMessage.Text =
                                        listBoxAttachments.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            try
            {
                _emailService.GetAttachment();

                foreach (var fileName in _emailService.FileNames)
                    listBoxAttachments.Items.Add(fileName);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                ValidFields();

                var parameters = new EmailParameters();
                parameters.Host = "smtp.gmail.com";
                parameters.EmailFrom = txtEmailFrom.Text;
                parameters.Password = txtPassword.Text;
                parameters.UserNameFrom = txtUserName.Text;
                parameters.EmailTo = txtEmailTo.Text;
                parameters.Subject = txtSubject.Text;
                parameters.Message = txtMessage.Text;

                _emailService.SendEmail(parameters);

                MetroMessageBox.Show(this, "E-mail enviado com sucesso!", "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Mensagem do Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
