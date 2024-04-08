using LibraryPrototype_v1.Assets;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace LibraryPrototype_v1
{
    internal class Character
    {
        public string FirstName { get; protected set; }
        public string? LastName { get; protected set; }
        public int Age { get; protected set; }
        public string Gender { get; protected set; }
        public ConsoleColor Color { get; protected set; }
        public string Art { get; protected set; }

        public Character(
            string firstName, 
            string? lastName, 
            int age, 
            string gender, 
            ConsoleColor color
        ) 
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Gender = gender;

            // todo: randomize color
            this.Color = color;
            this.Art = GetArtAsset();
        }

        public virtual void Interact()
        {
            ForegroundColor = this.Color;
            WriteLine($"{this.FirstName} is interacting...\n");
            ResetColor();
        }

        public void DisplayInfo()
        {
            WriteLine();
            BackgroundColor = this.Color;
            Write($"--- {this.FirstName} ---");
            ResetColor();
            WriteLine($"\n\n{this.GetType()}\n");

            ForegroundColor = this.Color;
            WriteLine($"{this.Art}");
            ResetColor();
            WriteLine();
        }

        private string GetArtAsset()
        {
            if (this.Gender == "Female")
            {
                return ArtAssets.Lady1;
            }
            else
            {
                List<string> artAssets = new List<string>
                {
                    ArtAssets.Dude1,
                    ArtAssets.Dude2,
                    ArtAssets.Dude3,
                };

                // Create an instance of Random class
                Random random = new Random();

                // Generate a random index within the range of the list

                // Note: maxValue (in this case 3) is excluded,
                // so randomIndex will only ever be 0, 1, or 2.
                int i = random.Next(0, artAssets.Count);

                // Retrieve the string at the random index
                string randomAsset = artAssets[i];

                return randomAsset;
            }
        }
    }
}
