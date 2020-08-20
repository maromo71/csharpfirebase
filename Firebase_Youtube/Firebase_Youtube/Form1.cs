using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp;
using FireSharp.Config;
using FireSharp.Extensions;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

/**
 * Documentação com vídeo 
 * Fonte: https://www.youtube.com/watch?v=jZMwwZHJXJc [Estabelecimento de Conexão]
 * Fonte: https://www.youtube.com/watch?v=_jB2iOgo_9Q [Inserção de registros novos]
 * Fonte: https://www.youtube.com/watch?v=Ryrkh0wSBTE [Recuperação de registros]
 * Fonte: https://www.youtube.com/watch?v=DWyi7GH9Pgw [Atualização de registros]
 * Fonte: https://www.youtube.com/watch?v=cbZTx3ykEVA [Excluindo um ou mais registros]
 * Fonte: https://www.youtube.com/watch?v=b67v2loMYzU [Banco | Recuperando e exportando dados de/ou para o Datagridview]
 * Fonte: https://www.youtube.com/watch?v=ZOpDnN2I6qw [Não usei, mas para incluir uma imagem em binário]
 * 
 */

namespace Firebase_Youtube
{
    public partial class Form1 : Form
    {

        readonly IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "wNn8l7RHsMNyHoCA6YrZuklAQabXvqy8LY8aEl8h",
            BasePath = "https://fir-e398d.firebaseio.com/"
        };

        IFirebaseClient client;


        public Form1()
        {
            InitializeComponent();

        }

        private void carregarGrid()
        {
            FirebaseResponse resp = client.Get("Information/");
            dynamic contacts = JsonConvert.DeserializeObject(resp.Body.ToString());
            var lista = new List<Data>();
            foreach (var contact in contacts)
            {
                if (contact != null)
                {
                    Data data = new Data();
                    data.Id = contact.Id;
                    data.Name = contact.Name;
                    data.Address = contact.Address;
                    data.Age = contact.Age;
                    lista.Add(data);
                }
            }
            dataContacts.DataSource = lista;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new FirebaseClient(config);
            carregarGrid();
            if (client != null)
            {
                MessageBox.Show("Conexão estabelecida..");
            }
            else
            {
                MessageBox.Show("Não foi possível estabelecer conexão");
            }
        }

        private async void ButtonInsert_Click(object sender, EventArgs e)
        {
            FirebaseResponse resp = await client.GetTaskAsync("Counter/node");
            //Buscar o ultimo id (node/Last)
            Counter get = resp.ResultAs<Counter>();

            var data = new Data
            {
                Id = (Convert.ToInt32(get.Last) + 1).ToString(),
                Name = TextName.Text,
                Address = TextAddress.Text,
                Age = TextAge.Text
            };
            SetResponse response = await client.SetTaskAsync("Information/" + data.Id, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Dado inserido - ID: " + result.Id);

            var obj = new Counter
            {
                Last = data.Id
            };
            SetResponse reponse1 = await client.SetTaskAsync("Counter/node", obj);


            ClearFields();
        }


        private async void ButtonRetrive_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Information/" + TextID.Text);
            Data obj = response.ResultAs<Data>();
            TextName.Text = obj.Name;
            TextAddress.Text = obj.Address;
            TextAge.Text = obj.Age;

            MessageBox.Show("Dados Recuperados com sucesso");
        }

        private async void ButtonUpdate_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = TextID.Text,
                Name = TextName.Text,
                Address = TextAddress.Text,
                Age = TextAge.Text
            };

            FirebaseResponse response = await client.UpdateTaskAsync("Information/" + TextID.Text, data);
            Data result = response.ResultAs<Data>();
            MessageBox.Show("Dados atualizados com sucesso, ID", result.Id);
            ClearFields();

        }

        private async void ButtonDelete_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + TextID.Text);
            MessageBox.Show("Deleted Element ID: " + TextID.Text);
            ClearFields();
        }



        private void ClearFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox textBox = (TextBox)control;
                    textBox.Clear();
                }
            }
            carregarGrid();
        }

        private async void ButtonDeleteAll_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information");
            MessageBox.Show("Deleted All Elements ", response.ToString());
            ClearFields();

        }
    }
}
