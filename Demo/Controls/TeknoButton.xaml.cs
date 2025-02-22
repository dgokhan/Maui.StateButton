using Microsoft.Maui.Graphics;

namespace App.Controls;

public partial class TeknoButton : StateButton.StateButton
{
	public TeknoButton()
	{
		InitializeComponent();
	}

	#region | Text |
	public static readonly BindableProperty TextProperty =
		BindableProperty.Create(nameof(TextProperty),
		typeof(string),
		typeof(TeknoButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoButton page = (TeknoButton)bindable;
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
		typeof(TeknoButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoButton page = (TeknoButton)bindable;
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
		typeof(TeknoButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoButton page = (TeknoButton)bindable;
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
		typeof(TeknoButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoButton page = (TeknoButton)bindable;
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
		typeof(TeknoButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoButton page = (TeknoButton)bindable;
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
		typeof(TeknoButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoButton page = (TeknoButton)bindable;
			page.ClickedBackgroundColor.Value = (Color)newVal;
		});

	public Color ClickBackgroundColor
	{
		get => (Color)GetValue(ClickBackgroundColorProperty);
		set => SetValue(ClickBackgroundColorProperty, value);
	}
	#endregion

	#region | ImageSource |

	public static readonly BindableProperty ImageSourceProperty =
	    BindableProperty.Create(nameof(ImageSourceProperty),
	    typeof(ImageSource),
	    typeof(TeknoButton),
	    defaultBindingMode: BindingMode.TwoWay,

	    propertyChanged: (bindable, oldVal, newVal) =>
	    {
			TeknoButton page = (TeknoButton)bindable;
	        page.Image.Source = (ImageSource)newVal;
	    });

	public ImageSource ImageSource
	{
	    get => (ImageSource)GetValue(ImageSourceProperty);
	    set => SetValue(ImageSourceProperty, value);
	}
	#endregion

	#region | CornerRadius |
	public static readonly BindableProperty CornerRadiusProperty =
		BindableProperty.Create(nameof(CornerRadiusProperty),
		typeof(CornerRadius),
		typeof(TeknoButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoButton page = (TeknoButton)bindable;
			page.RoundRectangle.CornerRadius = (CornerRadius)newVal;
		});

	public CornerRadius CornerRadius
	{
		get => (CornerRadius)GetValue(TextProperty);
		set => SetValue(TextProperty, CornerRadius);
	}
	#endregion
}