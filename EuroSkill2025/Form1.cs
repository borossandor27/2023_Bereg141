using Newtonsoft.Json.Linq;
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
using EuroSkill2025;

namespace EuroSkill2025
{

    /*
     *  backend letöltése:
     *    npm i -g json-server
     *  
     *  Szerver indítása:
     *      json-server database.json
     *    
     */
    public partial class Form1 : Form
    {
        private HttpClient client;
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            client = new HttpClient();
            listBox_Containers.DisplayMember = "Id";
            listBox_Containers.Sorted = true;

            //-- Konténer lista betöltése
            await kontenerListaFrissitese();
        }

        private async Task kontenerListaFrissitese()
        {
            string urlContainers = "http://localhost:3000/containers";
            listBox_Containers.Items.Clear();
            try
            {
                HttpResponseMessage response = await client.GetAsync(urlContainers);
                if (response.IsSuccessStatusCode)
                {
                    //-- Válasz szöveg tárolása JSON formátumban
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    //-- szöveg átalakítása JSON tömbbé
                    JArray containers = (JArray)Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(jsonResponse);
                    //-- Konténerek listába helyezése
                    listBox_Containers.Items.AddRange(containers.ToObject<Container[]>());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt: " + ex.Message);
            }
        }
    }
}
