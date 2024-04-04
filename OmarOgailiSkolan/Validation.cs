using System.ComponentModel.DataAnnotations;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace OmarOgailiSkolan
{
    public class Validation
    {
        /// <summary>
        /// jag använder Regex sätt för att validera email, metoden kollar genom string och se om det finns någon matchning 
        /// om det är finns så retunerar true eller flase om det inte finns någon matchning
        /// </summary>
        /// <param name="emailInput"> prameter som vi tar in i motden för att genomföra kontrollen, den framställer application.Email som
        /// användaren kommer och skriva in i blanketten</param>
        /// 
        public static bool RegexEmailCheck(string emailInput)
        {
            return Regex.IsMatch(emailInput, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

        /// <summary>
        /// NameValid den metoden först kollar om det finns en space i namneInput, om det inte finns någon space då har användaren inte skrivit 
        /// sitt efter namn och det är bara ett namn de har skrivit 
        /// annars så går jag och kollar om det finns en space då gör jag en split där sedan kollar jag längden på den andra delen efter space
        /// om den är lika lång med 0 då innebär det att användaren har inte skrivit något och tryckte bara på space då retunerar metoden falsk
        /// annars så retunerar metoden true. 
        /// om inget är sannt så retunerar metoden false. 
        /// </summary>
        /// <param name="nameInput">den stringen som vi ska ta emot från användaren och framställer Application.Name</param>
        /// <returns></returns>
        public   bool NameValid(string nameInput)
        {
            if(!nameInput.Contains(" "))
            {
                return false;
            }
            if (nameInput.Contains(" "))
            {
                var nameParts = nameInput.Split(' ');
                if (nameParts[1].Trim().Length == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
        public int AgeConverting(DateTime dateOfBirth)
        {
            var today = DateTime.Today;
             int age = today.Year - dateOfBirth.Year;
            if (dateOfBirth.Date > today.AddYears(-age) || dateOfBirth.Date > today)
            {
                age--;
                return age;
            }
             return age;
        }



    }
}
