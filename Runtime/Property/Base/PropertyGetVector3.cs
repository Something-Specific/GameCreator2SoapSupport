using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Serializable]
    public class PropertyGetVector3 : TPropertyGet<PropertyTypeGetVector3, Vector3> {
        public PropertyGetVector3() : base(new GetVector3Instance()) { }

        public PropertyGetVector3(PropertyTypeGetVector3 defaultType) : base(defaultType) { }

        public PropertyGetVector3(Vector3 value) : base(new GetVector3Instance(value)) { }
    }
}