using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Title("Soap Variable")]
    [Category("Soap/Variable")]
    [Image(typeof(IconColor), ColorTheme.Type.Green)]
    [Description("Sets the contents of a ColorVariable")]
    [Keywords("Color", "SOAP", "ColorVariable")]
    [Serializable]
    public class SetColorVariable : PropertyTypeSetColor {
        private const string DefaultDisplay = "<ColorVariable>";
        
        [SerializeField]
        private ColorVariable colorVariable;
        
        public override string String => colorVariable != null ? colorVariable.name : DefaultDisplay;

        public override void Set(Color value, Args args) {
            if (colorVariable == null) return;
            colorVariable.Value = value;
        }
    }
}