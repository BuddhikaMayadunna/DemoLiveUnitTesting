
        public enum PasswordStrengthScore
        {
            TooShort = 0,
            VeryWeak = 1,
            Weak = 2,
            Medium = 3,
            Strong = 4,
            VeryStrong = 5
        }

        public static PasswordStrengthScore EvaluatePasswordStrngth(string password)
        {
            int score = 0;

            if (password.Length < 1)
            {
                return PasswordStrengthScore.TooShort;
            }
            if (password.Length < 4)
            {
                return PasswordStrengthScore.VeryWeak;
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
            return (PasswordStrengthScore)score;
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
