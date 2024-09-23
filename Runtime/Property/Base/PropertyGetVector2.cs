using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Serializable]
    public class PropertyGetVector2 : TPropertyGet<PropertyTypeGetVector2, Vector2> {
        public PropertyGetVector2() : base(new GetVector2Instance()) { }

        public PropertyGetVector2(PropertyTypeGetVector2 defaultType) : base(defaultType) { }

        public PropertyGetVector2(Vector2 value) : base(new GetVector2Instance(value)) { }
    }
}