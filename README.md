# WPF Overview
C# WPF overview on xaml.

To begin we need to create a WPF file. We do so through visual studio. After the WPF file is created, we will see that both a xaml and cs file were created. We will begin by looking at the xaml file.

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
