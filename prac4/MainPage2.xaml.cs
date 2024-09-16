namespace prac4;

public partial class MainPage2 : ContentPage
{
	public MainPage2()
	{
		InitializeComponent();
	}
    private void OnCalculateClicked(object sender, EventArgs e)
    {
        string output = string.Empty;

        if (Peugeot.IsChecked) output = "Вы выбрали Пежо, производитель: Франция";
        else if (Lada.IsChecked) output = "Вы выбрали Ладу, производитель: Россия";
        else if (Renault.IsChecked) output = "Вы выбрали Рено, производитель: Франция";
        else if (Niva.IsChecked) output = "Вы выбрали Ниву, производитель: Россия";
        else if (Ford.IsChecked) output = "Вы выбрали Форд, производитель: США";
        else if (Volvo.IsChecked) output = "Вы выбрали Вольво, производитель: Швеция";
        else if (BMW.IsChecked) output = "Вы выбрали БМВ, производитель: Германия";
        else if (Mercedes.IsChecked) output = "Вы выбрали Мерседес, производитель: Германия";

        OutputEntry.Text = output;
    }

    private void OnCarBrandCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        OutputEntry.Text = string.Empty; // Очищаем поле вывода при изменении выбора
    }
}