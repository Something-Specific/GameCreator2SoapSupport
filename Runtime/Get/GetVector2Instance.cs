using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Vector2 Value")]
    [Category("Vector2/Value")]
    [Image(typeof(IconString), ColorTheme.Type.Red)]
    [Description("A Vector2 value. This supports the SOAP Vector2Variable type.")]
    [Keywords("Vector2", "SOAP", "Vector2Variable")]
    [Serializable]
    public class GetVector2Instance : PropertyTypeGetVector2 {

        [SerializeField]
        protected Vector2 instance;

        public override Vector2 Get(Args args) => this.instance;
        public override Vector2 Get(GameObject gameObject) => this.instance;

        public GetVector2Instance() : base() { }

        public GetVector2Instance(Vector2 vector2) : this() {
            this.instance = vector2;
        }

        public static PropertyGetVector2 Create(Vector2 value) =>
            new PropertyGetVector2(
                new GetVector2Instance(value)
            );

        public override string String => this.instance.ToString();

        public override Vector2 EditorValue => this.instance;
    }
}