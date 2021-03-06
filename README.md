# WPF & XAML Overview
C# WPF overview on xaml. Xaml stands for eXtensible Application Markup Language. Microsoft's version of XML for coding a graphical user inferace (GUI). It is an essential part of WPF. Each GUI element (a window or page), will consist of a XAML file and a CodeBehind (.cs) file. They both work together to create the window or page.

The XAML file characterizes the GUI with all its element while the CS file handles all the evenets and has access to shape and manipulate the GUI elements. Each line of XAML code can be written in the CS file.

**XAML Basics**
---------------------------
Each element needs an opening tag and a closing tag. Below is an example of creating a label. Between the two tags is the content that can vary depending on what element you are using (a label takes in a string). When creating events in visual studio, you can always press ctrl+space to get suggestions or to see the contents or properties of an element as there are too many to cover.

```xaml
<Label>Hello World</Label>
```
It is possible to directly close the opening tag.

```xaml
<Label Content = "Hello"/>
```

**Panels**
-----------------
There are different types of panels. The most commonly used are stackpanels and grids. They are essentially containers that can contain multiple items.

```xaml
<StackPanel>
    <Button></Button>
    <Button></Button>
</StackPanel>
```

**Modifying Properties**
-----------------
If we want to modify an element like a button, we can modify its properties. Each element has different kinds of properties. You can take a look at button properties [here](https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.button?view=windowsdesktop-6.0).

```xaml
<Button FontWeight="Bold" FontSize="20"/>
```

**Window Properties**
---------------
Some important window properties
- WindowState - Controls the initial windows state. Settings are Normal, Maximized, or Minimized
- WindowStartupLocation - Controls the initial location of your window
- Top most - If set to true, your window sill stay on top of other windows unless minimized
- SizeToContent - Decides if the window should resize itself to automatically fit its content
- ShowInTaskbar - If set to false, your window won't be represented in the Windows taskbar
- Icon - Allows you to define the icon of the window
- ResizeMode - Decides whether the user can resize your window or not

```xaml
<Window x:Class="WpfApp1.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp1"
        mc:Ignorable="d"
        Topmost ="True"
        WindowState="Normal"
        WindowStartupLocation="CenterScreen"
        SizeToContent="Manual"
        ShowInTaskbar="True"
        ResizeMode="NoResize"
        Title="Xaml Tutorial" Height="300" Width="400">
</Window>

```

**xmlns**
-------------------
- **xmlns** - Defines the namespace in which to resolve xml element names. It is defining the default namespace by which an XML element name should be resolved.

- **xmlns: d** - WPF Designer, it is a tool provided by VS that allows one to see what the user interface looks like without have to build and run the application each time. Will not have any impact on the application when you run the application (only shows in the designer).
```xaml
d:DesignHeight="450"
d:DesignWidth="800"
```
- **xmlns: mc** - Stands for markup compatibility. Leverages a markup compatibility pattern that is not necessarily XAML specific. Some code is interpreted strictly by the designer.

- **xmlns: x** - Non-default namespace. Defintes a qualified namespace for XAML specific elements. If you want an element name to be resolved within this namespace qualify it with x.
```xaml
<Label x:Name="MyLabel"/>
```

**Working with a WPF Project**
---------------------------
To begin we need to create a WPF file. We do so in visual studio, so create a new project and look for "WPF Application". After the WPF file is created, we will see that both a xaml and cs file were created. We will begin by looking at the xaml file.

```xaml
<Window x:Class="WpfApp1.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp1"
        mc:Ignorable="d"
        Title="MainWindow" Height="450" Width="800">
</Window>
```
The above is the start of our xaml file. We can change the title, height, and the width of the project to whatever we want. To start, I will replace grid with StackPanel, so we can stack our elements. Then I'll add a label and a button.

```xaml
<Window x:Class="WpfApp1.MainWindow"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:WpfApp1"
        mc:Ignorable="d"
        Title="Xaml Tutorial" Height="300" Width="400">
    <StackPanel>
        <Label>Hello World</Label>
        <Button>Click me!</Button>
    </StackPanel>
</Window>
```

**Textblock**
-------------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179880217-a2e907fb-3c23-4485-ab77-cc13360a3d57.png"><img>
</p>

Here we have two textblocks inside of our XAML file. They are contained in a stackpanel and use properties like LineBreak, Bold, Italic, Hyperlink, Span, and TextWrapping.
- **LineBreak** - Create a newline
- **Bold** - Make the words bold
- **Italic** - Make the words Italic
- **Hyperlink** - Create a hyperlink
- **Span** - Split the textblock to set different properties
- **TextWrapping** - Set how the textblock should handle words going over the edge

