namespace _04_Pig_Latin
{
    internal class Translator
    {
        internal string Translate(string something)
        {
            int a = 0;
            
            
            string result = " ";
            string[] anarray = something.Split(' ');
            foreach(string astring in anarray)
            {   
                while((astring.Substring(a, 1) != "a")&&(astring.Substring(a, 1)!= "e")&&(astring.Substring(a, 1) != "i")
                    &&(astring.Substring(a, 1) != "o")&&(astring.Substring(a, 1) != "u")){
                    a++;
                    
                
                }
                if (a == 0)
                {
                    result += astring + "ay ";
                    a = 0;
                }
                else 
                {
                    if(astring.Substring(a-1,2) == "qu")
                    {
                        result += astring.Substring(a + 1) + astring.Substring(0, a + 1) + "ay ";
                        a = 0;
                    }
                    else
                    {
                        result += astring.Substring(a) + astring.Substring(0, a) + "ay ";
                        a = 0;
                    }
                    
                }
             }
                return result.Trim();
        }
    }
}