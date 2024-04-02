namespace OmarOgailiSkolan
{
    public class Validation
    {
        List<string> Domins = new List<string>() {
         "hotmail.com",
            "gmail.com",
            "yahoo.com"
        };
       public bool IsValidEmail(Application application)
        {
            var emailDomain = application.Email.Split("@");
            if(emailDomain.Length == 2 ) 
            {
                var domin= emailDomain[1];
                foreach(var d in Domins ) 
                {
                    if( d == domin) {  return true;  }
                    else { return false; }
                }
            }
            else if( emailDomain.Length >0 ) 
            {
                return false;
            }

            return false;
        }
    }
}
