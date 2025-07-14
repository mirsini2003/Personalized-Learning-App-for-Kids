using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ergasia_logismikou
{
    public partial class Recipes : Form
    {
        string username;
        string password;
        public Recipes(string username, string password)
        {
            InitializeComponent();
            this.username = username;
            this.password = password;
            
        }

        private void αΡΧΙΚΗToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new HomeForm(username, password).Show();
        }

        private void οΘρύλοςΤηςΚυράΦροσύνηςToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int unit = 1;
            this.Hide();
            new ContentForm(username, password, unit).Show();
        }

        private void ηΑρχιτεκτονικήΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {

            int unit = 2;
            this.Hide();
            new ContentForm(username, password, unit).Show();
        }

        private void μέσαΑπόΤαΜονοπάτιαΤωνΙωαννίνωνToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Chapter3(username, password).Show();
        }

        private void ηΕΝΟΤΗΤΑToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Activity1(username, password).Show();
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

        private void Recipes_Load(object sender, EventArgs e)
        {
            οΝΟΜΑΧΡΗΣΤΗToolStripMenuItem.Text = username;
            label6.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label6.Show();
            label6.Text = "Yianniotikes Tiganites ";
            label7.Text = "Ingredients\r\n• 220 g all-purpose flour\r\n• 1 large egg\r\n• 80 ml water\r\n• 100 ml milk\r\n" +
    "• 1 tbsp tsipouro (optional)\r\n• 80 g crumbled feta cheese\r\n• Olive oil for frying\r\n• Honey or sugar (for serving)\r\n\r\n" +

    "Instructions\r\n\r\nStep 1: Make the batter.\r\nIn a bowl, add all the ingredients except the feta. Mix well until combined. " +
    "The batter should be fairly runny. If needed, add a bit more water.\r\n\r\n" +

    "Step 2: Fry the pancakes.\r\nPour olive oil into a frying pan to cover the bottom and heat it up. Use a large spoon to pour " +
    "batter into the pan, forming pancakes. Let them brown on one side, then flip them. Remove from the pan and let them rest briefly " +
    "on paper towels.\r\n\r\n" +

    "Step 3: Make the savory ones.\r\nAdd the crumbled feta to the remaining batter and fry in the same way.";

        }

        private void label3_Click(object sender, EventArgs e)
        {
            label6.Show();
            label6.Text = "Galatopita";
            label7.Text = "Ingredients\r\nFor the custard:\r\n• 1 liter milk\r\n• 160 g fine semolina\r\n• 100 g sugar\r\n" +
                "• 2 eggs\r\n• 1 tbsp butter\r\n• 1 tsp vanilla extract\r\n\r\nFor the phyllo layers:\r\n• 8 sheets phyllo dough\r\n" +
                "• 80 g melted butter\r\n• 4 tbsp sugar\r\n• 3 tbsp cinnamon\r\n• Powdered sugar (for serving)\r\n\r\n" +

                "Instructions\r\nPreheat the oven to 180°C (350°F)\r\n\r\nIn a large pot, heat the milk (do not let it boil), then slowly add " +
                "the semolina like a steady rain. Stir constantly over medium heat to prevent lumps, until the mixture slightly thickens. " +
                "Remove from heat and let it cool slightly.\r\n\r\nIn a separate bowl, beat the eggs with the sugar and vanilla. Gradually stir " +
                "the egg mixture into the pot with the semolina and milk. Return the pot to medium heat and continue stirring until the cream " +
                "becomes smooth and fairly thick, like a light béchamel. Add the butter at the end.\r\n\r\nIn a small bowl, mix the sugar with the " +
                "cinnamon. Melt the butter for brushing the phyllo sheets.\r\n\r\nButter a round baking pan (30–33 cm diameter). Lay down the " +
                "first phyllo sheet, brush with melted butter, and sprinkle with a tablespoon of the cinnamon-sugar mixture. Repeat this " +
                "process for three more phyllo sheets, letting them hang over the edges of the pan.\r\n\r\nPour in the custard. Place the remaining " +
                "4 phyllo sheets on top, brushing each one with butter and sprinkling with cinnamon sugar in between. For the top sheet, brush " +
                "with butter and sprinkle with 2–3 tablespoons of water to help it crisp up.\r\n\r\nFold and twist the overhanging phyllo edges " +
                "inward, creating a decorative rim.\r\n\r\nBake for 45–50 minutes, until golden. Once cooled, dust with powdered sugar and cinnamon.";

        }

        private void label4_Click(object sender, EventArgs e)
        {
            label6.Show();
            label6.Text = "Zimaropita";
            label7.Text = "Ingredients\r\n• 16 tbsp all-purpose flour\r\n• 2 cups milk\r\n• 2 cups water\r\n• 1 cup olive oil\r\n" +
                "• 2 tbsp butter\r\n• 3 eggs\r\n• 300 g feta cheese\r\n• 1 tsp salt\r\n\r\n" +
                "Instructions\r\nPreheat the oven to 250°C (480°F). Butter a shallow baking tray (the oven’s sheet pan is ideal), " +
                "add half of the olive oil, and place it in the oven to heat.\r\n\r\n" +
                "In a large bowl, sift the flour and add 2 of the eggs, the milk, water, and salt. Whisk until smooth and well combined. " +
                "Add two-thirds of the crumbled feta cheese. The batter should be runny — if needed, add a bit more water or milk.\r\n\r\n" +
                "Pour the batter into the hot pan. Crumble the remaining feta cheese over the top. Drizzle the rest of the olive oil " +
                "on the surface. Beat the third egg and pour it evenly over the pie.\r\n\r\n" +
                "Reduce the oven temperature to 180°C (350°F) and bake for about 45 minutes.\r\n\r\n" +
                "The pie will not rise — it should come out thin and crispy like a pizza crust. Ideally, the thickness should not exceed 1 centimeter.";

        }

        private void label5_Click(object sender, EventArgs e)
        {
            label6.Show();
            label6.Text = "Meatballs with Leeks";
            label7.Text = "Ingredients\r\n• 1 kg leeks\r\n• 1 bunch celery\r\n• 1 cup tomato juice\r\n• 1 cup olive oil\r\n" +
                "• Salt\r\n• Sweet red pepper\r\n\r\nIngredients for the meatballs\r\n• 500 g ground beef\r\n• 500 g ground lamb\r\n" +
                "• 1 bunch parsley\r\n• 2 onions\r\n• 3 eggs\r\n• 1/2 wine glass sour trahana\r\n• Salt\r\n• Red pepper\r\n• Oregano\r\n\r\n" +
                "Instructions\r\nWash the leeks and celery well. Finely chop the celery and slice the leeks into rounds. In a pot, add the leeks " +
                "and let them steam for a while. Then add the celery, olive oil, tomato juice, 1 tsp red pepper, and 1 glass of water. Simmer for about 30 minutes.\r\n\r\n" +
                "For the meatballs: Grate or finely chop the onions and parsley (using a food processor or by hand). Lightly beat the eggs. In a large bowl, combine " +
                "both types of ground meat, the eggs, onion, parsley, and the rest of the ingredients. Knead until well mixed.\r\n" +
                "Add the sour trahana, 1 tsp red pepper, 1 tsp oregano, and 1 tsp salt. Knead well so the mixture is smooth and all ingredients are evenly distributed.\r\n" +
                "Shape the meat into meatballs the size of your palm. Lightly flour them, shake off the excess, and place them side by side over the simmering leeks.\r\n" +
                "Cover the pot and let the dish simmer for about 45 minutes. Optionally, turn the meatballs halfway through to cook evenly. The leeks will release their own juices, " +
                "but if needed, add a little hot water. The dish should end up with a natural, thick sauce.";

        }

        private void Recipes_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void οΛΕΣΟΙΕΝΟΤΗΤΕΣToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ActivityAll(username, password).Show();
        }
    }
}
