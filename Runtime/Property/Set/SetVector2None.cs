using System;
using GameCreator.Runtime.Common;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("None")]
    [Category("None")]
    [Description("No value")]
    [Image(typeof(IconNull), ColorTheme.Type.TextLight)]
    [Serializable]
    public class SetVector2None : PropertyTypeSetVector2 {

        public override void Set(Vector2 value, Args args) { }

        public override void Set(Vector2 value, GameObject gameObject) { }

        public static PropertySetVector2 Create =>
            new PropertySetVector2(
                new SetVector2None()
            );

        public override string String => "(None)";
    }
}
