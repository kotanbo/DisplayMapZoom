using MapKit;

namespace DisplayMapZoom
{
    public class GsiTileOverlay : MKTileOverlay
    {
        public GsiTileOverlay() : base("https://cyberjapandata.gsi.go.jp/xyz/std/{z}/{x}/{y}.png")
        {
        }
    }
}
