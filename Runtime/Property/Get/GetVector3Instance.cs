using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Vector3 Value")]
    [Category("Vector3/Value")]
    [Image(typeof(IconString), ColorTheme.Type.Red)]
    [Description("A Vector3 value. This supports the SOAP Vector3Variable type.")]
    [Keywords("Vector3", "SOAP", "Vector3Variable")]
    [Serializable]
    public class GetVector3Instance : PropertyTypeGetVector3 {

        [SerializeField]
        protected Vector3 instance;

        public override Vector3 Get(Args args) => this.instance;
        public override Vector3 Get(GameObject gameObject) => this.instance;

        public GetVector3Instance() : base() { }

        public GetVector3Instance(Vector3 vector3) : this() {
            this.instance = vector3;
        }

        public static PropertyGetVector3 Create(Vector3 value) =>
            new PropertyGetVector3(
                new GetVector3Instance(value)
            );

        public override string String => this.instance.ToString();

        public override Vector3 EditorValue => this.instance;
    }
}