```xaml
<StackPanel>
    <TextBlock x:Name ="myTextBlock">Hello <Bold>World</Bold> <Italic>And bye</Italic>
    <LineBreak></LineBreak>A newline is creaed. My github can be found <Hyperlink RequestNavigate="Hyperlink_RequestNavigate" NavigateUri="https://www.github.com/kttra">here</Hyperlink>.
    </TextBlock>
    <TextBlock TextWrapping="Wrap" Foreground="BlueViolet">
        It was a slippery slope and he was <Span Foreground="Black">willing</Span>
        to slide all the way to the deepest depths.
    </TextBlock>
    <Label>Hello World Label</Label>
</StackPanel>
```
Navigation Event Arg
```cs
public MainWindow()
{
    InitializeComponent();
    myButton.FontSize = 15;
    myButton.Content = "Hi there";
}
private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
{
    System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo { FileName = @"http://www.github.com/kttra", UseShellExecute = true });
}
```

**Textblock In CS**
-------------------
The below code shows some ways we can edit buttons or textblocks in the cs file side.

```cs
//Changing button front and text
myButton.FontSize = 15;
myButton.Content = "Hi there";
//Changing textblock text and foreground
myTextBlock.Text = "Hello from the CS side";
myTextBlock.Foreground = Brushes.Blue;

//Manually creating a textblock and altering its properties
TextBlock myTb = new TextBlock();
myTb.Text = "Text Created in CS file";
myTb.Inlines.Add("\nAdded using inlines method ");
myTb.Inlines.Add(new Run("Text added in the code.")
{
    Foreground = Brushes.Blue,
    TextDecorations = TextDecorations.Underline,
});
myTb.TextWrapping = TextWrapping.Wrap;
myTb.Foreground = Brushes.BlueViolet;
this.Content = myTb; //Make this the content of the current window
```

**Image**
---------------
The image control will be used a lot in some applications. It can also be contained in many of the WPF elements, so that's why this is one of the first things I wanted to cover first. We can load an image from a link or from a directory.

```xaml
<Image Width="30" Source="https://flyclipart.com/thumb2/random-icon-219113.png"></Image>
<Image Width="30" Source="pack://application:,,,/Images/image.png"></Image>
```

**Label**
-------------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179880103-a1308b5a-8f08-45dd-b1d6-dee1008c26b5.png"><img>
</p>

Two ways to edit the text/content of a label.

```xaml
<Label Content="Hello World"></Label>
<Label>Hello World</Label>
```
It is possible to contain other elements in the label like a stackpanel, image, textbox, and accesstext. We can also change the orientation of a stackpanel to horizontal. Some elements we can edit in a label are the Margin, BorderBrush, and BorderThickness.

```xaml
<Label Margin="1,1,1,1"
       BorderBrush="Black"
       BorderThickness="1">
    <StackPanel Orientation="Horizontal">
            <Label>Hello World</Label>
            <Image Source="https://flyclipart.com/thumb2/random-icon-219113.png" Width="30"></Image>
            <AccessText FontSize="17" Text="Image"/>
            <TextBox FontSize="17" Width="234" Margin="5,0,5,0"></TextBox>
    </StackPanel>
</Label>
```

**TextBox**
-------------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179880064-d1d4dbdc-e1d5-4a83-b6b3-be8276871ecf.png"><img>
</p>

The textbox is very similar to a label and has some similar properties. Some of the properties are Fontsize, Margin, AcceptsReturn, TextWrapping, SpellCheck.IsEnabled, Foreground, Background, IsReadOnly, and Language.

```cs
<TextBox FontSize="17"
         Margin="2,2,2,2"
         AcceptsReturn="True"
         TextWrapping="Wrap"
         SpellCheck.IsEnabled="True"
         Language="en-US"
         Foreground="AntiqueWhite"
         Background="Beige"
         IsReadOnly="False">
</TextBox>
```

**Button**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179880009-a0f8be18-8bbe-4aa4-96f0-13d4ac5153d3.png"><img>
</p>

A button can allow the user to interact with the application.
```xaml
<StackPanel Orientation="Horizontal">
    <Label x:Name="testLabel">Label testing</Label>
    <Button x:Name ="testButton" Width="80" Height="20" Click="testButton_Click">Click me!</Button>
</StackPanel>
```
In the CS file, we can have a Button_Click event. In this example, we change the label color to gold and increase the font size by one everytime the button is clicked.
```cs
private void testButton_Click(object sender, RoutedEventArgs e)
{
    testLabel.Foreground = Brushes.Gold;
    testLabel.FontSize += 1;
}
```

