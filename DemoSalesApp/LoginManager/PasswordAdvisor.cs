﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DemoSalesApp.LoginManager
{
    public class PasswordAdvisor
    {
        public enum PasswordScore
        {
            TooShort = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }

        public static PasswordScore CheckPasswordStrngth(string password)
        {
            int score = 0;

            if (password.Length < 1)
            {
                return PasswordScore.TooShort;
            }
            if (password.Length < 4)
            {
                return PasswordScore.VeryWeak;
            }
            if (password.Length >= 8)
            {
                score++;
            }

            if (password.Length >= 12)
                score++;

            if (Regex.Match(password, @"\d+", RegexOptions.ECMAScript).Success)
            {
                score++;
            }

            if (Regex.Match(password, @"[a-z]", RegexOptions.ECMAScript).Success &&
              Regex.Match(password, @"[A-Z]", RegexOptions.ECMAScript).Success)
            {
                score++;
            }

            if (Regex.Match(password, @".[!,@,#,$,%,^,&,*,?,_,~,-,£,(,)]", RegexOptions.ECMAScript).Success)
            {
                score++;
            }
            return (PasswordScore)score;
        }

        /* 
         Requirement 

         If passowrd Length is < 1  -> Tooshort
         if passowrd Length is < 4  -> VeryWeak 
         if passowrd Length is >= 8  -> VeryWeak  increse score by 1
         if passowrd Length is >= 12  -> VeryWeak  increse score by 1

         if Numbers found increse score by 1 
         if Charaeter case found increse score by 1
         if Special Charaeter found increse score by 1

         */
    }
}
