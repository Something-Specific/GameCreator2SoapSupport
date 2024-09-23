using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Serializable]
    public class PropertySetVector2 : TPropertySet<PropertyTypeSetVector2, Vector2> {
        
        public PropertySetVector2() : base(new SetVector2None()) { }

        public PropertySetVector2(PropertyTypeSetVector2 defaultType) : base(defaultType) { }

    }
}