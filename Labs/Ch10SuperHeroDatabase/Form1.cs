using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Aaron McArdle
 * 
 * Create a GUI application to look up information about superheroes.
 *  - Program must conatin information about at least 5 superheroes.
 *  - Dropdown must be populated programmatically
 *  - Dropdown must conatin an option to select no superhero. (hint: null)
 *  - When the user selects an option from the dropdown, display all available information
 *  about that superhero.
 *  
 */
namespace Ch10SuperHeroDatabase
{
    public partial class FormSHDB : Form
    {
        public FormSHDB()
        {
            InitializeComponent();
        }

        // Declare and initialize program constants
        const int MAXELEMENTS = 6;  // Max Array Elements

        // Declare and initialize program arrays

        string[] images = { "C:\\Users\\Atomi\\Desktop\\AWD1100\\Labs\\Labs\\Ch10SuperHeroDatabase\\images\\openingimage.jpg",
                            "C:\\Users\\Atomi\\Desktop\\AWD1100\\Labs\\Labs\\Ch10SuperHeroDatabase\\images\\spiderman.jpg",
                            "C:\\Users\\Atomi\\Desktop\\AWD1100\\Labs\\Labs\\Ch10SuperHeroDatabase\\images\\doctorstrange.jpg",
                            "C:\\Users\\Atomi\\Desktop\\AWD1100\\Labs\\Labs\\Ch10SuperHeroDatabase\\images\\thor.jpg",
                            "C:\\Users\\Atomi\\Desktop\\AWD1100\\Labs\\Labs\\Ch10SuperHeroDatabase\\images\\ant-man.jpg",
                            "C:\\Users\\Atomi\\Desktop\\AWD1100\\Labs\\Labs\\Ch10SuperHeroDatabase\\images\\robin.jpg"
                          };
        string[] names = { "", "Spider-Man", "Doctor Strange", "Thor", "Ant-Man", "Robin" };
        string[] likes = { "", "Gwen Stacy", "Christine Palmer", "Jane Foster", "Cassie Lang", "Batman" };
        string[] dislikes = { "", "Green Goblin", "Dormammu", "Thanos", "Yellowjacket", "Tony Zucco" };
        string[] powers = { "", "Superhuman reflexes", "Magic", "Invulnerability", "Size Manipulation", "Expert Acrobat" };
        string[] bios = { "",
                          "Spider-Man is a fictional superhero created by writer-editor Stan Lee and writer-artist Steve Ditko. He first appeared in the anthology comic book Amazing Fantasy #15 (Aug. 1962) in the Silver Age of Comic Books.",
                          "Doctor Stephen Strange is a fictional character appearing in American comic books published by Marvel Comics. Created by artist Steve Ditko and writer Stan Lee,[5] the character first appeared in Strange Tales #110 (cover-dated July 1963).",
                          "Thor Odinson is a fictional superhero appearing in American comic books published by Marvel Comics. Debuting in the Silver Age of Comic Books, the character first appeared in Journey into Mystery #83 (August 1962).",
                          "Ant-Man is the name of several superheroes appearing in books published by Marvel Comics. Created by Stan Lee, Larry Lieber and Jack Kirby, Ant-Man's first appearance was in Tales to Astonish #35 (September 1962).",
                          "Robin is the alias of several fictional superheroes appearing in American comic books published by DC Comics. The character's first incarnation, Dick Grayson, debuted in Detective Comics #38 (April 1940)."
                        };
        string[] wiki = { "", 
                          "https://en.wikipedia.org/wiki/Spider-Man",
                          "https://en.wikipedia.org/wiki/Doctor_Strange",
                          "https://en.wikipedia.org/wiki/Thor_(Marvel_Comics)",
                          "https://en.wikipedia.org/wiki/Ant-Man",
                          "https://en.wikipedia.org/wiki/Robin_(character)"
                        };

        private void FormSHDB_Activated(object sender, EventArgs e)
        {
            for (int lcv = 0; lcv < MAXELEMENTS; ++lcv) {
                comboBoxSHName.Items.Add(names[lcv]);
                comboBoxSHName.SelectedIndex = 0;
            }
        }

        private void comboBoxSHName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxSHName.SelectedIndex;

            pictureBoxSH.Image = Image.FromFile(images[index]);
            lblSuperheroName.Text = names[index];
            lblLikesResult.Text = likes[index];
            lblDislikesResult.Text = dislikes[index];
            lblSuperpowerResult.Text = powers[index];
            lblBiographyResult.Text = bios[index];
            lblWikiLink.Text = wiki[index];
        }
    }
}
