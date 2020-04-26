using System;
using System.Collections.Generic;

namespace CharacterForge
{
    public class Actor
    {
        readonly private Guid _guid;
        private Name _name;
        private BodyInfo _bodyInfo;
        private LocomotionInfo _locomotionInfo;

        public Actor()
        {
            _guid = Guid.NewGuid();
            _name = new Name();
            _bodyInfo = new BodyInfo();
            _locomotionInfo = new LocomotionInfo();
        }
     
        public string GetName()
        {
            return _name.Casual;
        }

        public void SetName(Name name)
        {
            _name = name;
        }

        public Guid GetGuid()
        {
            return _guid;
        }

        
       
    }

 




}