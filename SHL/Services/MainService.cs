using System.Collections.Generic;

namespace SHL.Services
{
    static class MainService
    {
        public static Dictionary<string, string> languages; // Key - Shortcut, Value - Full Name

        static MainService()
        {
            AddAllLanguages();
        }

        static private void AddAllLanguages()
        {
            languages.Add("sq", "albański");
            languages.Add("en", "angielski");
            languages.Add("ar", "arabski");
            languages.Add("be", "białoruski");
            languages.Add("bg", "bułgarski");
            languages.Add("zh", "chiński");
            languages.Add("hrv", "chorwacki");
            languages.Add("cs", "czeski");
            languages.Add("da", "duński");
            languages.Add("et", "estoński");
            languages.Add("fi", "fiński");
            languages.Add("fr", "francuski");
            languages.Add("el", "grecki");
            languages.Add("he", "hebrajski");
            languages.Add("hi", "hindi");
            languages.Add("es", "hiszpański");
            languages.Add("in", "indonezyjski");
            languages.Add("is", "islandzki");
            languages.Add("ja", "japoński");
            languages.Add("ji", "jidysz");
            languages.Add("ca", "kataloński");
            languages.Add("ko", "koreański");
            languages.Add("lt", "litewski");
            languages.Add("lv", "łotewski");
            languages.Add("mk", "macedoński");
            languages.Add("ms", "malezyjski");
            languages.Add("mt", "maltański");
            languages.Add("nl", "niderlandzki");
            languages.Add("de", "niemiecki");
            languages.Add("nov", "norweski");
            languages.Add("fa", "perski");
            languages.Add("pl", "polski");
            languages.Add("pt", "portugalski");
            languages.Add("ru", "rosyjski");
            languages.Add("ro", "rumuński");
            languages.Add("sr", "serbski");
            languages.Add("sv", "szwedzki");
            languages.Add("sk", "słowacki");
            languages.Add("sl", "słoweński");
            languages.Add("th", "tajlandzki");
            languages.Add("tr", "turecki");
            languages.Add("uk", "ukraiński");
            languages.Add("hu", "węgierski");
            languages.Add("vi", "wietamski");
            languages.Add("it", "włoski");
        }
        static public string LanguagesToString()
        {
            string toReturn = "";

            foreach (var item in languages)
            {
                toReturn = toReturn + item.Key + " - " + item.Value + "/n";
            }

            return toReturn;
        }

    }
}
