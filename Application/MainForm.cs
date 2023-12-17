namespace Application;

public partial class MainForm : System.Windows.Forms.Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void Button1_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form1();
		myForm.Show();
	}

	private void Button2_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form2();
		myForm.Show();
	}

	private void Button3_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form3();
		myForm.Show();
	}

	private void Button4_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form4();
		myForm.Show();
	}

	private void Button5_Click
		(object sender, System.EventArgs e)
	{
		var myForm = new Form5();
		myForm.Show();
	}
}
