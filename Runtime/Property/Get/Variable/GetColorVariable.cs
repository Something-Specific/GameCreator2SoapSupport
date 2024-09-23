using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Soap Variable")]
    [Category("Soap/Variable")]
    [Image(typeof(IconColor), ColorTheme.Type.Green)]
    [Description("A SOAP ColorVariable")]
    [Keywords("Color", "SOAP", "ColorVariable")]
    [Serializable]
    public class GetColorVariable : PropertyTypeGetColor {
        
        [SerializeField]
        private Color defaultColor = Color.black;

        [SerializeField]
        private ColorVariable boolVariable;

        public override Color Get(GameObject target) {
            return GetColorVariableValue();
        }

        public override Color Get(Args args) {
            return GetColorVariableValue();
        }

        public override string String => GetColorVariableValue().ToString();

        private Color GetColorVariableValue() {
            return boolVariable != null ? boolVariable.Value : defaultColor;
        }
    }
}