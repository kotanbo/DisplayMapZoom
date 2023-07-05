using MapKit;
using UIKit;

namespace DisplayMapZoom
{
    public class MapViewDelegate : MKMapViewDelegate
    {
        UILabel _coordinateSpanLabel;

        public MapViewDelegate(UILabel coordinateSpanLabel)
        {
            _coordinateSpanLabel = coordinateSpanLabel;
        }

        public override MKOverlayRenderer OverlayRenderer(MKMapView mapView, IMKOverlay overlay)
        {
            if (overlay is MKTileOverlay tileOverlay)
            {
                return new MKTileOverlayRenderer(tileOverlay);
            }
            return null;
        }

        public override void RegionChanged(MKMapView mapView, bool animated)
        {
            _coordinateSpanLabel.Lines = 2;
            _coordinateSpanLabel.Text = $"latitude delta = {mapView.Region.Span.LatitudeDelta}\nlongitude delta = {mapView.Region.Span.LongitudeDelta}";
        }
    }
}