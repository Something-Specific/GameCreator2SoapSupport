using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Title("Soap Variable")]
    [Category("Soap/Quaternion Variable")]
    [Image(typeof(IconRotation), ColorTheme.Type.Green)]
    [Description("A SOAP QuaternionVariable")]
    [Serializable]
    public class GetQuaternionVariable : PropertyTypeGetRotation {
        [SerializeField]
        private QuaternionVariable quaternionVariable;

        public override Quaternion Get(Args args) {
            return quaternionVariable == null ? Quaternion.identity : quaternionVariable.Value;
        }
        
        public static PropertyGetRotation Create() {
            return new PropertyGetRotation(
                new GetQuaternionVariable()
            );
        }

        public override string String => quaternionVariable == null ? "None" : quaternionVariable.Value.ToString();
    }
}