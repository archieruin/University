using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab_6_1
{
    public partial class MainForm : Form
    {
        private readonly NewsCollection _newsCollection = new NewsCollection();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime yesterday = DateTime.Now.Subtract(TimeSpan.FromDays(1));
            DateTime dayBeforeYesterday = yesterday.Subtract(TimeSpan.FromDays(1));
            _newsCollection.AddItem(new News("TestTitle1", "test text for example"));
            _newsCollection.AddItem(new News("TestTitle2", "test text for example"));
            _newsCollection.AddItem(new News("TestTitle3", "test text for example", yesterday));
            _newsCollection.AddItem(new News("TestTitle4", "test text for example", yesterday));
            _newsCollection.AddItem(new News("TestTitle5", "test text for example", dayBeforeYesterday));
            UpdateResult();
        }

        public List<News> getLatestNews(DateTime publishDate)
        {
            List<News> result = new List<News>();
            
            foreach (News news in _newsCollection)
            {
                if (news.PublishDate == publishDate)
                    result.Add(news);
                else if (news.PublishDate.Date == publishDate.Date)
                    result.Add(news);
            }
            
            return result;
        }

        private void UpdateResult()
        {
            List<News> latestNews = getLatestNews(dateTimePicker1.Value);
            richTextBox1.Text = "";
            if (latestNews.Count <= 0)
                richTextBox1.Text = "Нет новостей. Выберите другую дату.";
            foreach (News news in latestNews)
            {
                richTextBox1.Text += $"{news.Title}\n{news.Text}\n{news.PublishDate}\n\n";
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            UpdateResult();
        }
    }
}
