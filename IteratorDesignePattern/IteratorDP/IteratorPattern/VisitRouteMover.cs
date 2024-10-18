namespace IteratorDP.IteratorPattern
{
    public class VisitRouteMover : IMover<VisitorRoute>
    {
        public List<VisitorRoute> visitorRoutes = new List<VisitorRoute>();

        public void AddVisitorRoute(VisitorRoute visitorRoute)
        {
            visitorRoutes.Add(visitorRoute);
        }

        public int VisitorRouteCount
        {
            get { return visitorRoutes.Count; }
        }


        public Iterator<VisitorRoute> CreateIterator()
        {
            return new VisitRouteIterator(this);
        }
    }
}