**RadioButton**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179879951-9bd64ca0-7046-4227-8dcb-389ee15f08ee.png"><img>
</p>

When one button is pressed, the other buttons will cancel. Able to have a selection of a couple of buttons which belong together and once we press on one, the others will not be active at the same time. We can separate radio button groups by setting a group name. Along with the GroupName property, we also have the IsChecked property to set the default selection if we wish to do so.

There are also event handlers are event handlers for when a radio button is checked and unchecked. I will not go into detail on this here.

```xaml
<StackPanel>
    <Label FontWeight="Bold" FontSize="10">Who do you vote for?</Label>
    <RadioButton GroupName="Candidates" IsChecked="True">Candidate 1</RadioButton>
    <RadioButton GroupName="Candidates">Candidate 2</RadioButton>
    <RadioButton GroupName="Candidates">Candidate 3</RadioButton>
    <RadioButton GroupName="Candidates">Candidate 4</RadioButton>
</StackPanel>
```
If you want to add an image instead of text for the radio button, we can use a wrap panel. We will also want to change the alignment so that the radio button is centered with the image.

```xaml
<RadioButton GroupName="Candidates" VerticalContentAlignment="Center">
    <WrapPanel>
        <Image Width="30" Source="https://flyclipart.com/thumb2/random-icon-219113.png"></Image>
    </WrapPanel>
</RadioButton>
```

**CheckBox**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179879915-75cb48be-b18a-4b85-9db4-a66070ece53e.png"><img>
</p>

A normal checkbox. Usually used for setting multiple settings or share preferences. Similar to radio buttons, checkboxes also have the checked and unchecked event handler. We can also insert an image in a similar way. In addition, there is a property called IsThreeState which is used generally for a select all checkbox.

```xaml
<StackPanel Orientation="Horizontal">
    <Label FontSize="11">Ice Cream:</Label>
    <CheckBox FontSize="11" Margin="5,5,0,5">Chocolate</CheckBox>
    <CheckBox FontSize="11" Margin="5,5,0,5">Strawberry</CheckBox>
</StackPanel>
```

**Password Box**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179879859-47294591-c9cb-4dd9-b437-83f06e358f0b.png"><img>
</p>

A password box let's us work with passwords. It works similar to a textbox. With the PasswordChar property we can change what character appears in the password box.

```xaml
<StackPanel Margin="5">
    <Label FontSize="10">Name:</Label>
    <TextBox></TextBox>
    <Label FontSize="10">Password:</Label>
    <PasswordBox PasswordChar="*" MaxLength="4"></PasswordBox>
</StackPanel>
```

**Slider**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179879751-2d7eea5d-e7bc-4999-81b0-988dcd293314.png"><img>
</p>

A simple UI control that allows you to slide left and right. In this code, we set up a slider with a textblock. We want the textblock to update based on the value of the slider.

```xaml
<StackPanel VerticalAlignment="Center" Margin="5">
    <Slider x:Name="mySlider" Maximum="100" Minimum="0" TickFrequency="10" IsSnapToTickEnabled="True"
            Value="10" ValueChanged="mySlider_ValueChanged"></Slider>
    <TextBlock x:Name="sliderTextblock"></TextBlock>
</StackPanel>
```
For our ValueChanged event handler we have to make sure that we have a check in place to allow for the textblock to load before editing it.

```cs
private void mySlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
{
    //Need this check so that slider can be initialized into the UI
    if(sliderTextblock != null)
    {
        sliderTextblock.Text = "Slider value: " + mySlider.Value.ToString();
    }
}
```
We can use xaml code to bind the textblock's font property to the slider's value property.
```xaml
<StackPanel VerticalAlignment="Center" Margin="5">
    <Slider x:Name="mySlider" Maximum="100" Minimum="0" TickFrequency="10" IsSnapToTickEnabled="True"
            Value="10" ValueChanged="mySlider_ValueChanged"></Slider>
    <TextBlock x:Name="sliderTextblock" FontSize = "{Binding ElementName = mySlider, Path=Value, UpdateSourceTrigger = PropertyChanged}"></TextBlock>
</StackPanel>
```

**Calender**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179871114-fa0fdd32-1309-48d0-9fcc-6c8966416d88.png" width="250" height="250"><img>
</p>

