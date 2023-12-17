namespace Application;

public partial class Form5 : System.Windows.Forms.Form
{
	delegate void SimpleCallback();
	delegate void SimpleIntCallback(int number);

	public Form5()
	{
		InitializeComponent();
	}

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
		for (var Number = 1; Number <= 50; Number++)
		{
			//DisplayNumber(number: Number);

			//Infrastructure.Utility.SetControlPropertyThreadSafe
			//	(control: numberLabel, propertyName: "Text", propertyValue: Number.ToString());

			Infrastructure.Utility
				.SetControlProperty(control: numberLabel,
				propertyName: nameof(numberLabel.Text), propertyValue: Number.ToString());

			System.Threading.Thread
				.Sleep(millisecondsTimeout: 100);
		}

		//EnableStartButton();

		//Infrastructure.Utility.SetControlPropertyThreadSafe
		//	(control: startButton, propertyName: "Enabled", propertyValue: true);

		Infrastructure.Utility
			.SetControlProperty(control: startButton,
			propertyName: nameof(startButton.Enabled), propertyValue: true);
	}

	private void DisplayNumber(int number)
	{
		if (numberLabel.InvokeRequired)
		{
			var callback =
				new SimpleIntCallback(DisplayNumber);

			try
			{
				Invoke(method: callback, number);
			}
			catch
			{
			}
		}
		else
		{
			numberLabel.Text =
				number.ToString(format: "#,##0");
		}
	}

	private void EnableStartButton()
	{
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
