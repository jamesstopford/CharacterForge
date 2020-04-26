using RandomNameGeneratorLibrary;

namespace CharacterForge
{
    public class Name
    {
        private string _firstName;
        private string _lastName;

        public string GetCasual()
        {
            return _firstName;
        }
      
        public string GetForm()
        {
            return _firstName + " " + _lastName;
        }
             
        public void Randomize()
        {
            var personGenerator = new PersonNameGenerator();
            _firstName = personGenerator.GenerateRandomFirstName();
            _lastName = personGenerator.GenerateRandomLastName();
        }

        public void SetName (string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

    }





}