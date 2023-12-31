﻿namespace Infrastructure;

public static class Utility : object
{
	static Utility()
	{
	}

	private delegate void SetControlPropertyDelegate
		(System.Windows.Forms.Control control, string propertyName, object propertyValue);

	/// <summary>
	/// This function is Thread 
	/// </summary>
	public static void SetControlProperty
		(System.Windows.Forms.Control control, string propertyName, object propertyValue)
	{
		if (control.InvokeRequired)
		{
			var callback =
				new SetControlPropertyDelegate(SetControlProperty);

			try
			{
				control.Invoke(method: callback,
					control, propertyName, propertyValue);
			}
			catch
			{
			}
		}
		else
		{
			var type =
				control.GetType();

			var invokeAttribute =
				System.Reflection.BindingFlags.SetProperty;

			type.InvokeMember
				(name: propertyName, invokeAttr: invokeAttribute,
				binder: null, target: control, args: new object[] { propertyValue });
		}
	}
}
