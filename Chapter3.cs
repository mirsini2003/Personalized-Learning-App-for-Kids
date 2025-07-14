using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ergasia_logismikou
{
    public partial class Chapter3 : Form
    {
        string username;
        string password;
        public Chapter3(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
        }

        private void Chapter3_Load(object sender, EventArgs e)
        {
            οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem.Text = username;
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
        }

        private void αΡΧΙΚΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm(username,password).Show();
        }

        private void οΘρύλοςΤηςΚυράΦροσύνηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int unit = 1;
            new ContentForm(username, password, unit).Show();
        }

        private void ηΑρχιτεκτονικήΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int unit = 2;
            new ContentForm(username, password, unit).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Activity1(username,password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Activity2(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Activity3(username, password).Show();
        }

        private void οΛΕΣΟΙΕΝΟΤΗΤΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ActivityAll(username, password).Show();
        }

        private void πΗΓΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SourceForm(username, password).Show();
        }

        private void οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProfileForm(username, password).Show();
        }

        private void Chapter3_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label5.Text = "The Perama Cave, just a few kilometers from the city of Ioannina, is one of the most " +
                "impressive and well-preserved caves in Greece. It was discovered by chance during World War II, " +
                "when locals were seeking shelter from bombings. Since then, it has been systematically explored " +
                "and opened to the public, revealing an underground treasure that was formed around 1.5 million " +
                "years ago.The entrance to the cave is through the Goritsa hill, and visitors follow a well-lit and " +
                "carefully designed path that stretches for approximately 1, 100 meters.The temperature inside remains " +
                "constant, around 18 degrees Celsius, making the visit pleasant throughout the year.From the very " +
                "first steps, visitors feel as if they are entering another world — a quiet, enchanting place where " +
                "silence and the power of nature prevail.The cave is filled with stalactites, stalagmites, columns, " +
                "stone “curtains,” and other unique geological formations.At every turn of the path, impressive " +
                "chambers with spectacular scenery unfold.Each one has its own name, inspired by the formations it " +
                "contains — such as the “Hall of Persephone’s Palaces,” the “Catacomb,” the “Hall of the Cross,”" +
                " or the “Lily Pond.” The names are not random; often the formations resemble human figures, animals, " +
                "or mythical landscapes, allowing visitors to imagine stories carved in stone. One of the most " +
                "striking features of the cave is that it develops on three levels, something rare in Greece.Its " +
                "natural richness is combined with historical and paleontological significance: remains of the cave " +
                "bear(Ursus spelaeus) have been found inside, proving that the cave also served as a shelter for" +
                " animals during prehistoric times.The Perama Cave is a unique experience for every visitor – a " +
                "natural museum that reveals the grandeur of the Earth beneath the surface.It is not merely a " +
                "tourist attraction, but a living testament to the geological evolution of the region and the " +
                "relationship between humans and nature through the ages.";
            pictureBox2.Show();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Hide();
            label7.Text = "Perama Cave";
        }
        private void label2_Click(object sender, EventArgs e)
        {
            label5.Text = "Papigo is one of the most picturesque and impressive villages of Epirus, built in the " +
                "heart of the Pindus mountain range, within the Vikos–Aoos National Park. It is located at an altitude " +
                "of about 1,000 meters and is divided into two settlements: Megalo Papigo and Mikro Papigo, which are " +
                "about 3 kilometers apart, with the Voidomatis River flowing between them. Its location, set against " +
                "the backdrop of the imposing Towers of Astraka and with views of the Vikos Gorge, offers a magical " +
                "experience to every visitor.\r\n\r\nThe traditional character of the village has remained almost " +
                "untouched over time. The stone-built houses, cobbled streets, impressive churches, and village " +
                "squares shaded by centuries-old plane trees create an atmosphere that transports you to another " +
                "era. The architecture is characteristic of the Zagori style, with slate roofs and intricately built " +
                "stone pathways. At the same time, the locals proudly preserve their customs, traditions, and " +
                "heritage, offering warm hospitality to visitors.\r\n\r\nNature in Papigo is truly captivating." +
                " Many hiking trails start from here, the most famous of which leads to the Astraka mountain refuge " +
                "and ultimately to the Dragon Lake — an alpine landscape that seems almost unreal. This route is " +
                "ideal for nature lovers and photographers, as it passes through dense forests, alpine meadows, " +
                "and steep peaks. The Vikos Gorge, one of the deepest in the world, offers breathtaking views and " +
                "is easily accessible from Papigo.\r\n\r\nOne of the most unique natural attractions is the famous " +
                "“Kolymbithres” — small natural rock pools formed by the erosion of the rock from stream waters. In " +
                "summer, they become a magnet for those seeking to cool off in their crystal-clear waters, while in " +
                "every season they serve as an exceptional photo spot.\r\n\r\nDespite its popularity, Papigo retains " +
                "a calm and authentic character. It has not been overwhelmed by mass tourism, making it ideal for " +
                "those seeking an experience that combines tranquility, nature, and tradition. The guesthouses and" +
                " traditional accommodations in the village are tasteful, blending local architecture with modern " +
                "comforts. In the local taverns, visitors can enjoy authentic Epirote flavors such as pies, " +
                "spit-roasted meats, and local cheeses.\r\n\r\nPapigo is not just a tourist destination; it is a" +
                " place full of life, history, and natural grandeur. Each season reveals a different side of it — from " +
                "the snow-covered landscapes of winter to the blooming slopes of spring and the colorful forests of " +
                "autumn. It is a destination that inspires, relaxes, and enchants.";
            pictureBox2.Hide();
            pictureBox3.Show();
            pictureBox4.Hide();
            pictureBox5.Hide();
            label7.Text = "Papigo";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label5.Text = "The Vikos Gorge is one of the most awe-inspiring and spectacular natural landscapes " +
                "in Greece — and one of the deepest gorges in the world in terms of depth-to-width ratio, as recorded " +
                "in the Guinness Book of Records. It lies at the heart of the Vikos–Aoos National Park, in the center " +
                "of the Zagori region, and is an integral part of Epirus's unique natural and geological identity.The " +
                "gorge stretches for approximately 12 kilometers, with vertical cliffs that in some places exceed " +
                "1,000 meters in height.Its bed was mainly carved by the Voidomatis River, whose crystal - clear " +
                "waters emerge at the end of the gorge, near the village of Vikos.The journey through the gorge is " +
                "a natural marvel, filled with rare flora and fauna — from aromatic herbs and wildflowers to vultures, " +
                "eagles, and wild goats.It’s no coincidence that the area is designated as a protected Natura zone and " +
                "is considered one of the most important ecosystems in Europe. Hiking through the Vikos Gorge is a " +
                "once-in-a-lifetime experience.The most well-known trail starts from the village of Monodendri and " +
                "ends in the village of Vikos, or vice versa.The route takes about 5 to 6 hours and requires moderate" +
                " physical condition, but the reward is exceptional.Hikers move among steep cliffs, cross forests of " +
                "plane trees and maples, listen to birdsong, and feel the silence and majesty of nature. Each season " +
                "dresses the gorge in different colors: lush green in spring and summer, golden-red in autumn, and " +
                "eerily bare in winter. Equally impressive is the view of the gorge from above.The villages of " +
                "Monodendri, Vradeto, and Vikos offer panoramic viewpoints, the most famous being “Oxya” near " +
                "Monodendri — a breathtaking spot that reveals the depth and vastness of the gorge in all its glory." +
                "From Vradeto also begins the famous “Skala,” a spectacular stone-paved path descending toward the " +
                "bottom, offering magical scenery. The gorge also holds cultural significance, as the area has been " +
                "inhabited since antiquity.Local knowledge of the herbs and medicinal plants found in the gorge has " +
                "been preserved through the tradition of the “Vikoyiatroi” — folk healers who relied solely on nature " +
                "for their remedies. Τhe Vikos Gorge is not just a natural attraction; it is a living organism — an " +
                "open-air museum of geology, ecology, and culture.Those who visit are not only impressed by its beauty," +
                " but also feel a deep reverence for the power and wisdom of nature.Whether you view it from above or" +
                " hike its depths, this gorge always leaves you with the sense that you have encountered something" +
                " truly grand and pure.";
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Show();
            pictureBox5.Hide();
            label7.Text = "Vikos Gorge";
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label5.Text = "Metsovo is one of the most well-known and traditional mountain villages in Greece, built " +
                "amphitheatrically on the slopes of the Pindus Mountains at an altitude of approximately 1,200 meters." +
                " Located at the crossroads of Epirus, Thessaly, and Western Macedonia, it offers a unique blend of " +
                "natural beauty, vibrant tradition, and cultural richness. Whether you visit in winter or summer," +
                " Metsovo always leaves a strong impression with its charm, stone-built houses, surrounding forests, " +
                "and its distinct, authentic atmosphere.The village has largely preserved its traditional character. " +
                "Houses with wooden balconies, stone roofs and walls, cobbled alleys, fountains, and spacious squares " +
                "create a harmonious setting. The heart of the village beats in the central square, where plane trees, " +
                "taverns, and cafés bring locals and visitors together in an atmosphere of warmth and hospitality. " +
                "The presence of Vlach culture — a traditional nomadic group — is still strong, with the language, " +
                "songs, and customs surviving within modern life. Yet Metsovo is more than just a beautiful village; " +
                "it is a living cultural hub. Thanks to the support of benefactors such as Michael Tositsas, important" +
                " cultural institutions have been established: the Tositsa Foundation, the Averoff Gallery showcasing " +
                "works by 19th - and 20th - century Greek painters, the Tositsa Folklore Museum with rich collections " +
                "and reconstructions of traditional life, and the Katogi Averoff Winery, home to some of Greece’s " +
                "finest wines. The natural surroundings of Metsovo are equally impressive. The region's forests, the " +
                "peaks of the Pindus range, and the nearby artificial lake of Aoos Springs offer opportunities for " +
                "hiking, mountain biking, and winter sports. In the winter, Metsovo becomes a popular ski destination," +
                " with two ski resorts nearby — ideal for beginners and families. The mist, snow, and smoking chimneys " +
                "create a fairytale-like atmosphere. Metsovo’s culinary identity is among the richest in Greece.The " +
                "famous “Metsovone” — a smoked, hard cheese with Protected Designation of Origin(PDO) — is produced " +
                "exclusively here.In the local taverns, one can enjoy traditional pies, stews, wild boar, lamb, and " +
                "local wine.Hospitality is warm and genuine, with traditional guesthouses and hotels that respect the " +
                "environment and the aesthetics of the region. Metsovo is a destination that combines culture, nature, " +
                "tradition, and history. It is vibrant all year round, full of energy yet serene — a village that " +
                "honors its past while moving steadily toward the future without losing its soul. Whether you wish to " +
                "relax in a stone mansion overlooking the mountains, explore the secrets of the Pindus range, or get " +
                "to know an authentic Greek community up close, Metsovo will more than reward you.";
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
            pictureBox5.Show();
            label7.Text = "Metsovo";
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            this.Cursor= Cursors.Hand;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
        }

        private void γιαννιώτικεςΣυνταγέςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Recipes(username, password).Show();
        }
    }
}
