using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class ProductService
    {
        public int AddProduct(string name, double price)
        {
            string connectionString = "Data Source=(localdb)\\MssqlLocaldb;Initial Catalog=VakifDb1;Integrated Security=True";

            string commandText = "INSERT into Products (Name, Price) values (@name,@price)";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@name", name);
            parameters.Add("@price", price);

            var helper = new SqlDbHelper(connectionString);
            var affectedRow = helper.ExecuteCommand(commandText, parameters);
            return affectedRow;
             
        }
    }
}
