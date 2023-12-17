namespace Application;

public partial class Form3 : System.Windows.Forms.Form
{
	public Form3()
	{
		InitializeComponent();
	}

	private int Number { get; set; }

	private System.Threading.Thread? MainThread { get; set; }

	private void StartButton_Click
		(object sender, System.EventArgs e)
	{
		startButton.Enabled = false;

		var threadStart =
			new System.Threading.ThreadStart(DoSomething);

		MainThread =
			new System.Threading.Thread(start: threadStart);

		MainThread.Start();
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
