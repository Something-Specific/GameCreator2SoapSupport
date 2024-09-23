using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Title("StringVariable")]
    [Category("Soap/StringVariable")]
    [Image(typeof(IconString), ColorTheme.Type.Red)]
    [Description("Sets the contents of a StringVariable")]
    [Keywords("String", "SOAP", "StringVariable")]
    [Serializable]
    public class SetStringVariable : PropertyTypeSetString {
        private const string DefaultDisplay = "StringVariable";

        [SerializeField]
        private StringVariable stringVariable;
        

        public override string String => stringVariable ? stringVariable.name : DefaultDisplay;

        public override void Set(string value, Args args) {
            SetStringVariableValue(value);
        }

        private void SetStringVariableValue(string value) {
            if (stringVariable) {
                stringVariable.Value = value;
            }
        }
    }
}