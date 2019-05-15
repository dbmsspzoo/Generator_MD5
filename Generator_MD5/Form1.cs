using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;

namespace Generator_MD5
{
    public partial class MainWindow : Form
    {
        public static string clear_nulls(string null_value)
        {
            null_value = null_value.ToLower();
            null_value = null_value.Replace("null", "");
            return null_value;
        }
        public static string klaruj_imie_nazwisko_firma(string imie_nazwisko)
        {

            imie_nazwisko = imie_nazwisko.Replace("\'", "");
            imie_nazwisko = imie_nazwisko.Replace("\"", "");
            imie_nazwisko = imie_nazwisko.ToLower();
            imie_nazwisko = imie_nazwisko.Replace("null", "");
            //imie_nazwisko = clear_nulls(imie_nazwisko.ToString());
            // oczyszczenie z polskich znakow
            char[] polskie_znaki_org = { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż' };
            char[] polskie_znaki_rep = { 'a', 'c', 'e', 'l', 'n', 'o', 's', 'z', 'z' };
            for (int i = 0; i < polskie_znaki_org.Length; i++) { imie_nazwisko = imie_nazwisko.Replace(polskie_znaki_org[i], polskie_znaki_rep[i]); }
            imie_nazwisko = imie_nazwisko.Trim();
            return imie_nazwisko;
        }
        public static string klaruj_email(string email)
        {
            email = email.Replace("NULL", "");
            email = email.Replace("null", "");
            email = email.Replace("\'", "");
            email = email.Replace("\"", "");
            email = email.Trim();
            return email;
        }
        public static string klaruj_regon(string regon)
        {
            regon = regon.Replace("NULL", "");
            regon = regon.Replace("null", "");
            regon = regon.Replace("\'", "");
            regon = regon.Replace("\"", "");
            regon = regon.Replace("-", "");
            regon = regon.Replace("(", "");
            regon = regon.Replace(")", "");
            regon = regon.Replace(" ", "");
            regon = regon.Replace("+", "");
            regon = regon.Replace("\\", "");
            regon = regon.Replace("/", "");
            regon = regon.Replace("_", "");
            regon = regon.Trim();

            StringBuilder sb = new StringBuilder();
            sb.Append(regon);

            if (sb.Length == 0)
            {
                return "";
            }

            if (sb.Length > 9 && sb.Length < 14)
            {
                while (sb.Length < 14)
                {
                    sb.Insert(0, "0");
                }
                return sb.ToString();
            }
            while (sb.Length < 9)
            {
                sb.Insert(0, "0");
            }
            
            return sb.ToString();
        }
        public static string klaruj_krs(string krs)
        {
            krs = krs.Replace("NULL", "");
            krs = krs.Replace("null", "");
            krs = krs.Replace("\'", "");
            krs = krs.Replace("\"", "");
            krs = krs.Replace("-", "");
            krs = krs.Replace("(", "");
            krs = krs.Replace(")", "");
            krs = krs.Replace(" ", "");
            krs = krs.Replace("+", "");
            krs = krs.Replace("\\", "");
            krs = krs.Replace("/", "");
            krs = krs.Replace("_", "");
            krs = krs.Trim();
            return krs;
        }
        public static string klaruj_nip(string nip)
        {
            nip = nip.Replace("NULL", "");
            nip = nip.Replace("null", "");
            nip = nip.Replace("\'", "");
            nip = nip.Replace("\"", "");
            nip = nip.Replace("-", "");
            nip = nip.Replace("(", "");
            nip = nip.Replace(")", "");
            nip = nip.Replace(" ", "");
            nip = nip.Replace("+", "");
            nip = nip.Replace("\\", "");
            nip = nip.Replace("/", "");
            nip = nip.Replace("_", "");
            nip = nip.Trim();
            return nip;
        }
        public static string klaruj_pesel(string pesel)
        {
            pesel = pesel.Replace("NULL", "");
            pesel = pesel.Replace("null", "");
            pesel = pesel.Replace("\'", "");
            pesel = pesel.Replace("\"", "");
            pesel = pesel.Replace("-", "");
            pesel = pesel.Replace("(", "");
            pesel = pesel.Replace(")", "");
            pesel = pesel.Replace(" ", "");
            pesel = pesel.Replace("+", "");
            pesel = pesel.Replace("\\", "");
            pesel = pesel.Replace("/", "");
            pesel = pesel.Replace("_", "");
            pesel = pesel.Trim();
            return pesel;
        }
        public static string klaruj_telefon(string telefon)
        {
            telefon = telefon.Replace("NULL", "");
            telefon = telefon.Replace("null", "");
            telefon = telefon.Replace("\'", "");
            telefon = telefon.Replace("\"", "");
            telefon = telefon.Replace("-", "");
            telefon = telefon.Replace("(", "");
            telefon = telefon.Replace(")", "");
            telefon = telefon.Replace(" ", "");
            telefon = telefon.Replace("+", "");
            telefon = telefon.Replace("\\", "");
            telefon = telefon.Replace("/", "");
            telefon = telefon.Replace("_", "");
            
            if (telefon.Length == 11) { telefon = telefon.Substring(2, 9); }
            else if (telefon.Length == 10) { telefon = telefon.Substring(1, 9); }
            telefon = telefon.Trim();
            return telefon;
        }
        public static string klaruj_numer(string numer)
        {
            numer = numer.Replace("NULL", "");
            numer = numer.Replace("null", "");
            numer = numer.ToLower();
            numer = numer.Replace("\'", "");
            numer = numer.Replace("\"", "");
            numer = numer.Replace(" ", "");
            char[] znaki_do_strimmowania = { '*', ' ' };
            numer = numer.Trim(znaki_do_strimmowania);
            numer = numer.Trim();
            return numer;
        }
        public static string klaruj_miasta(string miasto)
        {
            miasto = miasto.Replace("NULL", "");
            miasto = miasto.Replace("null", "");
            miasto = miasto.ToLower();
            // oczyszczenie z polskich znakow
            char[] polskie_znaki_org = { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż' };
            char[] polskie_znaki_rep = { 'a', 'c', 'e', 'l', 'n', 'o', 's', 'z', 'z' };
            for (int i = 0; i < polskie_znaki_org.Length; i++) { miasto = miasto.Replace(polskie_znaki_org[i], polskie_znaki_rep[i]); }
            // generalne oczyszczenie ulic z zapisów, które mogą być poczynione w różny sposób:
            string[] znaki_org = { "\"", "'" };
            string[] znaki_rep = { "", "" };
            for (int i = 0; i < znaki_org.Length; i++) { miasto = miasto.Replace(znaki_org[i], znaki_rep[i]); }
            miasto = miasto.Trim();
            return miasto;
        }
        public static string klaruj_kody(string kod)
        {
            // generalne oczyszczenie ulic z zapisów, które mogą być poczynione w różny sposób:
            kod = kod.Replace("NULL", "");
            kod = kod.Replace("null", "");
            string[] znaki_org = { "\"", "'" };
            string[] znaki_rep = { "", "" };
            for (int i = 0; i < znaki_org.Length; i++) { kod = kod.Replace(znaki_org[i], znaki_rep[i]); }
            if (kod.Length == 5)
            {
                kod = kod.Substring(0, 2) + "-" + kod.Substring(2, 3);
            }
            kod = kod.Trim();
            return kod;
        }
        public static string klaruj_ulice(string ulica)
        {
            ulica = ulica.Replace("NULL", "");
            ulica = ulica.Replace("null", "");
            ulica = ulica.Replace("?", "s");
            char[] znaki_do_strimmowania = { '*', ' ' };
            // lower 
            ulica = ulica.ToLower();

            // oczyszczenie z polskich znakow
            char[] polskie_znaki_org = { 'ą', 'ć', 'ę', 'ł', 'ń', 'ó', 'ś', 'ź', 'ż' };
            char[] polskie_znaki_rep = { 'a', 'c', 'e', 'l', 'n', 'o', 's', 'z', 'z' };
            for (int i = 0; i < polskie_znaki_org.Length; i++) { ulica = ulica.Replace(polskie_znaki_org[i], polskie_znaki_rep[i]); }

            // poprawka nazw ulic
            //string[] ulice_org = {"1 maja",   "3 maja",   "jana pawla 2"};
            //string[] ulice_rep = {"1-go maja","3-go maja","jana pawla ii"};
            //for (int i = 0; i < ulice_org.Length; i++) {ulica = ulica.Replace(ulice_org[i], ulice_rep[i]);}

            // generalne oczyszczenie ulic z zapisów, które mogą być poczynione w różny sposób:
            string[] znaki_org = { "\"", "'", "-go", "-lecia", " iii", " ii", "xxx" };
            string[] znaki_rep = { "", "", "", "", " 3", " 2", "30" };
            for (int i = 0; i < znaki_org.Length; i++) { ulica = ulica.Replace(znaki_org[i], znaki_rep[i]); }

            // oczyszczenie z prefiksow:
            var pattern = "^(ul[.]{1}|ul |plac|pl[.]+|pl |aleja|al[.]{1}|osiedle|os[.]{1}|wybrzeze|bulwar|skwer|rondo)";
            ulica = Regex.Replace(ulica, pattern, "");
            ulica = ulica.Trim(znaki_do_strimmowania);
            pattern = "(arcybiskupa|abpa[.]{1}|abpa |profesora|prof[.]{1}|prof |generala|gen[.]{1}|pulkownika|plk[.]{1}|plk |majora|mjr[.]{1}|mjr |ksiedza|ks[.]{1}|ks |marsz[.]{1}|dr[.]{1}|kardynala|kard[.]{1}|swietej|swietego|sw[.]{1}|sw )";
            ulica = Regex.Replace(ulica, pattern, "");
            ulica = ulica.Trim(znaki_do_strimmowania);
            ulica = ulica.Replace("  ", " ");

            // zamiana popularnych nazw ulic?
            Regex regex_ul = new Regex("komis[a-z ]+edukac[a-z ]+narod[a-z]");
            Match match_ul = regex_ul.Match(ulica);
            if (match_ul.Success) { ulica = "KEN"; Console.WriteLine("IN " + ulica); }

            // oczyszczenie z inicjałow
            string[] inicjaly = { "wl.", "st.", "a.", "b.", "c.", "d.", "e.", "f.", "g.", "h.", "i.", "j.", "k.", "l.", "m.", "n.", "o.", "p.", "r.", "s.", "t.", "u.", "w.", "x.", "y.", "z." };
            for (int i = 0; i < inicjaly.Length; i++)
            {
                if (ulica == "p.o.w.") { continue; }
                if (ulica == "z.w.m.") { continue; }
                if (ulica == "k.e.n.") { continue; }
                if (ulica == "p.c.k.") { continue; }
                if (ulica == "l.w.p.") { continue; }
                if (ulica == "a.k.") { continue; }
                if (ulica == "a.l.") { continue; }
                if (ulica == "w.p.") { continue; }
                if (ulica == "b.b.o.n.") { continue; }
                if (ulica == "g.o.p.r.") { continue; }
                if (ulica == "p.k.w.n.") { continue; }
                ulica = ulica.Replace(inicjaly[i], "");
            }
            // oczyszczenie z imion
            string[] ulice_wylaczone = { "jana pawla 2", "jana 3 sobieskiego", "mieszka 1", "aleksandra 1", "kazimierza wielkiego", "brygidy z gwiazdzistej" };
            //string[] lista_imion = {"jana","stanisława","andrzeja","józefa","tadeusza","jerzego","zbigniewa","krzysztofa","henryka","ryszarda","kazimierza","marka","mariana","piotra","janusza","władysława","bolesława","adama","wiesława","kornela","zdzisława","edwarda","mieczysława","romana","mirosława","grzegorza","czesława","dariusza","wojciecha","jacka","eugeniusza","tomasza","stefana","zygmunta","leszka","bogdana","antoniego","pawła","franciszka","sławomira","waldemara","jarosława","roberta","mariusza","włodzimierza","michała","zenona","bogusława","witolda","aleksandra","bronisława","wacława","bolesława","ireneusza","macieja","artura","edmunda","marcina","lecha","karola","ursyna","rafała","arkadiusza","leona","sylwestera","lucjana","juliana","wiktora","romualda","bernarda","ludwika","feliksa","alfreda","alojzego","przemysława","cezara","daniela","mikołaja","ignacego","lesława","radosława","konrada","bogumiła","szczepana","gerarda","hieronima","krystiana","leonarda","wincentego","benedykta","huberta","sebastiana","norberta","adolfa","łukasza","emila","teodora","rudolfa","joachima","jakuba","walentego","alfonsa","damiana","rajmunda","szymona","zygfryda","leopolda","remigiusza","floriana","konstantyna","konstantego","augustyna","albina","bohdana","leopolda","dominika","gabriela","teofila","brunona","juliusza","waleriana","bartłomieja","fryderyka","eryka","anatola","mikołaja","maksymiliana","gustawa","aleksego","longina","bartosza","wilhelma","ferdynanda","erwina","klemensa","lechosława","ernesta","seweryna","aleksandra","fryderyka","herberta","alberta","błażeja","izydora","dionizego","edwina","gintera","adriana","mateusza","waltera","helmuta","bazylego","waleriana","marcelego","sergiusza","bonifacego","iwana","wernera","eligiusza","wawrzyńca","kamila","łucjana","olgierda","arnolda","jacentego","dawida","ewalda","manfreda","emiliana","klaudiusza","juliana","zbysława","igora","benona","jędrzeja","wita","hilarego","apolinarego","melchiora","fabiana","zenobiusza","horsta","gerharda","rolanda","ignacego","euzebiusza","hipolita","filipa","nikodema","mirona","januarego","kajetana","bazyla","emanuela","idziego","donata","augusta","dymitra","ksawerego","ludomira","narcyza","lubomira","witalisa","rocha","waleriana","miłosza","telesfora","heronima","ziemowita","borysa","oskara","zbyszka","krystyna","zbyszka","marii","krystyny","anny","barbary","teresy","elżbiety","janiny","zofii","jadwigii","danuty","haliny","ireny","ewy","małgorzaty","heleny","grażyny","bożeny","stanisławy","jolanty","marianny","urszuli","wandy","alicji","doroty","agnieszki","beaty","katarzyny","joanny","wiesławy","renaty","iwony","genowefy","kazimiery","stefanii","hanny","lucyny","józefy","aliny","mirosławy","aleksandry","władysławy","henryki","czesławy","lidii","reginy","moniki","magdaleny","bogumiły","marty","marzeny","leokadii","marioli","bronisławy","anieli","bogusławy","eugenii","izabeli","cecyliy","emilii","łucji","gabrieli","sabiny","zdzisławy","agaty","edyty","anety","danieli","wioletty","sylwi","weroniki","antoniny","justyny","gertrudy","mieczysławy","franciszki","rozalii","zuzanny","natalii","celiny","ilony","alfredy","wiktorii","olgi","wacławy","róży","karoliny","bernadety","julii","michaliny","adeli","ludwiki","honoraty","aldony","eleonory","violetty","felicji","walentyny","pelagii","apolonii","brygidy","zenony","izabelli","romany","zenobii","walerii","anity","bożeny","romualdy","marzanny","anastazji","kamili","aurelii","eweliny","ludmiły","hildegardy","teodozji","feliksy","niny","pauliny","longiny","julianny","klary","marleny","teodory","leonardy","ryszardy","liliany","kingi","lilianny","albiny","elwiry","gizeli","bolesławy","otylii","kariny","arlety","marzenny","melanii","kornelii","salomei","adelajdy","eryki","dominiki","sławomiry","donaty","elizy","tamary","zyty","bernadetty","nadzieji","bernardy","irminy","julity","wiery","dagmary","wiolety","matyldy","edwardy","lilli","klaudii","żanety","tatiany","elfrydy","patrycji","anetty","lilii","teofilii","darii","maryli","rity","amelii","eulalii","lili","licji","leontyny","luby","kunegundy","ruty","sonii","seweryny","jarosławy","klementyny","adriany","edeltraudy","filomeny","angeliki","tekli","blandyny","florentyny","elizy","luizy","gerdy","krzysztofy","adrianny","martyny","ingi","balbiny","erny","domiceli","zinaidy","bogny"};
            string[] lista_imion = { "jana", "stanislawa", "andrzeja", "jozefa", "tadeusza", "jerzego", "zbigniewa", "krzysztofa", "henryka", "ryszarda", "kazimierza", "marka", "mariana", "piotra", "janusza", "wladyslawa", "boleslawa", "adama", "wieslawa", "kornela", "zdzislawa", "edwarda", "mieczyslawa", "romana", "miroslawa", "grzegorza", "czeslawa", "dariusza", "wojciecha", "jacka", "eugeniusza", "tomasza", "stefana", "zygmunta", "leszka", "bogdana", "antoniego", "pawla", "franciszka", "slawomira", "waldemara", "jaroslawa", "roberta", "mariusza", "wlodzimierza", "michala", "zenona", "boguslawa", "witolda", "aleksandra", "bronislawa", "waclawa", "boleslawa", "ireneusza", "macieja", "artura", "edmunda", "marcina", "lecha", "karola", "ursyna", "rafala", "arkadiusza", "leona", "sylwestera", "lucjana", "juliana", "wiktora", "romualda", "bernarda", "ludwika", "feliksa", "alfreda", "alojzego", "przemyslawa", "cezara", "daniela", "mikolaja", "ignacego", "leslawa", "radoslawa", "konrada", "bogumila", "szczepana", "gerarda", "hieronima", "krystiana", "leonarda", "wincentego", "benedykta", "huberta", "sebastiana", "norberta", "adolfa", "lukasza", "emila", "teodora", "rudolfa", "joachima", "jakuba", "walentego", "alfonsa", "damiana", "rajmunda", "szymona", "zygfryda", "leopolda", "remigiusza", "floriana", "konstantyna", "konstantego", "augustyna", "albina", "bohdana", "leopolda", "dominika", "gabriela", "teofila", "brunona", "juliusza", "waleriana", "bartlomieja", "fryderyka", "eryka", "anatola", "mikolaja", "maksymiliana", "gustawa", "aleksego", "longina", "bartosza", "wilhelma", "ferdynanda", "erwina", "klemensa", "lechoslawa", "ernesta", "seweryna", "aleksandra", "fryderyka", "herberta", "alberta", "blazeja", "izydora", "dionizego", "edwina", "gintera", "adriana", "mateusza", "waltera", "helmuta", "bazylego", "waleriana", "marcelego", "sergiusza", "bonifacego", "iwana", "wernera", "eligiusza", "wawrzynca", "kamila", "lucjana", "olgierda", "arnolda", "jacentego", "dawida", "ewalda", "manfreda", "emiliana", "klaudiusza", "juliana", "zbyslawa", "igora", "benona", "jedrzeja", "wita", "hilarego", "apolinarego", "melchiora", "fabiana", "zenobiusza", "horsta", "gerharda", "rolanda", "ignacego", "euzebiusza", "hipolita", "filipa", "nikodema", "mirona", "januarego", "kajetana", "bazyla", "emanuela", "idziego", "donata", "augusta", "dymitra", "ksawerego", "ludomira", "narcyza", "lubomira", "witalisa", "rocha", "waleriana", "milosza", "telesfora", "heronima", "ziemowita", "borysa", "oskara", "zbyszka", "krystyna", "zbyszka", "marii", "krystyny", "anny", "barbary", "teresy", "elzbiety", "janiny", "zofii", "jadwigii", "danuty", "haliny", "ireny", "ewy", "malgorzaty", "heleny", "grazyny", "bozeny", "stanislawy", "jolanty", "marianny", "urszuli", "wandy", "alicji", "doroty", "agnieszki", "beaty", "katarzyny", "joanny", "wieslawy", "renaty", "iwony", "genowefy", "kazimiery", "stefanii", "hanny", "lucyny", "jozefy", "aliny", "miroslawy", "aleksandry", "wladyslawy", "henryki", "czeslawy", "lidii", "reginy", "moniki", "magdaleny", "bogumily", "marty", "marzeny", "leokadii", "marioli", "bronislawy", "anieli", "boguslawy", "eugenii", "izabeli", "cecyliy", "emilii", "lucji", "gabrieli", "sabiny", "zdzislawy", "agaty", "edyty", "anety", "danieli", "wioletty", "sylwi", "weroniki", "antoniny", "justyny", "gertrudy", "mieczyslawy", "franciszki", "rozalii", "zuzanny", "natalii", "celiny", "ilony", "alfredy", "wiktorii", "olgi", "waclawy", "rozy", "karoliny", "bernadety", "julii", "michaliny", "adeli", "ludwiki", "honoraty", "aldony", "eleonory", "violetty", "felicji", "walentyny", "pelagii", "apolonii", "brygidy", "zenony", "izabelli", "romany", "zenobii", "walerii", "anity", "bozeny", "romualdy", "marzanny", "anastazji", "kamili", "aurelii", "eweliny", "ludmily", "hildegardy", "teodozji", "feliksy", "niny", "pauliny", "longiny", "julianny", "klary", "marleny", "teodory", "leonardy", "ryszardy", "liliany", "kingi", "lilianny", "albiny", "elwiry", "gizeli", "boleslawy", "otylii", "kariny", "arlety", "marzenny", "melanii", "kornelii", "salomei", "adelajdy", "eryki", "dominiki", "slawomiry", "donaty", "elizy", "tamary", "zyty", "bernadetty", "nadzieji", "bernardy", "irminy", "julity", "wiery", "dagmary", "wiolety", "matyldy", "edwardy", "lilli", "klaudii", "zanety", "tatiany", "elfrydy", "patrycji", "anetty", "lilii", "teofilii", "darii", "maryli", "rity", "amelii", "eulalii", "lili", "licji", "leontyny", "luby", "kunegundy", "ruty", "sonii", "seweryny", "jaroslawy", "klementyny", "adriany", "edeltraudy", "filomeny", "angeliki", "tekli", "blandyny", "florentyny", "elizy", "luizy", "gerdy", "krzysztofy", "adrianny", "martyny", "ingi", "balbiny", "erny", "domiceli", "zinaidy", "bogny" };

            // detekcja, czy ulica jest w grupie ulice_wylaczone
            // jesli jest, nie oczyszczamy takiej ulicy z imion (tablica ulice_wylaczone powyżej)
            bool flag = true;
            for (int j = 0; j < ulice_wylaczone.Length; j++)
            {
                if (String.Compare(ulice_wylaczone[j], ulica) == 0) { Console.WriteLine("IN " + ulica); flag = false; }
            }
            Regex regex = new Regex("^ksieznej|krolowej|krola|swietej|sw[.]{1} |sw ");
            Match match = regex.Match(ulica);
            if (match.Success) { Console.WriteLine("IN " + ulica); flag = false; }
            regex = new Regex("^[a-z]+$");
            match = regex.Match(ulica);
            if (match.Success) { Console.WriteLine("IN " + ulica); flag = false; }


            if (flag)
            {
                for (int i = 0; i < lista_imion.Length; i++)
                {
                    regex = new Regex("^[ ]*[a-z]+[ ]*$");
                    match = regex.Match(ulica);
                    if (match.Success) { break; }
                    ulica = ulica.Replace(lista_imion[i], "");
                    ulica = ulica.Replace("  ", " ");
                }

            }


            ulica = ulica.Trim(znaki_do_strimmowania);
            ulica = ulica.Trim();
            return ulica;
        }
        public static string get_md5(string in_data)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] in_data_bytes = System.Text.Encoding.ASCII.GetBytes(in_data); // inputBytes = System.Text.Encoding.ASCII.GetBytes(in_data);
                byte[] in_data_bytes_hash = md5.ComputeHash(in_data_bytes); // hashBytes = md5.ComputeHash(in_data_bytes);
                StringBuilder out_data = new StringBuilder(); // StringBuilder sb = new StringBuilder();
                for (int i = 0; i < in_data_bytes_hash.Length; i++)
                {
                    out_data.Append(in_data_bytes_hash[i].ToString("X2"));
                }
                return out_data.ToString();
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            pomoc1.Visible = false;
        }

