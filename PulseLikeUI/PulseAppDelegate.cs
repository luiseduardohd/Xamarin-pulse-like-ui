using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using System.Drawing;

namespace PulseLikeUI
{
	[Register ("PulseAppDelegate")]
	public class PulseAppDelegate: UIApplicationDelegate
	{
//		public PulseAppDelegate ()
//		{
//		}
//		UINavigationController navigationController;
//		UISplitViewController splitViewController;
		public UIWindow window;
		public UIViewController viewController;
		
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{

			// Override point for customization after application launch.

			if (this.viewController == null) 
			{
		        
		        TableViewController tvc = new TableViewController() ;
				viewController=tvc;
				//viewController.View=new UIView();
		        tvc.tableView=new UITableView(new RectangleF(0, 0, 320, 480)) ;
		        //tvc.tableView.Delegate=
		        //tvc.tableView setDataSource:tvc];
				//tvc.tableView.UserInteractionEnabled=true;
				
				//tvc.TableView.RowHeight = 40;
				
				//tvc.TableView.SeparatorStyle=UITableViewCellSeparatorStyle.None;
				tvc.tableView.ScrollEnabled=true;
				tvc.tableView.Source=new TableViewController.DataSource(tvc);
		        //viewController.View.AddSubview(tvc.tableView);
		        //UITableView tableView= [[UITableView alloc] initWithFrame:CGRectMake(0, 0, 768, 1024)] ;
		        //[this.viewController.view addSubview:tvc.tableView];

				//this.viewController.View=new UIView(UIScreen.MainScreen.Bounds);
				//this.viewController.View.AddSubview(tvc.table);
				//

				this.viewController.View.AddSubview(tvc.tableView);
		        

    		}
		    if(this.window==null)
		    {

				// create a new window instance based on the screen size
				//window = new UIWindow (UIScreen.MainScreen.Bounds);
				window = new UIWindow (new RectangleF(0,0,320,480) );

				window.AddSubview(viewController.View);
		    }
			//[this.window addSubview: this.viewController.view];

			// make the window visible
			window.MakeKeyAndVisible ();
			
			return true;
		}
	}
}

