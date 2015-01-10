using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication6.Classes
{
    public class UygulamaUser
    {
        private int userId;
        private String userName;
        private String passWord;


        # region getters & setters

        public int getUserId()
        {
            return this.userId;
        }

        public void setUserId(int userId){
            this.userId = userId;
        }

        public String getUserName() {
            return this.userName;
        }

        public void setUserName(String userName) {
            this.userName = userName;
        }

        public String getPassWord()
        {
            return this.passWord;
        }

        public void setPassWord(String passWord)
        {
            this.passWord = passWord;
        }

        

        #endregion








    }
}