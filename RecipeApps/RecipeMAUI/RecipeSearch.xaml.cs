using RecipeSystem;
using System.Data;

namespace RecipeMAUI;

public partial class RecipeSearch : ContentPage
{
	public RecipeSearch()
	{
		InitializeComponent();
        SearchBtn.Clicked += SearchBtn_Clicked;
	}

    private void SearchBtn_Clicked(object? sender, EventArgs e)
    {
      SearchRecipe();
    }

    private void SearchRecipe()
    {
        DataTable dt = Recipe.SearchRecipe();
        Recipelst.ItemsSource = dt.Rows;
    }
}