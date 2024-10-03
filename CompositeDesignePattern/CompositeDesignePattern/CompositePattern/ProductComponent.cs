using System.Text.RegularExpressions;

namespace CompositeDesignePattern.CompositePattern
{
    public class ProductComponent : IComponent
    {
        public ProductComponent(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public int ID { get  ; set; }
        public string Name { get; set; }

        public string Display()
        {
            return $"<li class='list-group-item' >{Name}</li>";
        }

        public int TotalCount()
        {
            return 1;
        }
    }
}
