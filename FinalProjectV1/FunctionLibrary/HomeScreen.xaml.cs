namespace FinalProjectV1.FunctionLibrary;

public partial class HomeScreen : ContentPage
{
	public HomeScreen()
	{
        InitializeComponent();

	}

    private void Enter_Clicked(object sender, EventArgs e)
    {

        Button button = sender as Button;
        string nameOfButton = button.Text;
        if(nameOfButton == "Search")
        {
            Navigation.PushAsync(new SearchBooks());
        }else if (nameOfButton == "Add")
        {
            Navigation.PushAsync(new AddBooks());

        }
        else if (nameOfButton == "Update")
        {
            Navigation.PushAsync(new UpdateBooks());

        }
        else if (nameOfButton == "Delete")
        {
            Navigation.PushAsync(new DeleteBooks());

        }
        else
        {
            return;
        } 

    }
}