using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
   
	[Title("Vector2 Variable")]
    [Category("Soap/Vector2 Variable")]
    [Image(typeof(IconString), ColorTheme.Type.Red)]
    [Description("A SOAP Vector2Variable instance")]
    [Keywords("Vector2", "SOAP", "Vector2Variable")]
    [Serializable]
    public class GetVector2Variable : PropertyTypeGetVector2 {
        [SerializeField]
        private Vector2Variable vector2Variable;

        public override Vector2 Get(GameObject target) {
            return GetVector2Value();
        }

        public override Vector2 Get(Args args) {
            return GetVector2Value();
        }

        public override string String => GetVector2Value().ToString();

        private Vector2 GetVector2Value() {
            return vector2Variable != null ? vector2Variable.Value : Vector2.zero;
        }
    }
}