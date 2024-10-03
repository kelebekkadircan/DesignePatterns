using System.Collections;
using System.Text;

namespace CompositeDesignePattern.CompositePattern
{
    public class ProductComposite : IComponent
    {
        public int ID { get; set; }
        public string Name { get; set; }

        private List<IComponent> _components;

        public ProductComposite(int id, string name)
        {
            ID = id;
            Name = name;
            _components = new List<IComponent>();
        }

        public ICollection<IComponent> Components => _components;

        public void AddComponent(IComponent component)
        {
            _components.Add(component);
        }
        //public string Display()
        //{
        //    var stringbuilder = new StringBuilder();
        //    stringbuilder.Append($"<div class='list-group-item text-success' >{Name} ({TotalCount()}) </div>");
        //    stringbuilder.Append($"<ul class='list-group list-group-flush m-2 p-2'>");
        //    foreach (var component in _components)
        //    {
        //        stringbuilder.Append(component.Display());
        //    }
        //    stringbuilder.Append("</ul>");
        //    return stringbuilder.ToString();
        //}
        public string Display()
        {
            var stringbuilder = new StringBuilder();

            // Ana ürün başlığı tasarımı
            stringbuilder.Append($"<div class='list-group-item' style='background-color: #333333; color: #ffffff; padding: 10px 20px; border-radius: 5px; margin-bottom: 5px;'>");
            stringbuilder.Append($"{Name} ({TotalCount()})</div>");

            // Alt bileşenler için liste tasarımı
            stringbuilder.Append($"<ul class='list-group list-group-flush' style='margin-left: 20px;'>");
            foreach (var component in _components)
            {
                // Alt bileşenler de stil alıyor
                stringbuilder.Append($"<li class='list-group-item' style='background-color: #f8f9fa; color: #212529; border: 1px solid #ccc; padding: 10px; margin-bottom: 5px;'>");
                stringbuilder.Append(component.Display());
                stringbuilder.Append("</li>");
            }
            stringbuilder.Append("</ul>");

            return stringbuilder.ToString();
        }

        public int TotalCount()
        {
            return _components.Sum(c => c.TotalCount());
        }
    }
}
