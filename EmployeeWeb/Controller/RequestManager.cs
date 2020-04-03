using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using DNPExamPt2.Data;
using Newtonsoft.Json;

namespace EmployeeWeb.Controller
{
    public class RequestManager
    {
        
        public async Task<List<Employee>> Get(string link)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(link);
            var json = await response.Content.ReadAsStringAsync();
            var employee = JsonConvert.DeserializeObject<List<Employee>>(json);
            Console.WriteLine(response.StatusCode);

            return employee;
        }
        
        public async Task<double> GetTotal(string link)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(link);
            var json = await response.Content.ReadAsStringAsync();
            var total = JsonConvert.DeserializeObject<double>(json);
            Console.WriteLine(response.StatusCode);

            return total;
        }
        
        public async void Post(string link,Employee employee)
        {
            HttpClient client = new HttpClient();
            string jsonParty = Newtonsoft.Json.JsonConvert.SerializeObject(employee);
            var content = new StringContent(jsonParty, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(link,content);
            var json = await response.Content.ReadAsStringAsync();
        }


    }
}