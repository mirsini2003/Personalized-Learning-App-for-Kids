using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Speech.Synthesis;
using SpeechLib;

namespace ergasia_logismikou
{
    public partial class ContentForm : Form
    {
        SoundPlayer sound = new SoundPlayer();
        string username;
        string password;
        private string file;
        int unit;
        SpeechSynthesizer synth;
        public ContentForm(string username, string password,int unit)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            this.unit = unit;
            this.AutoScroll = true;
            synth=new SpeechSynthesizer();
           
        }

        private void αΡΧΙΚΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new HomeForm(username, password).Show();
        }

      

        private void πΗΓΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new SourceForm(username, password).Show();
        }

        private void οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new ProfileForm(username, password).Show();
        }

        private void ContentForm_Load(object sender, EventArgs e) // εδώ θα αλλάζω λαβελ και εικόνες ανάλογα με την ενότητα
        {
            οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem.Text = username;
            if (unit == 1)
            {
                this.Text="THE LEGEND OF KYRA-FROSINI";
                unitTitle.Text = "1. The legend of Kyra-Frosini";
                unitText.Text = "Kyra Frosyni, whose full name was Efrosyni Vassileiou, was a woman who lived in " +
                    "Ioannina at the end of the 18th century and entered history as a symbol of unjustly lost beauty, " +
                    "pride, and dignity. She belonged to the city’s wealthy urban class, was educated, intelligent, " +
                    "influential within her social circle, and deeply beloved for her kindness and integrity." +
                    "\r\n\r\nAccording to the most well-known version of the legend, Frosyni was romantically " +
                    "involved with Muhtar Pasha, the son of the powerful regional ruler, Ali Pasha of Ioannina. " +
                    "Their relationship was considered scandalous for the time, as Frosyni was married and the mother " +
                    "of two children, while her involvement with Ali Pasha’s family sparked gossip and disapproval " +
                    "throughout the city.\r\n\r\nAli Pasha, notorious for his ruthlessness and desire to maintain full " +
                    "control over the political and social life of Ioannina, allegedly saw Frosyni’s influence—and " +
                    "perhaps her \"defiance\"—as a threat. Wanting to set a moral “example,” particularly for the " +
                    "women of the city, he decided to punish her as a means of reinforcing submission.\r\n\r\nOn a " +
                    "freezing morning in 1801, without a formal trial and through a summary procedure, Kyra Frosyni " +
                    "and 17 other women of Ioannina were accused of “immoral behavior.” Most of these women were young," +
                    " beautiful, and held social standing. On Ali Pasha’s orders, they were tied up in sacks and thrown" +
                    " alive into the icy waters of Lake Pamvotida. The execution was carried out secretly at night, " +
                    "to terrorize the population and preserve “order.”\r\n\r\nFrosyni’s tragic death shocked the local " +
                    "community. The people did not view the act as the rightful punishment of immoral women, but as " +
                    "a brutal and unjust massacre—one that exposed the tyranny and cruelty of Ali Pasha. Over time, " +
                    "Kyra Frosyni became a folk heroine and martyr, embodying female pride and the tragic fate of " +
                    "the innocent.\r\n\r\nHer story inspired songs, poems, theatrical plays, and folk legends. The " +
                    "most notable literary work about her is the tragedy “Kyra Frosyni” by Alexandros Rizos Rangavis. " +
                    "To this day, local tradition holds that her ghost roams above the lake—especially when a thick " +
                    "mist falls—and that her soul seeks justice in the dark waters that claimed her.\r\n\r\nThus, " +
                    "Lake Pamvotida, once a natural landmark, has become a place of memory and sorrow. The name of " +
                    "Frosyni lives on in local lore—more as a symbol of resistance and female dignity than as a victim" +
                    " of forbidden love.";
                pictureBox1.Show();
                pictureBox2.Hide();
                pictureBox3.Hide();
                pictureBox4.Hide();
            }
            else if (unit == 2)
            {
                this.Text = "THE ARCHITECTURE OF IOANNINA";
                unitTitle.Text = "2. The Architecture of Ioannina";
                unitText.Text = "The architecture of Ioannina is a living imprint of the city’s long and " +
                    "multicultural history. Positioned at the crossroads of East and West, its geographical " +
                    "location fostered the coexistence of different cultures and architectural movements. The " +
                    "cityscape is shaped by a unique blend of Byzantine, Ottoman, traditional Epirus, and neoclassical " +
                    "elements that reflect Ioannina’s rich cultural identity.\r\n\r\nAt the heart of the city stands " +
                    "the Castle of Ioannina, the oldest Byzantine castle in Greece (dating back to the 6th century AD)," +
                    " which served for centuries as the administrative and cultural center of the region. Within its " +
                    "walls, important structures have been preserved, such as Its Kale (the inner citadel), the palace" +
                    " of Ali Pasha, and iconic Ottoman mosques like the Fethiye Mosque—prime examples of Islamic " +
                    "architecture.\r\n\r\nThe Ottoman period left a strong mark on the city’s urban fabric: hammams " +
                    "(public baths), tekkes (Sufi lodges), cobbled alleys, and houses with wooden “sachnisia” " +
                    "(upper-story bay windows) reveal the everyday life and aesthetic of that era. Ottoman buildings " +
                    "are characterized by functionality, symmetry, and modest decoration, with a focus on interior " +
                    "courtyards and communal spaces.\r\n\r\nAt the same time, Ioannina experienced significant " +
                    "cultural growth in the 18th and 19th centuries, as reflected in the appearance of neoclassical " +
                    "buildings. Structures like the Zosimaia School, the Kaplaneios School, the Pyrsinella Mansion, " +
                    "and other educational and administrative institutions showcase the European influence on " +
                    "architecture and education. These influences were introduced primarily by affluent merchants " +
                    "and intellectuals from Epirus who had studied or lived abroad.\r\n\r\nOf particular interest is " +
                    "the Jewish quarter of the Romaniote Jews, which features distinctive stone houses with simple, " +
                    "practical design and the imposing synagogue—one of the most important monuments of its kind in " +
                    "Greece.\r\n\r\nA unifying element in all architectural styles is the use of local materials: " +
                    "native stone, wood, and slate (used for roofing) dominate both the city and its surroundings," +
                    " linking the architecture directly to the natural landscape of Epirus. Traditional Ioannina " +
                    "houses, especially in the old town, are often two-storied with internal wooden beams, small " +
                    "windows, and central courtyards.\r\n\r\nThus, the architecture of Ioannina is not merely " +
                    "aesthetic—it is identity, memory, and testimony to the region’s history. It is the mirror of a " +
                    "society that existed between empires, religions, languages, and cultures—and managed to" +
                    " transform them into a unified, multifaceted architectural landscape that continues to impress " +
                    "and move every visitor.";
                pictureBox1.Hide();
                pictureBox2.Show();
                pictureBox3.Hide();
                pictureBox4.Hide();
            }
            else if (unit == 3)
            {
                
                pictureBox1.Hide();
                pictureBox2.Hide();
                pictureBox3.Show();
                pictureBox4.Show();
            }

        }

        private void ContentForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void οΘρύλοςΤηςΚυράΦροσύνηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            unitTitle.Text = "1. The legend of Kyra-Frosini";
            unitText.Text = "Kyra Frosyni, whose full name was Efrosyni Vassileiou, was a woman who lived in " +
                    "Ioannina at the end of the 18th century and entered history as a symbol of unjustly lost beauty, " +
                    "pride, and dignity. She belonged to the city’s wealthy urban class, was educated, intelligent, " +
                    "influential within her social circle, and deeply beloved for her kindness and integrity." +
                    "\r\n\r\nAccording to the most well-known version of the legend, Frosyni was romantically " +
                    "involved with Muhtar Pasha, the son of the powerful regional ruler, Ali Pasha of Ioannina. " +
                    "Their relationship was considered scandalous for the time, as Frosyni was married and the mother " +
                    "of two children, while her involvement with Ali Pasha’s family sparked gossip and disapproval " +
                    "throughout the city.\r\n\r\nAli Pasha, notorious for his ruthlessness and desire to maintain full " +
                    "control over the political and social life of Ioannina, allegedly saw Frosyni’s influence—and " +
                    "perhaps her \"defiance\"—as a threat. Wanting to set a moral “example,” particularly for the " +
                    "women of the city, he decided to punish her as a means of reinforcing submission.\r\n\r\nOn a " +
                    "freezing morning in 1801, without a formal trial and through a summary procedure, Kyra Frosyni " +
                    "and 17 other women of Ioannina were accused of “immoral behavior.” Most of these women were young," +
                    " beautiful, and held social standing. On Ali Pasha’s orders, they were tied up in sacks and thrown" +
                    " alive into the icy waters of Lake Pamvotida. The execution was carried out secretly at night, " +
                    "to terrorize the population and preserve “order.”\r\n\r\nFrosyni’s tragic death shocked the local " +
                    "community. The people did not view the act as the rightful punishment of immoral women, but as " +
                    "a brutal and unjust massacre—one that exposed the tyranny and cruelty of Ali Pasha. Over time, " +
                    "Kyra Frosyni became a folk heroine and martyr, embodying female pride and the tragic fate of " +
                    "the innocent.\r\n\r\nHer story inspired songs, poems, theatrical plays, and folk legends. The " +
                    "most notable literary work about her is the tragedy “Kyra Frosyni” by Alexandros Rizos Rangavis. " +
                    "To this day, local tradition holds that her ghost roams above the lake—especially when a thick " +
                    "mist falls—and that her soul seeks justice in the dark waters that claimed her.\r\n\r\nThus, " +
                    "Lake Pamvotida, once a natural landmark, has become a place of memory and sorrow. The name of " +
                    "Frosyni lives on in local lore—more as a symbol of resistance and female dignity than as a victim" +
                    " of forbidden love.";
            pictureBox1.Show();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void ηΑρχιτεκτονικήΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            unitTitle.Text = "2. The Architecture of Ioannina";
            unitText.Text = "The architecture of Ioannina is a living imprint of the city’s long and " +
                    "multicultural history. Positioned at the crossroads of East and West, its geographical " +
                    "location fostered the coexistence of different cultures and architectural movements. The " +
                    "cityscape is shaped by a unique blend of Byzantine, Ottoman, traditional Epirus, and neoclassical " +
                    "elements that reflect Ioannina’s rich cultural identity.\r\n\r\nAt the heart of the city stands " +
                    "the Castle of Ioannina, the oldest Byzantine castle in Greece (dating back to the 6th century AD)," +
                    " which served for centuries as the administrative and cultural center of the region. Within its " +
                    "walls, important structures have been preserved, such as Its Kale (the inner citadel), the palace" +
                    " of Ali Pasha, and iconic Ottoman mosques like the Fethiye Mosque—prime examples of Islamic " +
                    "architecture.\r\n\r\nThe Ottoman period left a strong mark on the city’s urban fabric: hammams " +
                    "(public baths), tekkes (Sufi lodges), cobbled alleys, and houses with wooden “sachnisia” " +
                    "(upper-story bay windows) reveal the everyday life and aesthetic of that era. Ottoman buildings " +
                    "are characterized by functionality, symmetry, and modest decoration, with a focus on interior " +
                    "courtyards and communal spaces.\r\n\r\nAt the same time, Ioannina experienced significant " +
                    "cultural growth in the 18th and 19th centuries, as reflected in the appearance of neoclassical " +
                    "buildings. Structures like the Zosimaia School, the Kaplaneios School, the Pyrsinella Mansion, " +
                    "and other educational and administrative institutions showcase the European influence on " +
                    "architecture and education. These influences were introduced primarily by affluent merchants " +
                    "and intellectuals from Epirus who had studied or lived abroad.\r\n\r\nOf particular interest is " +
                    "the Jewish quarter of the Romaniote Jews, which features distinctive stone houses with simple, " +
                    "practical design and the imposing synagogue—one of the most important monuments of its kind in " +
                    "Greece.\r\n\r\nA unifying element in all architectural styles is the use of local materials: " +
                    "native stone, wood, and slate (used for roofing) dominate both the city and its surroundings," +
                    " linking the architecture directly to the natural landscape of Epirus. Traditional Ioannina " +
                    "houses, especially in the old town, are often two-storied with internal wooden beams, small " +
                    "windows, and central courtyards.\r\n\r\nThus, the architecture of Ioannina is not merely " +
                    "aesthetic—it is identity, memory, and testimony to the region’s history. It is the mirror of a " +
                    "society that existed between empires, religions, languages, and cultures—and managed to" +
                    " transform them into a unified, multifaceted architectural landscape that continues to impress " +
                    "and move every visitor.";
            pictureBox1.Hide();
            pictureBox2.Show();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void μέσαΑπόΤαΜονοπάτιαΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Chapter3(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Activity1(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Activity2(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Activity3(username, password).Show();
        }

        private void pictureBox_speak_Click(object sender, EventArgs e)
        {
            synth.SpeakAsync(unitText.Text);
            
        }

        private void pictureBox_stop_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
        }

        private void γιαννιώτικεςΣυνταγέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new Recipes(username, password).Show();
        }

        private void οΛΕΣΟΙΕΝΟΤΗΤΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            synth.SpeakAsyncCancelAll();
            this.Hide();
            new ActivityAll(username, password).Show();
        }
    }
}
