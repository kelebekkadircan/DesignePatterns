namespace IteratorDP.IteratorPattern
{
    public class VisitRouteIterator : Iterator<VisitorRoute>
    {
        private VisitRouteMover _visitRouteMover;

        public VisitRouteIterator(VisitRouteMover visitRouteMover)
        {
            _visitRouteMover = visitRouteMover;
        }

        private int _current = 0;
        public VisitorRoute CurrentItem { get; set; }



        public bool HasNext()
        {
            if (_current < _visitRouteMover.VisitorRouteCount)
            {
                CurrentItem = _visitRouteMover.visitorRoutes[_current++];
               
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
