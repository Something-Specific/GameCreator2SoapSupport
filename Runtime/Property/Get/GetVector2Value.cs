using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Vector2")]
    [Category("Value")]
    [Image(typeof(IconVector2), ColorTheme.Type.Green)]
    [Description("A Vector2 value.")]
    [Keywords("Vector2", "SOAP", "Vector2Variable")]
    [Serializable]
    public class GetVector2Value : PropertyTypeGetVector2 {

        [SerializeField]
        protected Vector2 value;

        public override Vector2 Get(Args args) => this.value;
        public override Vector2 Get(GameObject gameObject) => this.value;

        public GetVector2Value() : base() { }

        public GetVector2Value(Vector2 vector2) : this() {
            this.value = vector2;
        }

        public static PropertyGetVector2 Create =>
            new PropertyGetVector2(
                new GetVector2Value()
            );

        public override string String => this.value.ToString();

        public override Vector2 EditorValue => this.value;
    }
}