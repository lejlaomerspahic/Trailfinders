﻿namespace Trailfinders;

public partial class App : Application
{
	public App()
	{

        InitializeComponent();

		MainPage = new AppTabbedPage();
	}
}
