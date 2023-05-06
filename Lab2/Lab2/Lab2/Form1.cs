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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
            foreach (var ability in pokemon.Abilities )
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

    }
}
