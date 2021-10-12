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

namespace SingleResponsibility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            /*
             * Bir sınıfta değişiklik yapmak için birden fazla sebebiniz varsa SRP'yi ihlal ediyorsunuz demektir.
             */
            string name = textBoxProductName.Text;
            double price = Convert.ToDouble(textBoxPrice.Text);
            string message = addProductAndgetResult(name, price);
            MessageBox.Show(message);

        }

        private static string addProductAndgetResult(string name, double price)
        {
            var service = new ProductService();
            var affectedRow = service.AddProduct(name, price);
            var message = affectedRow > 0 ? "Başarılı" : "Başarısız";
            return message;
        }

    }
}
