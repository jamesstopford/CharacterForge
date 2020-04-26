namespace CharacterForge
{
    public class HumanName :Name
    {
        string FirstName;
        string FamilyName;
        string NickName;

        public override string GetName()
        { 
            return FirstName + " " + FamilyName; 
        }
            
       
        

    }





}