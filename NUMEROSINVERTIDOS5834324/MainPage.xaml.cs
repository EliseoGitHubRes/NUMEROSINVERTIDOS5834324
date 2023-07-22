namespace NUMEROSINVERTIDOS5834324;

public partial class MainPage : ContentPage
{

    /// <summary>
    ///<CreatedData>22/07/2023</CreatedData>
    ///<conpany>INDEL</conpany>
    ///<lastmodificationdate>22/07/2023</lastmodificationdate>
    ///<lastmodificationdescription>
    ///PROPIEDADES DEL BUTTON Y ENTRY
    ///</lastmodificationdescription>
    ///<lastmodifierautor>ELISEO</lastmodifierautor>
    /// </summary>
    public MainPage()
	{
		InitializeComponent();
	}

    /// <summary>
    /// EVENTO QUE SE EJECUTA AL PRESIONAR EL BOTON
    /// </summary>
    private void Button_Clicked(object sender, EventArgs e)
    {
        int num1 = Convert.ToInt32(n1.Text);
        int num2 = Convert.ToInt32(n2.Text);
        int num3 = Convert.ToInt32(n3.Text);
        int num4 = Convert.ToInt32(n4.Text);

        n1.Text = Convert.ToString(num4);
        n2.Text = Convert.ToString(num3);
        n3.Text = Convert.ToString(num2);
        n4.Text = Convert.ToString(num1);

    }
}

