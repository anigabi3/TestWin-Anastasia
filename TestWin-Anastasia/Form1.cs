namespace TestWin_Anastasia
{
    public partial class fr1 : Form
    {
        public fr1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            DialogResult Natisnatbt = MessageBox.Show("Ne si izbral !", "Nadpis",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (Natisnatbt == DialogResult.Yes)
            {
                return;
            }
            string vidAvtor = "";
            string vidZaglavie = "";
            string vidIzdatelstvo = "";
            string vidJanr = "";
             
            if (!string.IsNullOrEmpty(cb1.Text))
            {
                vidIzdatelstvo = cb1.Text;

            }
            else
            {
                MessageBox.Show("Ne si izbral izdatelstvo!");
                cb1.Focus();
                return;
            }
            if (rb1.Checked) vidIzdatelstvo = rb1.Text;
            if (rb2.Checked) vidIzdatelstvo = rb2.Text;
            if (rb3.Checked) vidIzdatelstvo= rb3.Text;
            if (rb4.Checked) vidIzdatelstvo = rb4.Text;
            MessageBox.Show($"Ti izbra Avtor {vidAvtor} ",
                $"Ti izbra Zaglavie {vidZaglavie} ",
                $"Ti izbra Izdatelstvo {vidIzdatelstvo}," +
                $" " + $"\" Janr{vidJanr});
;
        }
    }
}