        private void pomocButton_Click(object sender, EventArgs e)
        {
            pomoc1.Visible = true;
            //pomoc1.BringToFront();
            pomocButton.Visible = false;
            openStatusLabel.Visible = false;
            saveStatusLabel.Visible = false;
            statusLabel.Visible = false;
            zamknijPomocButton.Visible = true;
        }

        private void zamknijPomocButton_Click(object sender, EventArgs e)
        {
            zamknijPomocButton.Visible = false;
            pomocButton.Visible = true;
            pomoc1.Visible = false;
            openStatusLabel.Visible = true;
            if (wybierzLokalizacjeButton.Visible == true)
            {
                saveStatusLabel.Visible = true;
            }

            //if (wygenerujPlikButton.Visible == true)
            //{
            //    statusLabel.Visible = true;
            //}
            //
            //

        }

        private void zamknijButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void minimalizujButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void topMenu_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void topMenu_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void topMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void BindDataCSV(string openFilePath, string saveFilePath)
        {
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(openFilePath);

            if (lines.Length > 0)
            {
                //first line to create header

                string firstLine = lines[0];

                string[] headerLabels = firstLine.Split(';');

                foreach (string headerWord in headerLabels)
                {
                    dt.Columns.Add(new DataColumn(headerWord));
                }
                // for data 

                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(';');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;
                    foreach (string headerWord in headerLabels)
                    {
                        if (headerWord.ToUpper().Equals("ID_DBMS"))
                        {
                            dr[headerWord] = dataWords[columnIndex++];

                        }
                        else if (headerWord.ToUpper().Equals("IMIE"))
                        {
                            dr[headerWord] = get_md5(klaruj_imie_nazwisko_firma(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";

                            //dr[headerWord] = dr[headerWord].Equals("null") ? "EMPTY" : get_md5(klaruj_imie_nazwisko_firma(dataWords[columnIndex++]));

                        }
                        else if (headerWord.ToUpper().Equals("NAZWISKO"))
                        {
                            
                            dr[headerWord] = get_md5(klaruj_imie_nazwisko_firma(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_imie_nazwisko_firma(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("NAZWA_FIRMY"))
                        {

                            dr[headerWord] = get_md5(klaruj_imie_nazwisko_firma(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_imie_nazwisko_firma(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("ULICA"))
                        {

                            dr[headerWord] = get_md5(klaruj_ulice(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_ulice(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("NR_ULICY"))
                        {

                            dr[headerWord] = get_md5(klaruj_numer(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_numer(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("NR_LOKALU"))
                        {

                            dr[headerWord] = get_md5(klaruj_numer(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_numer(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("KOD"))
                        {

                            dr[headerWord] = get_md5(klaruj_kody(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_kody(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("MIASTO"))
                        {

                            dr[headerWord] = get_md5(klaruj_miasta(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_miasta(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("PESEL"))
                        {

                            dr[headerWord] = get_md5(klaruj_pesel(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_pesel(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("NIP"))
                        {

                            dr[headerWord] = get_md5(klaruj_nip(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_nip(dataWords[columnIndex++])));
                            // dr[headerWord] = get_md5(klaruj_nip(dataWords[columnIndex++]));
                        }
                        else if (headerWord.ToUpper().Equals("REGON"))
                        {

                            dr[headerWord] = get_md5(klaruj_regon(dataWords[columnIndex++]));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_regon(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("KRS"))
                        {

                            dr[headerWord] = get_md5(klaruj_krs(clear_nulls(dataWords[columnIndex++])));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_krs(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("TELEFON"))
                        {

                            dr[headerWord] = get_md5(klaruj_telefon(clear_nulls(dataWords[columnIndex++])));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_telefon(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("EMAIL"))
                        {

                            dr[headerWord] = get_md5(klaruj_email(clear_nulls(dataWords[columnIndex++])));
                            if (dr[headerWord].Equals("D41D8CD98F00B204E9800998ECF8427E")) dr[headerWord] = "";
                            //dr[headerWord] = (clear_nulls(dataWords[columnIndex++]).Equals("") ? "EMPTY" : get_md5(klaruj_email(dataWords[columnIndex++])));
                        }
                        else if (headerWord.ToUpper().Equals("DODATKOWE"))
                        {

                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        //else if (headerWord.Equals("CLIENT_ID"))
                        //{
                        //    dr[headerWord] = "CLIENT_ID" + dataWords[columnIndex++];
                        //}
                        else
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                    }
                    dt.Rows.Add(dr);
                }
                var result = new StringBuilder();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    result.Append(dt.Columns[i].ColumnName);
                    result.Append(i == dt.Columns.Count - 1 ? "\n" : ",");
                }

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < dt.Columns.Count; i++)
                    {
                        result.Append(row[i].ToString());
                        result.Append(i == dt.Columns.Count - 1 ? "\n" : ",");
                    }
                }
                File.WriteAllText(saveFilePath, result.ToString());
            }
        }

        private void wybierzPlikButton_Click(object sender, EventArgs e)
        {
            wybierzPlikButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); // transparent
            wybierzPlikButton.FlatAppearance.BorderSize = 0;
            wybierzLokalizacjeButton.Visible = false;
            saveStatusLabel.Visible = false;
            wygenerujPlikButton.Visible = false;
            statusLabel.Visible = false;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!Path.GetExtension(openFileDialog.FileName).Equals(".csv"))
                    {
                        MessageBox.Show("Wybrano plik z błędnym rozszerzeniem!\n\nWybierz plik z rozszerzeniem .csv");
                    }
                    else
                    {
                        assistantLabel.Text = openFileDialog.FileName;
                        openStatusLabel.Visible = true;
                        if ((Path.GetFileName(openFileDialog.FileName)).Length > 15)
                        {
                            string shortOpenFileName = (Path.GetFileName(openFileDialog.FileName)).Substring(0, 15) + "...";
                            openStatusLabel.Text = shortOpenFileName;
                        }
                        else
                        {
                            openStatusLabel.Text = Path.GetFileName(openFileDialog.FileName);
                        }

                        wybierzLokalizacjeButton.Visible = true;
                        if (wybierzLokalizacjeButton.Visible == true)
                        {
                            saveStatusLabel.Text = "Nie wybrano pliku wynikowego";
                            saveStatusLabel.Visible = true;
                        }
                    }
                    
                }
            }
        }

        private void wybierzLokalizacjeButton_Click(object sender, EventArgs e)
        {
            wybierzLokalizacjeButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); // transparent
            wybierzLokalizacjeButton.FlatAppearance.BorderSize = 0;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop).ToString();
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                assistantLabel2.Text = saveFileDialog1.FileName;

                if((Path.GetFileName(saveFileDialog1.FileName)).Length > 15)
                {
                    string shortSaveFileName = (Path.GetFileName(saveFileDialog1.FileName)).Substring(0, 15) + "...";
                    saveStatusLabel.Text = shortSaveFileName;
                }
                else
                {
                    saveStatusLabel.Text = Path.GetFileName(saveFileDialog1.FileName);
                }
                
                wygenerujPlikButton.Visible = true;
            }
        }

        private void wygenerujPlikButton_Click(object sender, EventArgs e)
        {
            wygenerujPlikButton.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255); // transparent
            wygenerujPlikButton.FlatAppearance.BorderSize = 0;
            statusLabel.Visible = true;
            statusLabel.Refresh();
            //generateFile(assistantLabel.Text, assistantLabel2.Text);
            BindDataCSV(assistantLabel.Text, assistantLabel2.Text);
            statusLabel.Text = "Pomyślnie wygenerowano plik ";
            statusLabel.Refresh();
            
        }



    }
}
