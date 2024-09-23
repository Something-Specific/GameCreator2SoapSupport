using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
   
	[Title("Vector3Variable")]
    [Category("Soap/Vector3Variable")]
    [Image(typeof(IconString), ColorTheme.Type.Red)]
    [Description("A SOAP Vector3Variable")]
    [Keywords("Vector3", "SOAP", "Vector3Variable")]
    [Serializable]
    public class GetVector3Variable : PropertyTypeGetDirection {
        
        [SerializeField]
        private Vector3 defaultValue = Vector3.zero;

        [SerializeField]
        private Vector3Variable vector3Variable;

        public override Vector3 Get(GameObject target) {
            return GetVector3GetValue();
        }

        public override Vector3 Get(Args args) {
            return GetVector3GetValue();
        }

        public override string String => GetVector3GetValue().ToString();

        private Vector3 GetVector3GetValue() {
            return vector3Variable != null ? vector3Variable.Value : defaultValue;
        }
    }
}