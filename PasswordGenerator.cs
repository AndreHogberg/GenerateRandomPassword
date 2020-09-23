using System;
using System.Collections.Generic;
using System.Text;

namespace PasswordGenerator
{
    class PasswordGenerator
    {
        private const string CapitalLetters = "ABCDEFGIJKLMNOPQRSTUVWXYZ";
        private const string smallLettes = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";
        private const string allChars = CapitalLetters + smallLettes + Digits + SpecialChars;
        private static Random rnd = new Random();
        private static int PassLength = rnd.Next(8, 15);
        public string Generating()
        {
            string AddCL = null;
            string AddSL = null;
            string addDigit = null;
            string GeneratePassword = null;
            string[] Password = new string[PassLength];
            string addSpecial = null;
            for(int i = 0; i < 2; i++)
            {
                int GetCL = rnd.Next(CapitalLetters.Length);
                AddCL += CapitalLetters[GetCL];
            }
            for(int i = 0; i < 2; i++)
            {
                int GetSL = rnd.Next(smallLettes.Length);
                AddSL += smallLettes[GetSL];
            }
            for(int i= 0; i < 1; i++)
            {
                int getDigit = rnd.Next(Digits.Length);
                addDigit += Digits[getDigit];
            }
            for(int i = 0; i < 3; i++)
            {
                int getSpecial = rnd.Next(SpecialChars.Length);
                addSpecial += SpecialChars[getSpecial];
            }
            
            string AddPassword = AddCL + AddSL + addDigit + addSpecial;
            for (int i = 0; i < AddPassword.Length; i++)
            {
                bool whileLoop = true;
                int PasswordPlace = rnd.Next(AddPassword.Length);
                if(Password[PasswordPlace] == null)
                {
                   Password[PasswordPlace] = AddPassword[i].ToString();
                }
                else
                {
                    while (whileLoop)
                    {
                        PasswordPlace = rnd.Next(AddPassword.Length);
                        if (Password[PasswordPlace] == null)
                        {
                            Password[PasswordPlace] = AddPassword[i].ToString();
                            whileLoop = false;
                        }
                    }
                }
            }
            for(int i = 0; i < PassLength; i++)
            {
                GeneratePassword += Password[i];
            }
            int GeneLength = GeneratePassword.Length;
            for(int i = 0; i < PassLength - GeneLength; i++)
            {
                int CharPlace = rnd.Next(AddPassword.Length);
                GeneratePassword += allChars[CharPlace].ToString();
            }
            return GeneratePassword;
        }
    }
}
