using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Title("Soap Variable")]
    [Category("Soap/Variable")]
    [Image(typeof(IconNumber), ColorTheme.Type.Green)]
    [Description("Sets the contents of a FloatVariable to a Number value")]
    [Keywords("Float", "SOAP", "FloatVariable")]
    [Serializable]
    public class SetFloatVariable : PropertyTypeSetNumber {
        private const string DefaultDisplay = "<FloatVariable>";
        
        [SerializeField]
        private FloatVariable floatVariable;
        
        public override string String => floatVariable != null ? floatVariable.name : DefaultDisplay;

        public override void Set(double value, Args args) {
            if (floatVariable == null) return;
            floatVariable.Value = (float)value; // losing precision here going double > float, but GC2 uses double for numbers.
            // Consider adding a double variable type to SOAP?
        }
    }
}