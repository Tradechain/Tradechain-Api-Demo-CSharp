using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Reflection;

namespace TradechainApiDemoCSharp
{
    public partial class Form1 : Form
    {
        const string software= "SmartInvoice";
        const string attachment= "demo.pdf";

        public Form1()
        {
            InitializeComponent();
        }

        #region Debug
        private delegate void InvokeMessageFunction(string Msg);
        public void ListMessage(string Msg)
        { 
            this.Invoke(new InvokeMessageFunction(this.MessageFunction), new object[] {Msg});        
        }

        private void MessageFunction(string Msg)
        {
            textBox_msg.AppendText(">> " + Msg + "\r\n");    
        }
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text ="version "+ FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion.ToString();
        }

        TAuth GetAuth(string apikey, string secretkey, string software)
        {
            TAuth auth= new TAuth();

            auth.apikey= apikey;
	        auth.software= software;
            auth.time= (long)Utility.ConvertToUnixTimestamp(DateTime.Now);
            string signhash;

            Utility.SignHashString(textBox_apikey.Text, textBox_secretkey.Text, auth.time, out signhash);
            auth.signhash= signhash;

            return auth;
        }

        private async void button_create_Click(object sender, EventArgs e)
        {
            //POST

            string url= textBox_host.Text + "/asset/create";

            TAssetCreate tc= new TAssetCreate();
            tc.auth= GetAuth(textBox_apikey.Text, textBox_secretkey.Text, software);
            if(tc.auth.signhash.Length==0) return;            

	        tc.type= textBox_type.Text;
	        tc.name= textBox_name.Text;
	        tc.name_short= textBox_shortname.Text;
	        tc.description= textBox_description.Text;
	        tc.icon_url= textBox_icon.Text;
	        tc.image_url= textBox_image.Text;
	        tc.cover_url= textBox_cover.Text;
	        tc.attachment_url= "http://res.web.co/attachment/"+ attachment;
            tc.hash_attachment= Utility.AttachmentHashString(attachment);
	        tc.valid_time= tc.auth.time;  //for example
	        tc.invalid_time= tc.auth.time + (60 * 60 * 24);  //for example
	        tc.tag= "";  //Base64 Encoding...

            string parameters = JsonConvert.SerializeObject(tc);
            ListMessage(parameters);

            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(parameters, Encoding.UTF8, "application/json"));
 
            response.EnsureSuccessStatusCode();
            string result= await response.Content.ReadAsStringAsync();
            ListMessage(result);      
      
