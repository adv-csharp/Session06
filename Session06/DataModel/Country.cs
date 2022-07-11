namespace Session06.DataModel
{
    //POCO
    public class Country
    {
        //[Key] // <--- Attribute/Annotation/Decorator - Meta Programming : Reflection?
        //public int PK { get; set; }

        public int Id { get; set; }
        public string Name { get; set; }
    }
}
