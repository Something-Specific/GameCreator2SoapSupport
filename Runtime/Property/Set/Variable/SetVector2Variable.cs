using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Soap Variable")]
    [Category("Soap/Variable")]
    [Image(typeof(IconVector2), ColorTheme.Type.Green)]
    [Description("Sets the contents of a Vector2Variable")]
    [Keywords("Vector2", "SOAP", "Vector2Variable")]
    [Serializable]
    public class SetVector2Variable : PropertyTypeSetVector2 {

        [SerializeField]
        private Vector2Variable vector2Variable;

        public override string String => CreateString();
        
        public override void Set(Vector2 value, Args args) {
            if (vector2Variable != null) {
                vector2Variable.Value = value;
            }
        }

        private string CreateString() {
            if (vector2Variable == null)
                return "None";

            return vector2Variable.name;
        }
    }
}