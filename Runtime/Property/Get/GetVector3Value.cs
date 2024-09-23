using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Vector3")]
    [Category("Value")]
    [Image(typeof(IconVector3), ColorTheme.Type.Green)]
    [Description("A Vector3 value.")]
    [Keywords("Vector3", "SOAP", "Vector3Variable")]
    [Serializable]
    public class GetVector3Value : PropertyTypeGetVector3 {

        [SerializeField]
        protected Vector3 instance;

        public override Vector3 Get(Args args) => this.instance;
        public override Vector3 Get(GameObject gameObject) => this.instance;

        public GetVector3Value() : base() {
            instance = Vector3.zero;
        }

        public GetVector3Value(Vector3 vector3) : this() {
            this.instance = vector3;
        }

        public static PropertyGetVector3 Create =>
            new PropertyGetVector3(
                new GetVector3Value()
            );

        public override string String => this.instance.ToString();

        public override Vector3 EditorValue => this.instance;
    }
}