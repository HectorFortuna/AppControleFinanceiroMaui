using MauiControleFinanceiro.UI;
namespace MauiControleFinanceiro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new TransactionList();
        }
    }
}
