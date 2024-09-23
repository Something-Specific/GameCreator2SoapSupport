using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Extension.GameCreatorSupport {
    [Title("StringVariable")]
    [Category("Soap/StringVariable")]
    [Image(typeof(IconString), ColorTheme.Type.Red)]
    [Description("A SOAP StringVariable")]
    [Keywords("String", "SOAP", "StringVariable")]
    [Serializable]
    public class GetStringVariable : PropertyTypeGetString {
        private const string DefaultDisplay = "<string variable>";

        [SerializeField]
        private StringVariable stringVariable;

        public override string Get(GameObject target) {
            return GetStringVariableValue();
        }

        public override string Get(Args args) {
            return GetStringVariableValue();
        }

        public override string String => GetStringVariableValue();

        private string GetStringVariableValue() {
            return stringVariable ? stringVariable.Value : DefaultDisplay;
        }
    }
}