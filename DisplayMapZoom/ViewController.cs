using System;
using MapKit;
using UIKit;

namespace DisplayMapZoom
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();

            var coordinateSpanLabel = new UILabel();
            var map = new MKMapView(View.Bounds)
            {
                Delegate = new MapViewDelegate(coordinateSpanLabel)
            };
            var gsiTileOverlay = new GsiTileOverlay()
            {
                CanReplaceMapContent = true
            };
            map.AddOverlay(gsiTileOverlay, MKOverlayLevel.AboveRoads);
            View.Add(map);

            coordinateSpanLabel.TextColor = UIColor.SystemRed;
            map.Add(coordinateSpanLabel);
            coordinateSpanLabel.TranslatesAutoresizingMaskIntoConstraints = false;
            NSLayoutConstraint.ActivateConstraints(new[] {
                coordinateSpanLabel.TopAnchor.ConstraintEqualTo(coordinateSpanLabel.Superview.TopAnchor, 20),
                coordinateSpanLabel.LeftAnchor.ConstraintEqualTo(coordinateSpanLabel.Superview.LeftAnchor, 5),
            });
        }
    }
}
