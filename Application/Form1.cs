namespace Application;

public partial class Form1 : System.Windows.Forms.Form
{
	public Form1()
	{
		InitializeComponent();
	}

	private int Number { get; set; }

	private void StartButton_Click
		(object sender, System.EventArgs e)
	{
		startButton.Enabled = false;

		DoSomething();
	}

	private void DoSomething()
	{
		for (Number = 1; Number <= 50; Number++)
		{
			numberLabel.Text =
				Number.ToString(format: "#,##0");

			System.Threading.Thread
				.Sleep(millisecondsTimeout: 100);
		}

		startButton.Enabled = true;
	}
}
