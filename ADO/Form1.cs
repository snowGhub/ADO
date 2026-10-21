using System.Data;
using ADO.DAL;

namespace ADO
{
    public partial class Form1 : Form
    {

        CustRepo custRepo = new CustRepo();
        BindingSource bindingSource = new BindingSource();
        int aufruf = 0;

        public Form1()
        {
            InitializeComponent();

            LoadGenders();
            GenderBox.ClearSelected();
            LoadCustomers();

            // Grid, Combobox und Textbox hängen an derselben BindingSource -> Auswahl ist synchron
            CustomersList.DisplayMember = "FullName";
            CustomersList.ValueMember = "CustomerId";
            CustomersList.DataSource = bindingSource;

            CustomerId.DataBindings.Add("Text", bindingSource, "CustomerId");

            GenderBox.SelectedIndexChanged += GenderBox_SelectedIndexChanged;

            CustomersList.SelectedValueChanged += CL_SelectedValueChanged;
        }

        private void CL_SelectedValueChanged(object? sender, EventArgs e)
        {
            aufruf++;
            if (CustomersList.SelectedValue != null)
            {
                int customerId = (int)CustomersList.SelectedValue;
                DataRowView? rowView = bindingSource.List.Cast<DataRowView>().FirstOrDefault(r => (int)r["CustomerId"] == customerId);
                if (rowView != null)
                {
                    bindingSource.Position = bindingSource.IndexOf(rowView);
                }
            }

            Aufrufe.Text = $"Aufrufe: {aufruf}";
        }

        private void LoadGenders()
        {
            GenderBox.DisplayMember = "Title";
            GenderBox.ValueMember = "GenderId";
            GenderBox.DataSource = custRepo.getGenders();
        }

        private void LoadCustomers()
        {
            // Ohne Auswahl alle Kunden, sonst nach Geschlecht gefiltert
            DataTable dt;
            if (GenderBox.SelectedValue is int genderId)
                dt = custRepo.getCustomerByGender(genderId);
            else
                dt = custRepo.getCustomers();

            // Anzeigename fuer die Combobox
            dt.Columns.Add("FullName", typeof(string), "LName + ' ' + ISNULL(FName, '')");

            bindingSource.DataSource = dt;
            dataGridView1.DataSource = bindingSource;
            if (dataGridView1.Columns["FullName"] is DataGridViewColumn col)
                col.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object? sender, EventArgs e)
        {

        }

        private void GenderBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void button1_Click(object? sender, EventArgs e)
        {
            // Refresh the Genders, Auswahl beibehalten
            object? selected = GenderBox.SelectedValue;

            GenderBox.SelectedIndexChanged -= GenderBox_SelectedIndexChanged;
            LoadGenders();
            if (selected != null)
                GenderBox.SelectedValue = selected;
            else
                GenderBox.ClearSelected();
            GenderBox.SelectedIndexChanged += GenderBox_SelectedIndexChanged;

            LoadCustomers();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
