namespace Application;

public partial class Form4 : System.Windows.Forms.Form
{
	delegate void SimpleCallback();

	public Form4()
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
			DisplayNumber();

			System.Threading.Thread
				.Sleep(millisecondsTimeout: 100);
		}

		EnableStartButton();
	}

	private void DisplayNumber()
	{
		// Not Thread Safe -> Error!
		//numberLabel.Text =
		//	Number.ToString(format: "#,##0");

		// Thread Safe
		if (numberLabel.InvokeRequired)
		{
			var callback =
				new SimpleCallback(DisplayNumber);

			try
			{
				Invoke(method: callback);
			}
			catch
			{
			}
		}
		else
		{
			numberLabel.Text =
				Number.ToString(format: "#,##0");
		}
	}

	private void EnableStartButton()
	{
		// Not Thread Safe -> Error!
		//startButton.Enabled = true;

		// Thread Safe
		if (startButton.InvokeRequired)
		{
			var callback =
				new SimpleCallback(EnableStartButton);

			try
			{
				Invoke(method: callback);
			}
			catch
			{
			}
		}
		else
		{
			startButton.Enabled = true;
		}
	}
}
