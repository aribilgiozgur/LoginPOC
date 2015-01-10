using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication6.Classes;

namespace WebApplication6
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı ve şifresi alınır
            String userName = txtUserName.Text;
            String passWord = EncryptPassword(txtPassword.Text);


            // İşlenir (Doğru yanlış olduğuna bakılır)
            bool isValid = checkLogin(userName, passWord);
            
            // Doğruysa yönlendirilir
            if (isValid == true)
            {
                UygulamaUser user = new UygulamaUser();
                user.setUserName(userName);
                user.setPassWord(passWord);
                user.setUserId(1);

                Session["userData"] = user; //(sınıfı!)
                Response.Redirect("Result.aspx");

                // Basit yöntem !!!!!
                // Session["userName"] = userName;
                // Response.Redirect("Result.aspx");
            }
            // Yanlışsa hata verilir.
            else {
                txtUserName.Text = "";
                txtPassword.Text = "";
                lblError.Visible = true;
            }
        }

        private bool checkLogin(String userName, String passWord) {
            bool isValid = true;

            // Veritabanı bağlantısı ile, user tablosundan userName,password kontrolü yapılır.
            if (userName != "Osman" && passWord != "e10adc3949ba59abbe56e057f20f883e")
            {
                isValid = false;
            }

            return isValid;
        }

        private string EncryptPassword(string value)
        {
            string _tempWord = value;
            _tempWord = _tempWord.Trim().Replace(" ", "");
            MD5 md5 = MD5CryptoServiceProvider.Create();
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(_tempWord);
            _tempWord = "";
            byte[] hash = md5.ComputeHash(buffer, 0, buffer.Length);
            foreach (byte b in hash)
            {
                _tempWord += (b.ToString("x2").ToLower());
            }
            return _tempWord.ToString();
        }
    }
}