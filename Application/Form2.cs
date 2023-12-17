using System.Net.Http;

namespace Application;

public partial class Form2 : System.Windows.Forms.Form
{
	public Form2()
	{
		InitializeComponent();
	}

	private int Number { get; set; }

	private async void StartButton_Click
		(object sender, System.EventArgs e)
	{
		startButton.Enabled = false;

		await DoSomethingAsync();
	}

	//private async System.Threading.Tasks.Task DoSomething()
	private async System.Threading.Tasks.Task DoSomethingAsync()
	{
		var client = new HttpClient();

		for (Number = 1; Number <= 50; Number++)
		{
			//var result =
			await client.GetStringAsync
				(requestUri: "https://the-internet.herokuapp.com/abtest");

			numberLabel.Text =
				Number.ToString(format: "#,##0");

			System.Threading.Thread
				.Sleep(millisecondsTimeout: 100);
		}

		startButton.Enabled = true;
	}
}