A simple calender control. Some common properteries for a calender are: SelectedDate, DisplayMode, Calendar.BlackoutDates, CalendarDateRange, and SelectedDatesChanged.
```xaml
<StackPanel Orientation="Horizontal">
    <Viewbox Stretch="Uniform" Height="102" Width="145" HorizontalAlignment="Left">
        <Calendar SelectedDate="01.01.2022" DisplayMode="Month" x:Name="myCalender" SelectedDatesChanged="myCalender_SelectedDatesChanged">
            <Calendar.BlackoutDates>
                <CalendarDateRange Start="01.01.2022" End="03.05.2022"/>
            </Calendar.BlackoutDates>
        </Calendar>
    </Viewbox>
    <TextBlock x:Name="calenderText"></TextBlock>
</StackPanel>
```
In C# we can use the SelectedDatesChanged handler to change the text of a textblock whenever the date selected is changed.
```csharp
private void myCalender_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
{
    if(calenderText != null)
        calenderText.Text = myCalender.SelectedDate.ToString();
}
```

**DatePicker**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179873414-d9357b42-a690-48ad-bd95-84d7b162073f.png"><img>
</p>

A date picker is very similar to the calendar control except it comes in an included textbox. Some common properties include: SelectedDate, SelectedDateFormat, SelectedDateChanged, and DatePicker.BlackoutDates.
```xaml
<StackPanel>
    <DatePicker SelectedDate="07/19/2022" SelectedDateFormat="Short" SelectedDateChanged="DatePicker_SelectedDateChanged">
        <DatePicker.BlackoutDates>
            <CalendarDateRange Start="07/20/2022" End="07/23/2022"/>
        </DatePicker.BlackoutDates>
    </DatePicker>
</StackPanel>
```
Like the calendar control, we can make a SelectedDateChanged handler.
```cs
private void DatePicker_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
{
    string selectedDate = ((DatePicker)sender).SelectedDate.ToString();
    //Do something with selectedDate
}
```

**Expander**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179874156-a2f88462-d26a-411e-a973-3c68e3483852.png"><img>
</p>

An expander is a useful control to use when you are trying to hide a spoiler or a large block of text (other controls can also be placed inside). Clicking on the expander will unhide whatever is instead of it. Clicking on it again will hide its contents. Common properteries: Header, IsExpanded, Expanded, and Collapsed.

```xaml
<StackPanel>
    <Expander x:Name="myExpander" Header="Click me to expand" IsExpanded="False" Expanded="Expander_Expanded" Collapsed="myExpander_Collapsed">
        <TextBlock TextWrapping="Wrap" FontSize="10">He wore the surgical mask in public not to keep from catching a virus, but to keep people away from him.</TextBlock>
    </Expander>
</StackPanel>
```
Expanded and collapsed code behind.
```cs
private void Expander_Expanded(object sender, RoutedEventArgs e)
{
    myExpander.Header = "";
}
private void myExpander_Collapsed(object sender, RoutedEventArgs e)
{
    myExpander.Header = "Click me to expand";
}
```

**Grid**
---------------
<p align="center">
<img src="https://user-images.githubusercontent.com/100814612/179882835-cbc6a6dc-2e44-40ad-b20c-376d9cb79191.png"><img>
</p>

A Grid contains a collection of UI Element objects.

```xaml
<Grid ShowGridLines="false">
    <Grid.ColumnDefinitions>
        <ColumnDefinition Width="1*"/>
        <ColumnDefinition Width="50"/>
        <ColumnDefinition Width="Auto"/>
        <!--Width = "0.33*" With "*" means that the percentage value will be taken, without is pixel value-->
    </Grid.ColumnDefinitions>
    <Grid.RowDefinitions>
        <RowDefinition Height="auto"/>
        <RowDefinition Height="auto"/>
        <RowDefinition Height="auto"/>
    </Grid.RowDefinitions>
    <Rectangle Grid.Column="0" Grid.Row="0" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="0" Grid.Row="1" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="0" Grid.Row="2" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="1" Grid.Row="0" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="1" Grid.Row="1" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="1" Grid.Row="2" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="2" Grid.Row="0" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="2" Grid.Row="1" Stroke="Blue" Fill="Transparent" />
    <Rectangle Grid.Column="2" Grid.Row="2" Stroke="Blue" Fill="Transparent" />
    <Button Grid.Column="0" Grid.Row="0">Button 0</Button>
    <TextBlock Grid.Column="0" Grid.Row="1" TextAlignment="Center">Grid example</TextBlock>
    <Button Grid.Column="1" Grid.Row="1" Grid.ColumnSpan="2">Button 1</Button>
    <Button Width="60" Grid.Column="2" Grid.Row="2">Button 2</Button>
</Grid>
```

**Layout Panels**
----------
Throughout most of this project, I have mainly used stackpanels to showcase the controls. There are other type of layout panels such as WrapPanel, DockPanel, and Canvas. WrapPanel allows the contained controls to wrap to the next line and adjust itself accordingly to the window size. DockPanel changes the position of an element relative to other elements within the same container. A canvas is an open space where you can position your elements in.
