namespace CharacterForge
{
    public class Actor
    {
        private int _age;
        private   string _name {  get;  set; }

        public Actor()
        {
            GenerateName("test");
        }

        public string GetName()
        {
            return _name;
        }

        private void GenerateName(object actorNamingConvention)
        {
            this._name = "Joe";
        }

    }
}