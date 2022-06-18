using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace Currency_Converter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] currencies;
        string[] county;
        public MainWindow()
        {
            InitializeComponent();
            Money();
            Countries();
            cbFirstCurrency.ItemsSource = county;
            cbSecondCurrency.ItemsSource = county;
        }

        public void Money()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            String Response = client.DownloadString("https://www.banki.ru/products/currency/cb/");
            Regex regex = new Regex(@"<td>([0-9]+\.[0-9]+)</td>");
            MatchCollection matches = regex.Matches(Response);
            currencies = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                currencies[i] = matches[i].Value;
                String Rate = System.Text.RegularExpressions.Regex.Match(currencies[i], @"<td>([0-9]+\.[0-9]+)</td>").Groups[1].Value;
                currencies[i] = Rate;
            }
        }

        public void Countries()
        {
            System.Net.WebClient client = new System.Net.WebClient();
            String Response = client.DownloadString("https://www.banki.ru/products/currency/cb/");
            Regex regex = new Regex(@"data-currency-code=""\w{3}""");
            MatchCollection matches = regex.Matches(Response);
            county = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
            {
                county[i] = matches[i].Value;
                String Rate = System.Text.RegularExpressions.Regex.Match(county[i], @"data-currency-code=""(\w{3})""").Groups[1].Value;
                county[i] = Rate;
            }
        }

        private void currencyMoney(object sender, KeyEventArgs e)
        {
            converMoney();
        }
        public void converMoney()
        {
            if (cbFirstCurrency.SelectedIndex != -1 && cbSecondCurrency.SelectedIndex != -1)
            {
                int firsindex = cbFirstCurrency.SelectedIndex;
                int secontindex = cbSecondCurrency.SelectedIndex;
                double firsNumber = Convert.ToDouble(currencies[firsindex].Replace('.', ','));
                double secondNumber = Convert.ToDouble(currencies[secontindex].Replace('.', ','));
                double difference;
                try
                {

                    switch (firsNumber > secondNumber)
                    {
                        case true:
                            difference = firsNumber / secondNumber;
                            conclusion.Text = (Convert.ToDouble(inputCurrency.Text) * difference).ToString();
                            break;

                        case false:
                            difference = secondNumber / firsNumber;
                            conclusion.Text = (Convert.ToDouble(inputCurrency.Text) / difference).ToString();
                            break;
                        default:
                            conclusion.Text = inputCurrency.Text;
                            break;
                    }
                }
                catch (System.FormatException)
                {

                }
            }
        }

        private void select(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            converMoney();
        }

        private void switchMoney(object sender, RoutedEventArgs e)
        {
            int index = cbSecondCurrency.SelectedIndex;
            cbSecondCurrency.SelectedIndex = cbFirstCurrency.SelectedIndex;
            cbFirstCurrency.SelectedIndex= index;
            converMoney();
        }

        

        private void PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !IsTextAllowed(e.Text);
        }
        private static readonly Regex _regex = new Regex("[^0-9]+"); //regex that matches disallowed text
        private static bool IsTextAllowed(string text)
        {
            return !_regex.IsMatch(text);
        }
    }
}
