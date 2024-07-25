namespace ControlsDemo
{
    public class CountryDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EuropeTemplate { get; set; }
        public DataTemplate AfriqueTemplate { get; set; }
        public DataTemplate AsieTemplate { get; set; }


        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Place current = (Place)item;
            switch (current.Continent)
            {
                case "Afrique":
                    return AfriqueTemplate;
                case "Europe":
                    return EuropeTemplate;
                case "Asie":
                    return AsieTemplate;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
