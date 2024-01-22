using zjxtworktool.libs;

namespace zjxtworktool;

public partial class JinEZhuanHuanPage : ContentPage
{
	public JinEZhuanHuanPage()
	{
		InitializeComponent();
	}

  private void Entry_TextChanged(object sender, TextChangedEventArgs e)
  {
    decimal.TryParse(xiaoxie.Text, out decimal value);
    daxie.Text = RMB.toDaXie(value);
  }
}