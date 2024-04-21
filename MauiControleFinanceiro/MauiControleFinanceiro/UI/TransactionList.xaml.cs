namespace MauiControleFinanceiro.UI;

public partial class TransactionList : ContentPage
{
	public TransactionList()
	{
		InitializeComponent();
	}

	private void OnButtonClicked_To_TransactionApp(object sender, EventArgs args)
	{
        App.Current.MainPage = new TransactionAdd();
	}
}