using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace PulseLikeUI
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "AppDelegate"
			// you can specify it here.

			try
			{
				//UIApplication.Main (args, null, "AppDelegate");
				//UIApplication.Main (args, null, "PulseAppDelegate");
				UIApplication.Main (args, null, "PulseAppDelegate");
			}
			catch(Exception e)
			{
				Console.WriteLine("Exception:" + e.Message);
			}
		}
	}
}
