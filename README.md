# WPF Overview
C# WPF overview on xaml. Xaml stands for eXtensible Application Markup Language. Microsoft's version of XML for coding a graphical user inferace (GUI). It is an essential part of WPF. Each GUI element (a window or page), will consist of a XAML file and a CodeBehind (.cs) file. They both work together to create the window or page.

The XAML file characterizes the GUI with all its element while the CS file handles all the evenets and has access to shape and manipulate the GUI elements. Each line of XAML code can be written in the CS file.

**XAML Basics**
---------------------------
Each element needs an opening tag and a closing tag. Below is an example of creating a label. Between the two tags is the content that can vary depending on what element you are using (a label takes in a string).

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
    <Grid>

    </Grid>
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
