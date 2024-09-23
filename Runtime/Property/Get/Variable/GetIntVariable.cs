using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
   
	[Title("IntVariable")]
    [Category("Soap/IntVariable")]
    [Image(typeof(IconString), ColorTheme.Type.Red)]
    [Description("A SOAP IntVariable")]
    [Keywords("Int", "SOAP", "IntVariable")]
    [Serializable]
    public class GetIntVariable : PropertyTypeGetDecimal {
        
        [SerializeField]
        private int defaultValue = 0;

        [SerializeField]
        private IntVariable intVariable;

        public override double Get(GameObject target) {
            return GetIntVariableValue();
        }

        public override double Get(Args args) {
            return GetIntVariableValue();
        }

        public override string String => GetIntVariableValue().ToString();

        private int GetIntVariableValue() {
            return intVariable != null ? intVariable.Value : defaultValue;
        }
    }
}