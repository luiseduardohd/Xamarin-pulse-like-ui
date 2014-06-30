using System;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Collections.Generic;
using System.Drawing;
using MonoTouch.CoreGraphics;

namespace PulseLikeUI
{
	public class TableViewCell: UITableViewCell
	{
		
		public UITableView horizontalTableView ;

		
		public List<string> contentArray = new List<string>() ;

		public TableViewCell() : base()
		{
			inizialize();
		}

		public TableViewCell (UITableViewCellStyle style, string cellIdentifier):base(style,cellIdentifier)
		{
			//throw new NotImplementedException ();
			inizialize();
		}
		public TableViewCell(IntPtr handle) : base(handle)
		{
			inizialize();
		}
		void inizialize ()
		{

//			if( horizontalTableView != null)
//			{
//				if(this.horizontalTableView.Source==null)
//					this.horizontalTableView.Source = new MyTableViewDelegate (this);
//			}
//			else
//			{
//				UITableView tableview6=new UITableView(new RectangleF(0,0,220,320),UITableViewStyle.Plain);
////				horizontalTableView=new UITableView(new RectangleF(0,0,220,320));
////				{
////			        AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth,
////					BackgroundColor = UIColor.Yellow
////			    };
//
//
//tableview6.AllowsMultipleSelection = false;
//tableview6.AllowsMultipleSelectionDuringEditing = false;
//tableview6.AllowsSelection = true;
//tableview6.AllowsSelectionDuringEditing = false;
//tableview6.Alpha = 1.000f;
//tableview6.AlwaysBounceHorizontal = false;
//tableview6.AlwaysBounceVertical = true;
//tableview6.AutosizesSubviews = true;
//tableview6.AutoresizingMask = UIViewAutoresizing.FlexibleWidth | UIViewAutoresizing.FlexibleHeight;
//tableview6.BackgroundColor = UIColor.White;
//tableview6.Bounces = true;
//tableview6.BouncesZoom = true;
//tableview6.CanCancelContentTouches = true;
//tableview6.ClearsContextBeforeDrawing = true;
//tableview6.ClipsToBounds = true;
//tableview6.ContentMode = UIViewContentMode.ScaleToFill;
//tableview6.ContentStretch = new RectangleF(0, 0, 1, 1);
//tableview6.DelaysContentTouches = true;
//tableview6.DirectionalLockEnabled = false;
//tableview6.Frame = new RectangleF(0.0f, 0.0f, 220.0f, 768.0f);
//tableview6.Hidden = false;
//tableview6.IndicatorStyle = UIScrollViewIndicatorStyle.Default;
//tableview6.MaximumZoomScale = 1.000f;
//tableview6.MinimumZoomScale = 1.000f;
//tableview6.MultipleTouchEnabled = false;
//tableview6.Opaque = true;
//tableview6.PagingEnabled = false;
//tableview6.RowHeight = 44;
//tableview6.ScrollEnabled = true;
//tableview6.SectionFooterHeight = 22;
//tableview6.SectionHeaderHeight = 22;
//tableview6.SectionIndexMinimumDisplayRowCount = 0;
//tableview6.SeparatorStyle = UITableViewCellSeparatorStyle.SingleLine;
//tableview6.ShowsHorizontalScrollIndicator = true;
//tableview6.ShowsVerticalScrollIndicator = true;
//tableview6.Tag = 0;
//tableview6.UserInteractionEnabled = true;
//
//				horizontalTableView=tableview6;
//				
//			    horizontalTableView.SizeToFit();
//			    //horizontalTableView.Frame = new RectangleF ( 0, 0, this.Frame.Width, this.Frame.Height );
//			    
//				this.horizontalTableView.Source = new MyTableViewDelegate (this);
//				this.horizontalTableView.ShowsVerticalScrollIndicator=false;
//			}
//
//			this.AddSubview(horizontalTableView);
		}
//		public override void Draw (RectangleF rect)
//		{
//		     var context = UIGraphics.GetCurrentContext ();
//		     UIColor.Green.SetColor ();
//		     context.FillRect (Bounds);
//
//			CGColorSpace colorSpace = CGColorSpace.CreateDeviceRGB();
//
//            CGGradient gradient = new CGGradient 
//				(
//					colorSpace,
//					new float[] { 1, 0, 0, 1,    // start color
//
//                              0, 0, 1, 1 },    // end color
//
//                new float[] { 0, 1 } );        // locations
//
//		     context.DrawLinearGradient (gradient,new PointF(0,0) , new PointF( this.Frame.Size.Width,this.Frame.Size.Height), 0);
//		}
		public class MyTableViewDelegate : UITableViewSource
		{
			TableViewCell tableViewCell;
			public MyTableViewDelegate (TableViewCell tableViewCell)
			{
				this.tableViewCell=tableViewCell;
			}
 			/*
			public MyTableViewDelegate (AerolineaListTableViewController controller, string filter)
			{
				Console.WriteLine ("MyTableViewDelegate(AerolineaListTableViewController controller,string filter)");
				this.controller = controller;
				this.controller.eventos = Database.Main.Query<Evento> (
					//"SELECT titulo,descripcion,urlLogo FROM Eventos ORDER BY  titulo asc "
					"SELECT event_title,description,coalesce(logo , \"\") FROM tbl_event ORDER BY  event_title asc "
					);
				//Console.WriteLine("eventos.Count "+ controller.eventos.Count );
				//controller.eventos =  controller.eventos.Where(f => f.titulo.StartsWith(filter));
				//controller.eventos = (List<Evento>) (from e in controller.eventos where e.titulo.Contains(filter) select e );
				var e = controller.eventos.Where (f => f.titulo.StartsWith (filter));
				controller.eventos = (List<Evento>)e.ToList ();
				controller.botones = new List<UIButton> (2);
				//Console.WriteLine("eventos.Count "+ controller.eventos.Count );
			}	
			*/
			
