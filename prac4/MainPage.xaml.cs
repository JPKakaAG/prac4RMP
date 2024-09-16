namespace prac4
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRadioButtonCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                string result = string.Empty;

                RadioButton radioButton = sender as RadioButton;
                switch (radioButton.Content.ToString())
                {
                    case "1. Пежо":
                        result = "Пежо - Франция";
                        break;
                    case "2. Лада":
                        result = "Лада - Россия";
                        break;
                    case "3. Рено":
                        result = "Рено - Франция";
                        break;
                    case "4. Нива":
                        result = "Нива - Россия";
                        break;
                    case "5. Форд":
                        result = "Форд - США";
                        break;
                    case "6. Вольво":
                        result = "Вольво - Швеция";
                        break;
                    case "7. БМВ":
                        result = "БМВ - Германия";
                        break;
                    case "8. Мерседес":
                        result = "Мерседес - Германия";
                        break;
                }
                OutputField.Text = result;
            }
        }
    }
}
