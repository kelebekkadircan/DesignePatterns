namespace TemplateMethodDesignePattern.TemplatePattern
{
    public abstract class NetflixPlans
    {
        public void CreatePlan(string planType, int countPerson, double price, string resolution, string content)
        {
            PlanType(planType);
            CountPerson(countPerson);
            Price(price);
            Resolution(resolution);
            Content(content);
        }
        public abstract string PlanType(string planType);
        public  abstract int CountPerson(int countPerson);
        public  abstract double Price(double price);
        public  abstract string Resolution(string resolution);
        public  abstract string Content(string content);

    }
}
