using System;
using MonoTouch.UIKit;
using MonoTouch.CoreGraphics;
using System.Drawing;
using MonoTouch.Foundation;
using System.Collections.Generic;

namespace PulseLikeUI
{
	public partial class HorizontalTableCell2 : UITableViewCell
	{
		public List<string> contentArray ;

		public UITableView horizontalTableView { get; set; }

		public HorizontalTableCell2() : base()
		{
			inizialize();
		}

		public HorizontalTableCell2 (UITableViewCellStyle style, string cellIdentifier):base(style,cellIdentifier)
		{
			//throw new NotImplementedException ();
			inizialize();
		}
		public HorizontalTableCell2(IntPtr handle) : base(handle)
		{
			inizialize();
		}

		void inizialize ()
		{

			if( horizontalTableView != null)
			{
				if(this.horizontalTableView.Source==null)
					this.horizontalTableView.Source = new MyTableViewDelegate ();
			}
			else
			{
				horizontalTableView=new UITableView(new RectangleF(0,0,220,320))
				{
			        AutoresizingMask = UIViewAutoresizing.FlexibleHeight | UIViewAutoresizing.FlexibleWidth,
					BackgroundColor = UIColor.Yellow
			    };
				
			    horizontalTableView.SizeToFit();
			    //horizontalTableView.Frame = new RectangleF ( 0, 0, this.Frame.Width, this.Frame.Height );
			    
				this.horizontalTableView.Source = new MyTableViewDelegate ();
				this.horizontalTableView.ShowsVerticalScrollIndicator=false;
			}

			this.AddSubview(horizontalTableView);
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
		class MyTableViewDelegate : UITableViewSource
		{
			
			public MyTableViewDelegate ()
			{

				
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
				return 7;
			}
			//UILabel label;
		    public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		    {
				const string cellName = "Cell2";
				var cell = tableView.DequeueReusableCell (cellName);
				if (cell == null) {
					cell = new UITableViewCell (UITableViewCellStyle.Subtitle, cellName);
					cell.EditingAccessory = UITableViewCellAccessory.DetailDisclosureButton;
					//cell.set
				}
				
				foreach ( UIView view in cell.Subviews) 
				{
					if(view is UIImageView)
						view.RemoveFromSuperview();
			    }

				UIImageView imageView = new UIImageView(new RectangleF(10, 10, 40, 40));
				imageView.Image = UIImage.FromBundle("Apple.png");

			    //Use UIContentModeScaleAspectFit or other depending upon the size of your images,mine were small but not proportional so...    
			    imageView.ContentMode = UIViewContentMode.ScaleAspectFill;
			    CGAffineTransform rotateImage = CGAffineTransform.MakeRotation((float)Math.PI/2 );
			    imageView.Transform = rotateImage;
				imageView.UserInteractionEnabled=false;
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

