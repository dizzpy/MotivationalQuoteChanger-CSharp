using System;
using System.Timers;
using System.Windows.Forms;
using MotivationalQuoteChanger.classes;

namespace MotivationalQuoteChanger
{
    public partial class Form1 : Form
    {
        private Quotes quotesObject;
        private Authors authorsObject;
        private System.Timers.Timer timer;
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();

            quotesObject = new Quotes();
            authorsObject = new Authors();

            UpdateLabels();
        }

        private void InitializeTimer()
        {
            timer = new System.Timers.Timer();
            TimerManager.InitializeTimer(timer, 2000, Timer_Elapsed);
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            currentIndex = (currentIndex + 1) % quotesObject.GetAllQuotes().Count;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            if (quoteLabel.InvokeRequired)
            {
                quoteLabel.Invoke(new MethodInvoker(delegate {
                    quoteLabel.Text = quotesObject.GetAllQuotes()[currentIndex];
                }));
            }
            else
            {
                quoteLabel.Text = quotesObject.GetAllQuotes()[currentIndex];
            }

            if (authorLabel.InvokeRequired)
            {
                authorLabel.Invoke(new MethodInvoker(delegate {
                    authorLabel.Text = authorsObject.GetAllAuthors()[currentIndex];
                }));
            }
            else
            {
                authorLabel.Text = authorsObject.GetAllAuthors()[currentIndex];
            }
        }
    }
}