using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("FloatVariable")]
    [Category("Soap/FloatVariable")]
    [Image(typeof(IconNumber), ColorTheme.Type.Green)]
    [Description("A SOAP FloatVariable")]
    [Keywords("Float", "SOAP", "FloatVariable")]
    [Serializable]
    public class GetFloatVariable : PropertyTypeGetDecimal {
        
        [SerializeField]
        private FloatVariable floatVariable;

        public override double Get(GameObject target) {
            return GetIntVariableValue();
        }

        public override double Get(Args args) {
            return GetIntVariableValue();
        }

        public override string String => GetIntVariableValue().ToString();

        private float GetIntVariableValue() {
            return floatVariable != null ? floatVariable.Value : 0;
        }
    }
}