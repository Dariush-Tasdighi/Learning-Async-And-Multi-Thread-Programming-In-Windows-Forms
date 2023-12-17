namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	[System.STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();

		System.Windows.Forms.Application.Run(new MainForm());
	}
}