            RAssetCreate obj = JsonConvert.DeserializeObject<RAssetCreate> (result);
            ListMessage(obj.asset_id);
        }        

        private async void button_issue_Click(object sender, EventArgs e)
        {
            //POST

            string url= textBox_host.Text + "/asset/issue";

            TAssetIssue ti= new TAssetIssue();
            ti.auth= GetAuth(textBox_apikey.Text, textBox_secretkey.Text, software);
            if(ti.auth.signhash.Length==0) return;            

            ti.asset_id= textBox_issue_asset_id.Text;
            ti.quantity= Convert.ToString(numericUpDown_issue_qty.Value);

            string parameters = JsonConvert.SerializeObject(ti);
            ListMessage(parameters);

            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(parameters, Encoding.UTF8, "application/json"));
 
            response.EnsureSuccessStatusCode();
            string result= await response.Content.ReadAsStringAsync();
            ListMessage(result);

            RAssetIssue obj = JsonConvert.DeserializeObject<RAssetIssue> (result);
            ListMessage(obj.txid);
        }

        private async void button_send_Click(object sender, EventArgs e)
        {
            //POST

            string url= textBox_host.Text + "/asset/send";

            TAssetSend ts= new TAssetSend();
            ts.auth= GetAuth(textBox_apikey.Text, textBox_secretkey.Text, software);
            if(ts.auth.signhash.Length==0) return;            

            ts.asset_id= textBox_send_asset_id.Text;
            ts.asset_addr_to= textBox_send_addrto.Text;
            ts.quantity= Convert.ToString(numericUpDown_send_qty.Value);

            string parameters = JsonConvert.SerializeObject(ts);
            ListMessage(parameters);

            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(parameters, Encoding.UTF8, "application/json"));
 
            response.EnsureSuccessStatusCode();
            string result= await response.Content.ReadAsStringAsync();
            ListMessage(result);

            RAssetSend obj = JsonConvert.DeserializeObject<RAssetSend> (result);
            ListMessage(obj.txid);
        }

        private async void button_infos_Click(object sender, EventArgs e)
        {
            //POST

            string url= textBox_host.Text + "/asset/infos";

            TAssetInfos tinf= new TAssetInfos();
            tinf.auth= GetAuth(textBox_apikey.Text, textBox_secretkey.Text, software);
            if(tinf.auth.signhash.Length==0) return;            

	        tinf.create_time= 0;

            string parameters = JsonConvert.SerializeObject(tinf);
            ListMessage(parameters);

            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(parameters, Encoding.UTF8, "application/json"));
 
            response.EnsureSuccessStatusCode();
            string result= await response.Content.ReadAsStringAsync();
            ListMessage(result);

            List<RAssetInfos> objs = JsonConvert.DeserializeObject<List<RAssetInfos>> (result);
            foreach(RAssetInfos ri in objs) ListMessage(ri.asset_id);
        }

        private async void button_txs_Click(object sender, EventArgs e)
        {
            //POST

            string url= textBox_host.Text + "/asset/txs";

            TAssetTransaction tt= new TAssetTransaction();
            tt.auth= GetAuth(textBox_apikey.Text, textBox_secretkey.Text, software);
            if(tt.auth.signhash.Length==0) return;            

	        tt.tx_time= 0;

            string parameters = JsonConvert.SerializeObject(tt);
            ListMessage(parameters);

            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(parameters, Encoding.UTF8, "application/json"));
 
            response.EnsureSuccessStatusCode();
            string result= await response.Content.ReadAsStringAsync();
            ListMessage(result); 

            List<RAssetTransaction> objs = JsonConvert.DeserializeObject<List<RAssetTransaction>> (result);
            foreach(RAssetTransaction rt in objs) ListMessage(String.Format("from:{0}, to:{1}, category={2}", rt.asset_addr_from, rt.asset_addr_to, rt.categotry));
        }

        private async void button_balance_Click(object sender, EventArgs e)
        {
            //POST

            string url= textBox_host.Text + "/asset/balance";

            TAssetBalance tb= new TAssetBalance();
            tb.auth= GetAuth(textBox_apikey.Text, textBox_secretkey.Text, software);
            if(tb.auth.signhash.Length==0) return;            

            string parameters = JsonConvert.SerializeObject(tb);
            ListMessage(parameters);

            var client = new HttpClient();
            var response = await client.PostAsync(url, new StringContent(parameters, Encoding.UTF8, "application/json"));
 
            response.EnsureSuccessStatusCode();
            string result= await response.Content.ReadAsStringAsync();
            ListMessage(result);

            List<RAssetBalance> objs = JsonConvert.DeserializeObject<List<RAssetBalance>> (result);
            foreach(RAssetBalance rb in objs) ListMessage(String.Format("{0}: name={1}, qty={2}", rb.asset_id, rb.name_short, rb.quantity));
        }

        private async void button_definition_Click(object sender, EventArgs e)
        {
            //GET

            string asset_id= "AaVrFb254FUa8GC11u9Cqa62YZ6Vy9NuGF";      
            string url= textBox_host.Text + "/asset/query/" + asset_id;

            var client = new HttpClient();

            var response = await client.GetAsync(url);

            response.EnsureSuccessStatusCode();
            string result= await response.Content.ReadAsStringAsync();
            ListMessage(result);

            AssetDefinition obj = JsonConvert.DeserializeObject<AssetDefinition> (result);
            ListMessage(String.Format("{0}: name={1}", obj.asset_id, obj.name_short));
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_msg.Text= "";
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
