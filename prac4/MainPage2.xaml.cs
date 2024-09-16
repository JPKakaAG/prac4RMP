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

        if (Peugeot.IsChecked) output = "�� ������� ����, �������������: �������";
        else if (Lada.IsChecked) output = "�� ������� ����, �������������: ������";
        else if (Renault.IsChecked) output = "�� ������� ����, �������������: �������";
        else if (Niva.IsChecked) output = "�� ������� ����, �������������: ������";
        else if (Ford.IsChecked) output = "�� ������� ����, �������������: ���";
        else if (Volvo.IsChecked) output = "�� ������� ������, �������������: ������";
        else if (BMW.IsChecked) output = "�� ������� ���, �������������: ��������";
        else if (Mercedes.IsChecked) output = "�� ������� ��������, �������������: ��������";

        OutputEntry.Text = output;
    }

    private void OnCarBrandCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        OutputEntry.Text = string.Empty; // ������� ���� ������ ��� ��������� ������
    }
}