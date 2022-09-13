namespace App.Controls;

public partial class TeknoButton : Grid
{
	public TeknoButton()
	{
		InitializeComponent();
	}

	#region | Text |
	public static readonly BindableProperty TextProperty = BindableProperty.Create(
	   nameof(Text),
	   typeof(string),
	   typeof(TeknoButton),
	   default,
	   BindingMode.TwoWay,
	   propertyChanged: (bindable, value, newValue) => (bindable as TeknoButton)?.UpdateText(newValue as string));

	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}

	void UpdateText(string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			ButtonText.Text = value;
		}
	}
	#endregion

	#region | BackColor |
	public static readonly BindableProperty BackColorProperty = BindableProperty.Create(
	   nameof(BackColor),
	   typeof(string),
	   typeof(TeknoButton),
	   default,
	   BindingMode.TwoWay,
	   propertyChanged: (bindable, value, newValue) => (bindable as TeknoButton)?.UpdateBackColor(newValue as string));

	public string BackColor
	{
		get => (string)GetValue(BackColorProperty);
		set => SetValue(BackColorProperty, value);
	}

	void UpdateBackColor(string value)
	{
		if (!string.IsNullOrEmpty(value))
		{
			xStateButton.BackgroundColor = Color.FromHex(value);
		}
	}
	#endregion
}