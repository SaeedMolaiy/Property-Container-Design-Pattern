using System.Collections.Generic;

namespace PropertyContainer
{
    //  A Property Container is a class whose properties can be
    //  customized at runtime without having to edit your class definition.
    //  The PropertyContainer base class provides methods to add/remove/retrieve properties stored in the class.
    //  Basically, it acts a lot like a HashMap:
    public abstract class PropertyContainer
    {
        private readonly Dictionary<object, object> _propertiesDictionary = new Dictionary<object, object>();

        public void AddProperty(object key, object value)
        {
            _propertiesDictionary.Add(key, value);
        }

        public void RemoveProperty(object key)
        {
            _propertiesDictionary.Remove(key);
        }

        public object GetProperty(object key)
        {
            return _propertiesDictionary[key];
        }
    }
}
