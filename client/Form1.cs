using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;   
using RestSharp.Deserializers;
namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAPIKey_Click(object sender, EventArgs e)
        {
            
            var client = new RestClient("http://localhost/server/index.php");
            var request = new RestRequest();

            string MyUserName = textBoxUsername.Text;
            String Service = "Request_Key";
            request.AddParameter("userName", MyUserName);
            request.AddParameter("Service", Service);
            request.AddParameter("format", "json");

            var response = client.Execute(request);

            char[] charsToTrim = { '"' };   //this trims off the "" quotes at the beginning and end of the api
            string api_key = textBoxAPIKey.Text.Trim(charsToTrim);



            textBoxAPIKey.Text = response.Content;  //this apiKey is surrounded with "" quotes ut we will get rid of them in the next section

        }

        private void buttonPopulateCountries_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost/server/index.php");
            var request = new RestRequest();

            char[] charsToTrim = { '"' };   //this trims off the "" quotes at the beginning and end of the api
                                            // without it you cant use the API as a value for the next combobox
            string api_key = textBoxAPIKey.Text.Trim(charsToTrim);
            string Service = "getCountries";
            request.AddParameter("api_key", api_key);
            request.AddParameter("Service", Service);
            request.AddParameter("format", "json");

            var response = client.Execute(request);

            JsonDeserializer deserializer = new JsonDeserializer();
            var temp = new List<GetAllCountries>();
            temp = deserializer.Deserialize<List<GetAllCountries>>(response);
            var countriesReturned = temp;
            foreach (GetAllCountries a in countriesReturned)
            {
                comboBoxCountries.Items.Add(a.id + " " + a.country);  //display the country id and name , id will be used as the value for next combo box

            }
        }

        private void buttonPopulateCounties_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost/server/index.php");
            var request = new RestRequest();

            char[] charsToTrim = { '"' };   //this trims off the "" quotes at the beginning and end of the api
            string api_key = textBoxAPIKey.Text.Trim(charsToTrim);
            String Service = "getCounties";
            String country_name = comboBoxCountries.Text;

            var country_id = String.Join("", country_name.Where(char.IsDigit)); //this takes whatver the value of the country combobox was and trims anything that
                                                                                // is not numerical, this gives us the id to pass to the request from server.
            //MessageBox.Show(numbers);


            request.AddParameter("country_id", country_id);
            request.AddParameter("api_key", api_key);
            request.AddParameter("Service", Service);
            request.AddParameter("format", "json");

            var response = client.Execute(request);

            // MessageBox.Show(response.Content);

            JsonDeserializer deserializer = new JsonDeserializer();
            var temp = new List<GetAllCounties>();
            temp = deserializer.Deserialize<List<GetAllCounties>>(response);
            var countiesReturned = temp;
            foreach (GetAllCounties a in countiesReturned)
            {
                comboBoxCounties.Items.Add(a.id + " " + a.name);

            }
        }

        private void buttonPopulateTowns_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://localhost/server/index.php");
            var request = new RestRequest();

            char[] charsToTrim = { '"' };   //this trims off the "" quotes at the beginning and end of the api
            string api_key = textBoxAPIKey.Text.Trim(charsToTrim);
            String Service = "getTowns";
            String county_name = comboBoxCounties.Text;
            var county_id = String.Join("", county_name.Where(char.IsDigit)); // again trimming anything non numerical, giving us the value to send in teh request to the server
            //MessageBox.Show(numbers);


            request.AddParameter("county_id", county_id);
            request.AddParameter("api_key", api_key);
            request.AddParameter("Service", Service);
            request.AddParameter("format", "json");

            var response = client.Execute(request);

            // MessageBox.Show(response.Content);

            JsonDeserializer deserializer = new JsonDeserializer();
            var temp = new List<GetAllTowns>();
            temp = deserializer.Deserialize<List<GetAllTowns>>(response);
            var TownsReturned = temp;
            foreach (GetAllTowns a in TownsReturned)
            {
                comboBoxTowns.Items.Add(a.townName); // no need to add the id to the combo this time since we arent using it's value to seelct anythign else.

            }
        }






        public class GetAllCountries
        {
            public String country { get; set; }
            public String iso { get; set; }
            public int id { get; set; }

        }
        public class GetAllCounties
        {
            public int id { get; set; }
            public int country_id { get; set; }
            public String name { get; set; }
            
            

        }
        public class GetAllTowns
        {
            public int townID { get; set; }
            public int countyID { get; set; }
            public String townName { get; set; }
            

        }


    }
}
