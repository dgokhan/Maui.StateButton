using Microsoft.Maui.Graphics;

namespace App.Controls;

public partial class TeknoCategoryButton : StateButton.StateButton
{
	public TeknoCategoryButton()
	{
		InitializeComponent();
	}

	#region | Text |
	public static readonly BindableProperty TextProperty =
		BindableProperty.Create(nameof(TextProperty),
		typeof(string),
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.xLabel.Text = (string)newVal;
		});

	public string Text
	{
		get => (string)GetValue(TextProperty);
		set => SetValue(TextProperty, value);
	}
	#endregion
	
	#region | FontSize |
	public static readonly BindableProperty FontSizeProperty =
		BindableProperty.Create(nameof(FontSizeProperty),
		typeof(double),
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.xLabel.FontSize = (double)newVal;
		});

	public double FontSize
	{
		get => (double)GetValue(FontSizeProperty);
		set => SetValue(FontSizeProperty, value);
	}
	#endregion

	#region | TextColor |

	public static readonly BindableProperty TextColorProperty =
		BindableProperty.Create(nameof(TextColorProperty),
		typeof(Color),
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.xLabel.TextColor = (Color)newVal;
		});

	public Color TextColor
	{
		get => (Color)GetValue(TextColorProperty);
		set => SetValue(TextColorProperty, value);
	}
	#endregion

	#region | FontFamily |

	public static readonly BindableProperty FontFamilyProperty =
		BindableProperty.Create(nameof(FontFamilyProperty),
		typeof(string),
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
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
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.xTeknoCategoryButton.BackgroundColor = (Color)newVal;
		});

	public Color BackColor
	{
		get => (Color)GetValue(BackColorProperty);
		set => SetValue(BackColorProperty, value);
	}
	#endregion

	#region | BarColor |

	public static readonly BindableProperty BarColorProperty =
		BindableProperty.Create(nameof(BarColorProperty),
		typeof(Color),
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.xBar.Color = (Color)newVal;
		});

	public Color BarColor
	{
		get => (Color)GetValue(BarColorProperty);
		set => SetValue(BarColorProperty, value);
	}
	#endregion

	#region | CircleColor |

	public static readonly BindableProperty CircleColorProperty =
		BindableProperty.Create(nameof(CircleColorProperty),
		typeof(Color),
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.xBorder.BackgroundColor = (Color)newVal;
		});

	public Color CircleColor
	{
		get => (Color)GetValue(CircleColorProperty);
		set => SetValue(CircleColorProperty, value);
	}
	#endregion

	#region | ClickBackgroundColor |

	public static readonly BindableProperty ClickBackgroundColorProperty =
		BindableProperty.Create(nameof(ClickBackgroundColorProperty),
		typeof(Color),
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
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
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.xImage.Source = (ImageSource)newVal;
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
		typeof(TeknoCategoryButton),
		defaultBindingMode: BindingMode.TwoWay,

		propertyChanged: (bindable, oldVal, newVal) =>
		{
			TeknoCategoryButton page = (TeknoCategoryButton)bindable;
			page.RoundRectangle.CornerRadius = (CornerRadius)newVal;
		});

	public CornerRadius CornerRadius
	{
		get => (CornerRadius)GetValue(TextProperty);
		set => SetValue(TextProperty, CornerRadius);
	}
	#endregion
}