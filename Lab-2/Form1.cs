using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        private Pokedex1 pokedex;
        public Form1()
        {
            InitializeComponent();
            pokedex = new Pokedex1();
            //pokedex.Pokemons.Add(new Pokemon() { Name = "Raichu", Height = 8, Weight = 300 });
            //pokedex.Pokemons.Add(new Pokemon() { Name = "Zapdos", Height = 16, Weight = 526 });
            //pokedex.Pokemons.Add(new Pokemon() { Name = "Jolteon", Height = 8, Weight = 245 });
            pokedex.SaveChanges();


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string call = "https://pokeapi.co/api/v2/pokemon/mewtwo";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(response);
            listBox1.Items.Add("Pokemon name: " + pokemon.Name);
            listBox1.Items.Add("Pokemon height: " + pokemon.Height);
            listBox1.Items.Add("Pokemon weigth: " + pokemon.Weight);
            listBox2.Items.Add("Abilites of pokemon: " + pokemon.Name);
            foreach (var ability in pokemon.Abilities)
            {

                listBox2.Items.Add(ability.ability.Name);
            }

        }

        private async void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string call = "https://pokeapi.co/api/v2/pokemon/pikachu";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(response);
            listBox1.Items.Add("Pokemon name: " + pokemon.Name);
            listBox1.Items.Add("Pokemon height: " + pokemon.Height);
            listBox1.Items.Add("Pokemon weigth: " + pokemon.Weight);
            listBox2.Items.Add("Abilites of pokemon: " + pokemon.Name);
            foreach (var ability in pokemon.Abilities)
            {

                listBox2.Items.Add(ability.ability.Name);
            }

        }

        private async void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string call = "https://pokeapi.co/api/v2/pokemon/charizard";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(response);
            listBox1.Items.Add("Pokemon name: " + pokemon.Name);
            listBox1.Items.Add("Pokemon height: " + pokemon.Height);
            listBox1.Items.Add("Pokemon weigth: " + pokemon.Weight);
            listBox2.Items.Add("Abilites of pokemon: " + pokemon.Name);
            foreach (var ability in pokemon.Abilities)
            {

                listBox2.Items.Add(ability.ability.Name);
            }
        }

        private async void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string call = "https://pokeapi.co/api/v2/pokemon/gyarados";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(response);
            listBox1.Items.Add("Pokemon name: " + pokemon.Name);
            listBox1.Items.Add("Pokemon height: " + pokemon.Height);
            listBox1.Items.Add("Pokemon weigth: " + pokemon.Weight);
            listBox2.Items.Add("Abilites of pokemon: " + pokemon.Name);
            foreach (var ability in pokemon.Abilities)
            {

                listBox2.Items.Add(ability.ability.Name);
            }
        }

        private async void button5_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string call = "https://pokeapi.co/api/v2/pokemon/alakazam";
            HttpClient client = new HttpClient();
            string response = await client.GetStringAsync(call);
            var pokemon = JsonConvert.DeserializeObject<Pokemon>(response);
            listBox1.Items.Add("Pokemon name: " + pokemon.Name);
            listBox1.Items.Add("Pokemon height: " + pokemon.Height);
            listBox1.Items.Add("Pokemon weigth: " + pokemon.Weight);
            listBox2.Items.Add("Abilites of pokemon: " + pokemon.Name);
            foreach (var ability in pokemon.Abilities)
            {

                listBox2.Items.Add(ability.ability.Name);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            var pokemons = pokedex.Pokemons.ToList();
            foreach(var pokemon in pokemons)
            {
                listBox3.Items.Add("Pokemon name: " + pokemon.Name);
                listBox3.Items.Add("Pokemon height: " + pokemon.Height);
                listBox3.Items.Add("Pokemon weigth: " + pokemon.Weight);
            }
        }
    }
}