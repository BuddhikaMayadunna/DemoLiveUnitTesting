# Unit Testing with Visual Studio 2017

This project to demonstrate how to create basic unit test and how to start unit testing with visual studio 2017.This sample program is a kind of guidance to start your own coding with unit testing with best practices. 

Following program is to evaluate the strength of the password and how to get it covered with basic unit tests.
You can find more information here.
https://medium.com/@buddhikamayadunna/unit-testing-with-visual-studio-2017-1551b00de45a

You can use live unit testing features which have in visual studio 2017 as a productivity tool.

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
