namespace zjxtworktool;

public partial class JiaShuiFenLiPage : ContentPage
{
  public JiaShuiFenLiPage()
  {
    InitializeComponent();

    shuilv.ItemsSource = new object[] {
      "1%", "3%",  "6%", "9%","13%"
    };
    shuilv.SelectedIndex = 0;
  }

  public void updateBuHanShui()
  {
    decimal.TryParse(hanshuijia.Text, out decimal totalPriceNum);
    decimal.TryParse(shuilv.SelectedItem?.ToString().TrimEnd('%'), out decimal taxRateNum);
    taxRateNum /= 100;

    var noTaxTotalPrice = totalPriceNum / (taxRateNum + 1);
    var taxAmount = totalPriceNum - noTaxTotalPrice;

    buhanshuijia.Text = decimal.Round(noTaxTotalPrice, 2).ToString();
    shuie.Text = decimal.Round(taxAmount, 2).ToString();
  }


  private void hanshuijia_TextChanged(object sender, TextChangedEventArgs e)
  {
    updateBuHanShui();
  }

  private void shuilv_SelectedIndexChanged(object sender, EventArgs e)
  {
    updateBuHanShui();
  }
}