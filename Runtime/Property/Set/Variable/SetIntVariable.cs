using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Title("Soap Variable")]
    [Category("Soap/IntVariable")]
    [Image(typeof(IconNumber), ColorTheme.Type.Green)]
    [Description("Sets the contents of a IntVariable")]
    [Keywords("Int", "SOAP", "IntVariable")]
    [Serializable]
    public class SetIntVariable : PropertyTypeSetNumber {
        private const string DefaultDisplay = "<IntVariable>";
        
        [SerializeField]
        private IntVariable intVariable;
        
        public override string String => intVariable != null ? intVariable.name : DefaultDisplay;

        public override void Set(double value, Args args) {
            if (intVariable == null) return;
            intVariable.Value = (int)value;
        }
    }
}