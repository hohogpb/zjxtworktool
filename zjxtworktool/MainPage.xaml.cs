namespace zjxtworktool
{
  public partial class MainPage : ContentPage
  {
    int count = 0;

    public MainPage()
    {
      InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
      count++;

#if false
      if (count == 1)
        CounterBtn.Text = $"Clicked {count} time";
      else
        CounterBtn.Text = $"Clicked {count} times";

      SemanticScreenReader.Announce(CounterBtn.Text);
#endif
    }

    private async void navigateJinEZhuanHuan(object sender, EventArgs e)
    {
      //await Shell.Current.GoToAsync("//JinEZhuanHuanPage", false);
      await Navigation.PushAsync(new JinEZhuanHuanPage());
    }

    private async void navigateJiaShuiFenLi(object sender, EventArgs e)
    {
      // Navigation.PushAsync("//JiaShuiFenLiPage");
      await Navigation.PushAsync(new JiaShuiFenLiPage());
    }
  }

}