			public override int NumberOfSections (UITableView tableView)
			{
				return 1;
			}

			public override int RowsInSection (UITableView tableview, int section)
			{
				return tableViewCell.contentArray.Count;
			}
			//UILabel label;
		    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		    {
				const string cellName = "Cell";
				UITableViewCell cell = tableViewCell.horizontalTableView.DequeueReusableCell(cellName);//tableView.DequeueReusableCell (cellName);
				if (cell == null) {
					cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellName);
					//cell.EditingAccessory = UITableViewCellAccessory.DetailDisclosureButton;
					//cell.set
				}

				
				foreach ( UIView view in cell.Subviews) 
				{
					//if(view is UIImageView)
						view.RemoveFromSuperview();
			    }

				UIImageView imageView = new UIImageView(new RectangleF(0, 0, 40, 40));
				//imageView.Image = UIImage.FromBundle("Apple.png");
				imageView.Image = new UIImage(tableViewCell.contentArray[indexPath.Row]);

				imageView.ExclusiveTouch=true;

			    //Use UIContentModeScaleAspectFit or other depending upon the size of your images,mine were small but not proportional so...    
			    imageView.ContentMode = UIViewContentMode.ScaleToFill;
			    CGAffineTransform rotateImage = CGAffineTransform.MakeRotation((float)Math.PI*0.5f );
			    imageView.Transform = rotateImage;
				//imageView.UserInteractionEnabled=false;
				cell.AddSubview(imageView);

				return cell;
			}

			public override float GetHeightForRow (UITableView tableView, NSIndexPath indexPath)
			{
				return 40;
			}	


			/*
			public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
			{
				Console.Out.WriteLine ("RowSelected");
				
				controller.eventoSeleccionado = controller.hoteles [indexPath.Row];
				controller.PerformSegue ("toDetailView", tableView);
				
				Console.Out.WriteLine ("RowSelected end");
			}
			*/
		}
	}
}

