namespace CharacterForge
{
    public class Name
    {
        private string _casual;
        private string _formal;

        public string Casual { get => _casual; set => _casual = value; }
        public string Formal { get => _formal; set => _formal = value; }

        public virtual string GetName ()
        {
            return Casual;
        }
    }





}