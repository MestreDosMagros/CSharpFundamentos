using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidacaoDeStrings
{
    public partial class Form1 : Form
    {
        public List<Teste> list = new List<Teste> { new Teste { Id = 1, Nome = "Daniel" }, new Teste { Id = 2, Nome = "Felipe" } };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            list.Add(new Teste { Id = 3, Nome = "teste" });
            dataGridView1.Update();
            dataGridView1.Refresh();
        }
    }

    public class Teste
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
