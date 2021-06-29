
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace AsyncAwait
{
    public partial class CountFileCharacters : Form
    {
        public CountFileCharacters()
        {
            InitializeComponent();
        }

        private async Task<int> CountCharacters()
        {
            int count = 0;
            using (StreamReader streamReader = new StreamReader(@"D:\Persnal\C#\C-Sharp-Practice\data.txt"))
            {
              
                string content = await streamReader.ReadToEndAsync();
                count = content.Length;
                await Task.Delay(5000);
            }
            return count;
        }
        private async void ProcessFile_Click(object sender, EventArgs e)
        {
            
            lblCount.Text = "Processing the file, please wait .................................";
            var count = await CountCharacters();
            lblCount.Text = "Number of characters in the file : " + count ;
        }

        private void CountFileCharacters_Load(object sender, EventArgs e)
        {

        }


    }
}