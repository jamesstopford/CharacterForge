using System;
using System.Collections.Generic;

namespace CharacterForge
{
    public class Actor
    {
        private int _age;
        readonly private Guid _guid;
        private Name _name;

        public Actor()
        {
            _guid = Guid.NewGuid();
            _name = new Name();
        }
     
        public string GetName()
        {
            return _name.GetName();
        }

        public Guid GetGuid()
        {
            return _guid;
        }
       
    }





}