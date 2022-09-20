namespace App.Controls;

public partial class TeknoCircleButton : StateButton.StateButton
{
	public TeknoCircleButton()
	{
		InitializeComponent();
	}

	#region | CircleWidthRequest |
	public static readonly BindableProperty CircleWidthRequestProperty =
		BindableProperty.Create(nameof(CircleWidthRequestProperty),
		typeof(double),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			if (page != null)
			{
				page.xStateButton.WidthRequest = Convert.ToDouble(newVal);
				page.xRoundRectangle.CornerRadius = new CornerRadius(Convert.ToDouble(newVal) / 2);
			}
		});

	public double CircleWidthRequest
	{
		get => (double)GetValue(CircleWidthRequestProperty);
		set => SetValue(CircleWidthRequestProperty, value);
	}
	#endregion

	#region | CircleHeightRequest |
	public static readonly BindableProperty CircleHeightRequestProperty =
		BindableProperty.Create(nameof(CircleHeightRequestProperty),
		typeof(double),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			if (page != null)
			{
				page.xStateButton.HeightRequest = Convert.ToDouble(newVal);
				page.xRoundRectangle.CornerRadius = new CornerRadius(Convert.ToDouble(newVal) / 2);
			}
		});

	public double CircleHeightRequest
	{
		get => (double)GetValue(CircleHeightRequestProperty);
		set => SetValue(CircleHeightRequestProperty, value);
	}
	#endregion

	#region | Text |
	public static readonly BindableProperty TextProperty =
		BindableProperty.Create(nameof(TextProperty),
		typeof(string),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			if (!string.IsNullOrEmpty(newVal.ToString()))
			{
				page.xLabel.Text = newVal.ToString();
			}
		});

	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}
	#endregion

	#region | TextColor |

	public static readonly BindableProperty TextColorProperty =
		BindableProperty.Create(nameof(TextColorProperty),
		typeof(Color),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			page.xLabel.TextColor = (Color)newVal;
		});

	public Color TextColor
	{
		get => (Color)GetValue(TextColorProperty);
		set => SetValue(TextColorProperty, value);
	}
	#endregion

	#region | FontSize |
	public static readonly BindableProperty FontSizeProperty =
		BindableProperty.Create(nameof(FontSizeProperty),
		typeof(double),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			page.xLabel.FontSize = (double)newVal;
		});

	public double FontSize
	{
		get => (double)GetValue(FontSizeProperty);
		set => SetValue(FontSizeProperty, value);
	}
	#endregion

	#region | FontFamily |

	public static readonly BindableProperty FontFamilyProperty =
		BindableProperty.Create(nameof(FontFamilyProperty),
		typeof(string),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			page.xLabel.FontFamily = (string)newVal;
		});

	public string FontFamily
	{
		get => (string)GetValue(FontFamilyProperty);
		set => SetValue(FontFamilyProperty, value);
	}
	#endregion

	#region | BackColor |

	public static readonly BindableProperty BackColorProperty =
		BindableProperty.Create(nameof(BackColorProperty),
		typeof(Color),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			page.xStateButton.BackgroundColor = (Color)newVal;
		});

	public Color BackColor
	{
		get => (Color)GetValue(BackColorProperty);
		set => SetValue(BackColorProperty, value);
	}
	#endregion

	#region | ClickBackgroundColor |

	public static readonly BindableProperty ClickBackgroundColorProperty =
		BindableProperty.Create(nameof(ClickBackgroundColorProperty),
		typeof(Color),
		typeof(TeknoCircleButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCircleButton page = (TeknoCircleButton)bindable;
			page.ClickedBackgroundColor.Value = (Color)newVal;
		});

	public Color ClickBackgroundColor
	{
		get => (Color)GetValue(ClickBackgroundColorProperty);
		set => SetValue(ClickBackgroundColorProperty, value);
	}
	#endregion
}