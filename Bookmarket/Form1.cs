namespace Bookmarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            double num1;
            double num2 = 0;
            double num3 = 0;
            if (TypeBox.SelectedItem.ToString() == "Manga")
            {
                if (Lc.SelectedItem.ToString() == "Vibukij")
                {
                    pricebox.Text = 85.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Siam inter Comice")
                {
                    pricebox.Text = 75.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Zenshu")
                {
                    pricebox.Text = 90.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Luckpim")
                {
                    pricebox.Text = 85.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Dex")
                {
                    pricebox.Text = 120.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Phoenix")
                {
                    pricebox.Text = 129.ToString();
                }

                bool numCheck;
                num1 = Convert.ToDouble(pricebox.Text);
                numCheck = double.TryParse(totalBox.Text, out num3);

                if (!numCheck)
                {
                    num2 += num1;
                    totalBox.Text = num2.ToString();
                }
                else if (numCheck)
                {
                    num2 = num1 + num3;
                    totalBox.Text = num2.ToString();
                }

            }
            if (TypeBox.SelectedItem.ToString() == "Novel")
            {
                if (Lc.SelectedItem.ToString() == "Vibukij")
                {
                    pricebox.Text = 215.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Siam inter Comice")
                {
                    pricebox.Text = 240.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Zenshu")
                {
                    pricebox.Text = 290.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Luckpim")
                {
                    pricebox.Text = 349.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Dex")
                {
                    pricebox.Text = 279.ToString();
                }
                if (Lc.SelectedItem.ToString() == "Phoenix")
                {
                    pricebox.Text = 255.ToString();
                }
                bool numCheck;
                num1 = Convert.ToDouble(pricebox.Text);
                numCheck = double.TryParse(totalBox.Text, out num3);

                if (!numCheck)
                {
                    num2 += num1;
                    totalBox.Text = num2.ToString();
                }
                else if (numCheck)
                {
                    num2 = num1 + num3;
                    totalBox.Text = num2.ToString();
                }

            }
            dataGridView1.Rows.Add(name.Text, TypeBox.Text, Lc.Text, pricebox.Text);
        }

        private void Payfrom_Click(object sender, EventArgs e)
        {
            Pay p = new Pay();
            p.ShowDialog();
        }
    }
}