
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using System.Collections.Generic;

namespace PulseLikeUI
{
	//[Register("TableViewController")]
	public partial class TableViewController : UIViewController
	{
		public UITableView tableView;
		public TableViewCell tableViewCell;

		public List<string> titlesArray;
		public List<string> peopleArray;
		public List<string> thingsArray;
		public List<string> fruitsArray;
		public List<List<string>> arrays;

//		static bool UserInterfaceIdiomIsPhone {
//			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
//		}
//
//		public TableViewController ()
//			: base (UserInterfaceIdiomIsPhone ? "TableViewController_iPhone" : "TableViewController_iPad", null)
//		{
//		}
		public TableViewController ():base()
		{
		}
		
		public TableViewController(IntPtr handle) : base(handle)
		{

		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.


			titlesArray = new List<string>(){@"People", @"Things", @"Fruits",@"People", @"Fruits", @"Things", @"Fruits",@"People", @"Things", @"Fruits", @"Fruits", @"Fruits", @"Things", @"Fruits",@"People"};
			peopleArray = new List<string>(){@"Gardener.png", @"Plumber.png", @"BusinessWoman.png", @"BusinessMan.png", @"Chef.png", @"Doctor.png",@"Gardener.png", @"Plumber.png", @"BusinessWoman.png", @"BusinessMan.png", @"Chef.png", @"Doctor.png"};
			thingsArray = new List<string>(){@"StopWatch.png", @"TrashCan.png", @"Key.png", @"Telephone.png", @"ChalkBoard.png", @"Bucket.png",@"StopWatch.png", @"TrashCan.png", @"Key.png", @"Telephone.png", @"ChalkBoard.png", @"Bucket.png"};
			fruitsArray = new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"};
    
    arrays = new List<List<string>>(){
              peopleArray, 
              thingsArray, 
              fruitsArray,
              new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
              new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
              new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
              new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
              new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
              new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
				new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
				new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
				new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"},
				new List<string>(){@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png",@"Pineapple.png", @"Orange.png", @"Apple.png"}
				};

			
			//this.tableView.Source = new DataSource (this);
			//UITableView tableview4=new UITableView(new RectangleF(0.0f, 0.0f, 768.0f, 1004.0f ),UITableViewStyle.Plain);
			UITableView tableview4=this.tableView;

//tableview4.AllowsMultipleSelection = false;
//tableview4.AllowsMultipleSelectionDuringEditing = false;
//tableview4.AllowsSelection = true;
//tableview4.AllowsSelectionDuringEditing = false;
//tableview4.Alpha = 1.000f;
//tableview4.AlwaysBounceHorizontal = false;
//tableview4.AlwaysBounceVertical = true;
//tableview4.AutosizesSubviews = true;
//tableview4.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
//tableview4.BackgroundColor = UIColor.White;
//tableview4.Bounces = true;
//tableview4.BouncesZoom = true;
//tableview4.CanCancelContentTouches = true;
//tableview4.ClearsContextBeforeDrawing = true;
//tableview4.ClipsToBounds = true;
//tableview4.ContentMode = UIViewContentMode.ScaleToFill;
//tableview4.ContentStretch = new RectangleF(0, 0, 1, 1);
//tableview4.DelaysContentTouches = true;
//tableview4.DirectionalLockEnabled = false;
//tableview4.Frame = new RectangleF(0.0f, 0.0f, 768.0f, 1004.0f);
//tableview4.Hidden = false;
//tableview4.IndicatorStyle = UIScrollViewIndicatorStyle.Default;
//tableview4.MaximumZoomScale = 1.000f;
//tableview4.MinimumZoomScale = 1.000f;
//tableview4.MultipleTouchEnabled = false;
//tableview4.Opaque = true;
//tableview4.PagingEnabled = false;
//tableview4.RowHeight = 40;
//tableview4.ScrollEnabled = true;
//tableview4.SectionFooterHeight = 22;
//tableview4.SectionHeaderHeight = 22;
//tableview4.SectionIndexMinimumDisplayRowCount = 0;
//tableview4.SeparatorStyle = UITableViewCellSeparatorStyle.SingleLine;
//tableview4.ShowsHorizontalScrollIndicator = true;
//tableview4.ShowsVerticalScrollIndicator = true;
//tableview4.Tag = 0;
//tableview4.UserInteractionEnabled = true;
//tableview4.SeparatorStyle=UITableViewCellSeparatorStyle.None;

		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
//			if (UserInterfaceIdiomIsPhone) {
//				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
//			} else {
//				return true;
//			}
			return true;
		}
		
		public class DataSource : UITableViewSource
		{
			TableViewController controller;
			public TableViewCell tableViewCell;

			public DataSource (TableViewController controller)
			{
				this.controller=controller;
			}
			
			// Customize the number of sections in the table view.
			public override int NumberOfSections (UITableView tableView)
			{
				return controller.arrays.Count;
			}
			
			public override int RowsInSection (UITableView tableview, int section)
			{
				return 1;
			}
			
			// Customize the appearance of table view cells.
			public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
			{
				string cellIdentifier = "Cell";

				//HorizontalTableCell cell = (HorizontalTableCell)tableView.DequeueReusableCell (cellIdentifier);
				TableViewCell cell = (TableViewCell)tableView.DequeueReusableCell (cellIdentifier);

				if (cell == null) {
					//cell = new TableViewCell (UITableViewCellStyle.Default, cellIdentifier);
					//tableViewCell = new TableViewCell ();
					tableViewCell = new TableViewCell (UITableViewCellStyle.Default, cellIdentifier);
					tableViewCell.Frame=new RectangleF(0, 0, 320 , 0);// Este era el problema ! 
			        //tableViewCell.UserInteractionEnabled = true;
			        //tableViewCell.ContentMode =UIViewContentMode.ScaleToFill;
			        //tableViewCell.ContentStretch = new RectangleF(0, 0, 1, 1);
			        //tableViewCell.horizontalTableView=[[UITableView alloc] initWithFrame:CGRectMake(0, 0, 320, 320)];
					//tableViewCell.horizontalTableView=new UITableView(new RectangleF(0, 0, 320, 320));
			        //tableViewCell.horizontalTableView.dataSource=tableViewCell;

					tableViewCell.horizontalTableView=new UITableView();
					tableViewCell.horizontalTableView.Source = new TableViewCell.MyTableViewDelegate (tableViewCell);
			        //tableViewCell.horizontalTableView.delegate=tableViewCell;
			        tableViewCell.AddSubview(tableViewCell.horizontalTableView); 
			        
			        //tableViewCell.horizontalTableView.frame=CGRectMake(0, 0, 100 , 320);
			        tableViewCell.horizontalTableView.Frame=new RectangleF(0, 0, 0 , 320);
//			        tableViewCell.horizontalTableView.AllowsSelection = true;
//			        tableViewCell.horizontalTableView.AlwaysBounceVertical = true;
//			        tableViewCell.horizontalTableView.AlwaysBounceHorizontal = false;
//			        tableViewCell.horizontalTableView.ContentMode =UIViewContentMode.ScaleToFill;
//			        tableViewCell.horizontalTableView.ContentStretch = new RectangleF(0, 0, 1, 1);
//			        tableViewCell.horizontalTableView.DelaysContentTouches = false;
//			        tableViewCell.horizontalTableView.ScrollEnabled = true;
					
			        //tableViewCell.horizontalTableView.
			        //tableViewCell.horizontalTableView.DirectionalLockEnabled = false;
			        tableViewCell.horizontalTableView.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
					//tableViewCell.horizontalTableView.AutoresizingMask
			        //tableViewCell.horizontalTableView.userInteractionEnabled = YES;
					//tableViewCell.horizontalTableView.SeparatorStyle=UITableViewCellSeparatorStyle.None;

					//tableViewCell.horizontalTableView.AlwaysBounceHorizontal=false;
					//tableViewCell.horizontalTableView.AlwaysBounceVertical = true;
					//tableViewCell.horizontalTableView.AlwaysBounceHorizontal = false;

					//tableViewCell.horizontalTableView.ScrollEnabled = true;
					//tableViewCell.horizontalTableView.ShowsHorizontalScrollIndicator=true;
					//tableViewCell.horizontalTableView.DirectionalLockEnabled = true;
					//tableViewCell.horizontalTableView.DelaysContentTouches=true;
					tableViewCell.horizontalTableView.CanCancelContentTouches=false;

					//tableViewCell.horizontalTableView.
			        
			        CGAffineTransform rotateTable = CGAffineTransform.MakeRotation(-3.141f * 0.5f);
			        tableViewCell.horizontalTableView.Transform = rotateTable;
			        tableViewCell.horizontalTableView.Frame = 
						new RectangleF
						(
							0, 
							0, 
							tableViewCell.horizontalTableView.Frame.Size.Width, 
							tableViewCell.horizontalTableView.Frame.Size.Height
						);
			        
			        //tableViewCell.contentArray = [arrays objectAtIndex:indexPath.section];
					tableViewCell.contentArray = controller.arrays [indexPath.Section];
			        
					//cell = [tableViewCell retain];
			        cell = tableViewCell ;
					//self.tableViewCell = nil;
				}

//				cell.Frame=new RectangleF(0,0,768,220);
//
//				
//				 CGAffineTransform rotateTable = CGAffineTransform.MakeRotation(-3.141f * 0.5f);
//		         cell.horizontalTableView.Transform = rotateTable;
//		         cell.horizontalTableView.Frame = new RectangleF(0, 0, 
//                 cell.Frame.Size.Width,
//                 cell.Frame.Size.Height);
//				cell.horizontalTableView.AllowsSelection=true;
//				cell.horizontalTableView.AllowsMultipleSelection=false;
//				cell.horizontalTableView.ScrollEnabled=true;
				//cell.horizontalTableView.DelaysContentTouches=false;
//				cell.horizontalTableView.CanCancelContentTouches=true;

				//cell.horizontalTableView.Transform.Rotate(-3.141f * 0.5f);
				//cell.Transform.Rotate
				//cell.Transform.Rotate(-3.141f * 0.5f);
				
				// Configure the cell.
				//cell.TextLabel.Text = NSBundle.MainBundle.LocalizedString ("Detail", "Detail");

				//cell.contentArray = controller.arrays[indexPath.Section];

				return cell;
			}

			/*
			// Override to support conditional editing of the table view.
			public override bool CanEditRow (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
			{
				// Return false if you do not want the specified item to be editable.
				return true;
			}
			*/
			
			/*
			// Override to support editing the table view.
			public override void CommitEditingStyle (UITableView tableView, UITableViewCellEditingStyle editingStyle, NSIndexPath indexPath)
			{
				if (editingStyle == UITableViewCellEditingStyle.Delete) {
					// Delete the row from the data source.
					controller.TableView.DeleteRows (new NSIndexPath[] { indexPath }, UITableViewRowAnimation.Fade);
				} else if (editingStyle == UITableViewCellEditingStyle.Insert) {
					// Create a new instance of the appropriate class, insert it into the array, and add a new row to the table view.
				}
			}
			*/
			
			/*
			// Override to support rearranging the table view.
			public override void MoveRow (UITableView tableView, NSIndexPath sourceIndexPath, NSIndexPath destinationIndexPath)
			{
			}
			*/
			
			/*
			// Override to support conditional rearranging of the table view.
			public override bool CanMoveRow (UITableView tableView, NSIndexPath indexPath)
			{
				// Return false if you do not want the item to be re-orderable.
				return true;
			}
			*/




			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{
//				if (UserInterfaceIdiomIsPhone) {
//					var DetailViewController = new DetailViewController ();
//					// Pass the selected object to the new view controller.
//					controller.NavigationController.PushViewController (DetailViewController, true);
//				} else {
//					// Navigation logic may go here -- for example, create and push another view controller.
//				}
			}
			public override string TitleForHeader (UITableView tableView, int section)
			{
				return controller.titlesArray[section];
			}



			public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
			{
				return 40;
			}
		}
	}
}

