using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Soap Variable")]
    [Category("Soap/Variable")]
    [Image(typeof(IconVector2), ColorTheme.Type.Green)]
    [Description("Sets the contents of a Vector3Variable")]
    [Keywords("Vector2", "SOAP", "Vector3Variable")]
    [Serializable]
    public class SetVector3Variable : PropertyTypeSetVector3 {

        [SerializeField]
        private Vector3Variable vector3Variable;

        public override string String => CreateString();
        
        public override void Set(Vector3 value, Args args) {
            if (vector3Variable != null) {
                vector3Variable.Value = value;
            }
        }

        private string CreateString() {
            if (vector3Variable == null)
                return "None";

            return vector3Variable.name;
        }
    }
}