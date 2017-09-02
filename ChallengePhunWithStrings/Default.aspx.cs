using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengePhunWithStrings
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void reverseButton1_Click(object sender, EventArgs e)
        {
            // 1. Reverse contents of a textbox:

            nameLabel.Text = "";
            char[] name = nameTextBox.Text.ToCharArray();
            Array.Reverse(name);
            for (int i = 0; i < name.Length; i++)
            {
                nameLabel.Text += name[i];
            }
            nameTextBox.Text = "";
        }

        string[] heroNames = new String[] { "Luke", "Leia", "Han", "Chewbacca" };

        protected void reverseButton2_Click(object sender, EventArgs e)
        {
            // 2. Revers order of elements in an array: 

            string herosListReverse = "";
            for (int i = heroNames.Length - 1; i >= 0; i--)
            {
                herosListReverse += String.Format(heroNames[i] + ", ");
            }
            herosLabel.Text = herosListReverse.Remove(herosListReverse.Length - 2, 2);
        }

        protected void artButton_Click(object sender, EventArgs e)
        {
            // 3. Create ASCII art with elements in an array:

            string art = "";
            for (int i = 0; i < heroNames.Length; i++)
            {
                decimal length = (14 - heroNames[i].Length) / 2;
                Math.Floor(length);
                for (int j = 0; j < length; j++)
                {
                    art += "*";
                }
                string output = art + heroNames[i];
                artLabel.Text += String.Format(output.PadRight(14, '*') + "<br>");
                art = "";
            }
            
        }

        protected void solveButton_Click(object sender, EventArgs e)
        {
            // 4. Edit contents of a string:

            string quote = "NOW IS ZHEremove-me ZIME FOR ALL GOOD MEN ZO COME ZO ZHE AID OF ZHEIR COUNZRY.";
            string removeMe = "remove-me";

            int removeMeIndex = quote.IndexOf(removeMe);
            quote = quote.Remove(removeMeIndex, removeMe.Length);
            for (int i = 0; i < quote.Length; i++)
            {
                quote = quote.Replace("Z", "T");
            }
            char firstLetter = quote[0];
            quote = quote.Remove(0, 1);
            sentenceLabel.Text = String.Format(firstLetter + quote.ToLower());
        }
    }
}