using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Title("Soap Variable")]
    [Category("Soap/Variable")]
    [Image(typeof(IconToggleOff), ColorTheme.Type.Green)]
    [Description("Sets the contents of a BoolVariable")]
    [Keywords("Bool", "SOAP", "BoolVariable")]
    [Serializable]
    public class SetBoolVariable : PropertyTypeSetBool {
        private const string DefaultDisplay = "<BoolVariable>";
        
        [SerializeField]
        private BoolVariable boolVariable;
        
        public override string String => boolVariable != null ? boolVariable.name : DefaultDisplay;

        public override void Set(bool value, Args args) {
            if (boolVariable == null) return;
            boolVariable.Value = value;
        }
    }
}