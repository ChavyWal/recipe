using RecipeSystem;

namespace RecipeMAUI;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
        CancelBtn.Clicked += CancelBtn_Clicked;
        LoginBtn.Clicked += LoginBtn_Clicked;
	}

    private async void LoginBtn_Clicked(object? sender, EventArgs e)
    {
        try
        {
        dbManager.SetConnectionString(App.connstringSetting, true, UserNameTxt.Text, PasswordTxt.Text);
            App.loggedin = true;
            await Navigation.PopModalAsync();
        }
        catch (Exception ex)
        {
            MessageLbl.Text = ex.Message;
        }
    }

    private void CancelBtn_Clicked(object? sender, EventArgs e)
    {
        Application.Current.Quit();
    }
}