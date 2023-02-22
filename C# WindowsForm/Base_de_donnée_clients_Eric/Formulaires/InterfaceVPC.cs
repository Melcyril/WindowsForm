using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulaires
{
    public partial class InterfaceVPC : Form
    {
        SqlConnection cnx = new SqlConnection(@"Data Source = DESKTOP-8JQ5N7I\SQLEXPRESS; Initial Catalog = vpc; Integrated Security = True");

        public InterfaceVPC()
        {
            InitializeComponent();
            InitialiserClients();
            DGV_Clients.Dock = DockStyle.Fill;
            DGV_Commandes.Dock = DockStyle.Fill;
            DGV_FACTURES.Dock = DockStyle.Fill;
            DGV_PAIEMENTS.Dock = DockStyle.Fill;
            DGV_PRODUITS.Dock = DockStyle.Fill;
            DGV_FOURNISSEURS.Dock = DockStyle.Fill;
            DGV_LIVRAISONS.Dock = DockStyle.Fill;
            DGV_STOCKS.Dock = DockStyle.Fill;
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem sdr = (ToolStripMenuItem)sender;
            sdr.BackColor = Color.DodgerBlue;
            sdr.ForeColor = Color.White;
            InitialiserClients();
            
        }

        private void InitialiserClients()
        {
            cnx.Open();
            SqlCommand cmd2 = new SqlCommand("select * from dbo.Client", cnx);
            cmd2.CommandType = CommandType.Text;

            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            cnx.Close();
            DGV_Clients.DataSource = dt;
           
            GestionAffichage(DGV_Clients);
        }

        private void AfficherFactures()
        {

            string idClient = LB_ID_CLIENT.Text;
            string req = "select * from dbo.Facture where IdClient=@IdClient";
            if (idClient == "*")
            {
                req = "select * from dbo.Facture order by DateCreation desc";
            }

            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(req, cnx);
            cmd2.CommandType = CommandType.Text;
            if (idClient != "*")
            {
                cmd2.Parameters.AddWithValue("@IdClient", Int32.Parse(idClient));
            }


            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            DGV_FACTURES.DataSource = dt;
            cnx.Close();
            GestionAffichage(DGV_FACTURES);
        }

        private void AfficherCommandes()
        {
            string idClient = LB_ID_CLIENT.Text;
            string req = "select * from dbo.Commande where IdClient=@IdClient";
            if (idClient == "*")
            {
                req = "select * from dbo.Commande order by DateCommande desc";
            }

            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(req, cnx);
            cmd2.CommandType = CommandType.Text;
            if (idClient != "*")
            {
                cmd2.Parameters.AddWithValue("@IdClient", Int32.Parse(idClient));
            }


            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            DGV_Commandes.DataSource = dt;
            cnx.Close();
            GestionAffichage(DGV_Commandes);

        }

        private void AfficherPaiements()
        {
            string idClient = LB_ID_CLIENT.Text;
            string req = "select * from dbo.Paiement where IdClient=@IdClient";
            if (idClient == "*")
            {
                req = "select * from dbo.Paiement order by DatePaiement desc";
            }

            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(req, cnx);
            cmd2.CommandType = CommandType.Text;
            if (idClient != "*")
            {
                cmd2.Parameters.AddWithValue("@IdClient", Int32.Parse(idClient));
            }


            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            DGV_PAIEMENTS.DataSource = dt;
            cnx.Close();

            GestionAffichage(DGV_PAIEMENTS);
        }

        private void AfficherProduits()
        {
            string idProduit = LB_ID_PRODUIT.Text;
            string req = "select * from dbo.Produit where IdProduit=@IdProduit";
            if (idProduit == "*")
            {
                req = "select * from dbo.Produit order by Designation";
            }

            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(req, cnx);
            cmd2.CommandType = CommandType.Text;
            if (idProduit != "*")
            {
                cmd2.Parameters.AddWithValue("@IdProduit", Int32.Parse(idProduit));
            }


            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            DGV_PRODUITS.DataSource = dt;
            cnx.Close();

            GestionAffichage(DGV_PRODUITS);
            
        }

        private void AfficherStocks()
        {
            string idProduit = LB_ID_PRODUIT.Text;
            string req = "select * from dbo.Stock where IdProduit=@IdProduit";
            if (idProduit == "*")
            {
                req = "select * from dbo.Stock order by IdProduit";
            }

            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(req, cnx);
            cmd2.CommandType = CommandType.Text;
            if (idProduit != "*")
            {
                cmd2.Parameters.AddWithValue("@IdProduit", Int32.Parse(idProduit));
            }


            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            DGV_PRODUITS.DataSource = dt;
            cnx.Close();
            GestionAffichage(DGV_STOCKS);
           
        }

        private void AfficherFournisseurs()
        {
            string idProduit = LB_ID_PRODUIT.Text;
            string req = "select * from dbo.Fournisseur";
            
            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(req, cnx);
            cmd2.CommandType = CommandType.Text;
           


            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            DGV_PRODUITS.DataSource = dt;
            cnx.Close();

            GestionAffichage(DGV_FOURNISSEURS);
           
        }
        private void AfficherLivraisons()
        {
            string req = "select * from dbo.Livraison";

            cnx.Open();
            SqlCommand cmd2 = new SqlCommand(req, cnx);
            cmd2.CommandType = CommandType.Text;



            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd2);
            adapter.Fill(dt);

            DGV_PRODUITS.DataSource = dt;
            cnx.Close();

            GestionAffichage(DGV_LIVRAISONS);
        }


        private void commandesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherCommandes();

        }

        private void facturesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherFactures();
        }

        private void paiementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherPaiements();
        }

        private void produitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherProduits();
        }

        private void stocksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherStocks();
        }

        private void fournisseursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherFournisseurs();
        }

        private void livraisonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfficherLivraisons();
        }

        private void DGV_Clients_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            LabelStatut.Text = "Réference Client sélectionné: "+dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

            int testID = 0;

            if(Int32.TryParse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),out testID)) { 
                LB_ID_CLIENT.Text = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                PL_CLIENT_DETAIL.Visible = true;
                AfficherCommandes();
                AfficherFactures();
                AfficherPaiements();
                DGV_Clients.Visible = false;
                DGV_Commandes.Visible = true;
                DGV_FACTURES.Visible = true;
                DGV_PAIEMENTS.Visible = true;
                DGV_Commandes.Height = PL_GDV.Height / 3;
                DGV_Commandes.Dock = DockStyle.Top;
                DGV_FACTURES.Height = PL_GDV.Height / 3;
                DGV_FACTURES.Dock = DockStyle.Top;
                DGV_PAIEMENTS.Height = PL_GDV.Height / 3;
                DGV_PAIEMENTS.Dock = DockStyle.Top;


            }
        }

        private void GestionAffichage(DataGridView dgv)
        {
            foreach (DataGridView item in PL_GDV.Controls)
            {
                if (item == dgv)
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        private void exporterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Coordonnees coordonnees = new Coordonnees();

            DataTable dtClient = (DataTable)DGV_Clients.DataSource;
            List<Coordonnee> liste=new List<Coordonnee>();
            bool testBoule = false;

            foreach (DataRow item in dtClient.Select())
            {
                Coordonnee coordonnee = new Coordonnee();
                coordonnee.IdClient = Int32.Parse(item["IdClient"].ToString());
                if(item["Sexe"]!=null && bool.TryParse(item["Sexe"].ToString(),out testBoule))
                {
                    coordonnee.Civilite = bool.Parse(item["Sexe"].ToString());
                }
                else
                {
                    coordonnee.Civilite = false;
                }
                coordonnee.NomClient = item["NomClient"].ToString();
                coordonnee.PrenomClient = item["PrenomClient"].ToString();
                if (item["Telephone"] != null) { 
                    coordonnee.telephone = item["Telephone"].ToString();
                }
                else
                {
                    coordonnee.telephone = "---";
                }
                if (item["DateNaissance"] != null)
                {
                    coordonnee.dateNaissance = DateTime.Parse(item["DateNaissance"].ToString());
                }
                else
                {
                    coordonnee.dateNaissance = DateTime.Now;
                }
                coordonnee.email = item["Email"].ToString();
                coordonnee.password = item["Password"].ToString();
                liste.Add(coordonnee);
            }

            coordonnees.ExportCSV(liste);
        }
    }
}
