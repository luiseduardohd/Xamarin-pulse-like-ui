using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;

namespace PulseLikeUI
{
	public partial class RootViewController : UITableViewController
	{
		static bool UserInterfaceIdiomIsPhone {
			get { return UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone; }
		}

		public RootViewController ()
			: base (UserInterfaceIdiomIsPhone ? "RootViewController_iPhone" : "RootViewController_iPad", null)
		{
			if (!UserInterfaceIdiomIsPhone) {
				this.ClearsSelectionOnViewWillAppear = false;
				this.ContentSizeForViewInPopover = new SizeF (320f, 600f);
			}
			
			// Custom initialization
		}
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			
			this.TableView.Source = new DataSource ();
			//UITableView tableview4=new UITableView(new RectangleF(0.0f, 0.0f, 768.0f, 1004.0f ),UITableViewStyle.Plain);
			UITableView tableview4=this.TableView;

tableview4.AllowsMultipleSelection = false;
tableview4.AllowsMultipleSelectionDuringEditing = false;
tableview4.AllowsSelection = true;
tableview4.AllowsSelectionDuringEditing = false;
tableview4.Alpha = 1.000f;
tableview4.AlwaysBounceHorizontal = false;
tableview4.AlwaysBounceVertical = true;
tableview4.AutosizesSubviews = true;
tableview4.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
tableview4.BackgroundColor = UIColor.White;
tableview4.Bounces = true;
tableview4.BouncesZoom = true;
tableview4.CanCancelContentTouches = true;
tableview4.ClearsContextBeforeDrawing = true;
tableview4.ClipsToBounds = true;
tableview4.ContentMode = UIViewContentMode.ScaleToFill;
tableview4.ContentStretch = new RectangleF(0, 0, 1, 1);
tableview4.DelaysContentTouches = true;
tableview4.DirectionalLockEnabled = false;
tableview4.Frame = new RectangleF(0.0f, 0.0f, 768.0f, 1004.0f);
tableview4.Hidden = false;
tableview4.IndicatorStyle = UIScrollViewIndicatorStyle.Default;
tableview4.MaximumZoomScale = 1.000f;
tableview4.MinimumZoomScale = 1.000f;
tableview4.MultipleTouchEnabled = false;
tableview4.Opaque = true;
tableview4.PagingEnabled = false;
tableview4.RowHeight = 44;
tableview4.ScrollEnabled = true;
tableview4.SectionFooterHeight = 22;
tableview4.SectionHeaderHeight = 22;
tableview4.SectionIndexMinimumDisplayRowCount = 0;
tableview4.SeparatorStyle = UITableViewCellSeparatorStyle.SingleLine;
tableview4.ShowsHorizontalScrollIndicator = true;
tableview4.ShowsVerticalScrollIndicator = true;
tableview4.Tag = 0;
tableview4.UserInteractionEnabled = true;

			
			if (!UserInterfaceIdiomIsPhone)
				this.TableView.SelectRow (NSIndexPath.FromRowSection (0, 0), false, UITableViewScrollPosition.Middle);

//			titles = new List<String>(){@"People", @"Things", @"Fruits"};
//    		people = new List<String>(){@"Gardener.png", @"Plumber.png", @"BusinessWoman.png", @"BusinessMan.png", @"Chef.png", @"Doctor.png"};
//    		things = new List<String>(){@"StopWatch.png", @"TrashCan.png", @"Key.png", @"Telephone.png", @"ChalkBoard.png", @"Bucket.png"};
//    		fruits = new List<String>(){@"Pineapple.png", @"Orange.png", @"Apple.png"};
		}
		
		public override bool ShouldAutorotateToInterfaceOrientation (UIInterfaceOrientation toInterfaceOrientation)
		{
			// Return true for supported orientations
			if (UserInterfaceIdiomIsPhone) {
				return (toInterfaceOrientation != UIInterfaceOrientation.PortraitUpsideDown);
			} else {
				return true;
			}
		}
		
		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}
		
		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
			ReleaseDesignerOutlets ();
			//this.TableView.AllowsSelection
//			this.TableView.AllowsSelection=false;
//			this.TableView.AllowsMultipleSelection=false;
//			this.TableView.ScrollEnabled=true;
//			this.TableView.DelaysContentTouches=false;
			//this.TableView.CanCancelContentTouches=true;
		}
		
		class DataSource : UITableViewSource
		{


			public DataSource ()
			{
			}
			
			// Customize the number of sections in the table view.
			public override int NumberOfSections (UITableView tableView)
			{
				return 1;
			}
			
			public override int RowsInSection (UITableView tableview, int section)
			{
				return 3;
			}
			
			// Customize the appearance of table view cells.
			public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
			{
				string cellIdentifier = "HorizontalTableCell";

				//HorizontalTableCell cell = (HorizontalTableCell)tableView.DequeueReusableCell (cellIdentifier);
				HorizontalTableCell2 cell = (HorizontalTableCell2)tableView.DequeueReusableCell (cellIdentifier);

				if (cell == null) {
					cell = new HorizontalTableCell2 (UITableViewCellStyle.Default, cellIdentifier);
//					if (UIDevice.CurrentDevice.UserInterfaceIdiom == UIUserInterfaceIdiom.Phone) {
//						cell.Accessory = UITableViewCellAccessory.DisclosureIndicator;
//					}
				}

				cell.Frame=new RectangleF(0,0,768,220);

				
				 CGAffineTransform rotateTable = CGAffineTransform.MakeRotation(-3.141f * 0.5f);
		         cell.horizontalTableView.Transform = rotateTable;
		         cell.horizontalTableView.Frame = new RectangleF(0, 0, 
                 cell.Frame.Size.Width,
                 cell.Frame.Size.Height);
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
				return "Section:"+section;
			}



			public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
			{
				return 40;
			}
		}
	}
}

