﻿using System;
using GameCreator.Runtime.Common;
using Obvious.Soap;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Soap Variable")]
    [Category("Soap/Variable")]
    [Image(typeof(IconToggleOff), ColorTheme.Type.Green)]
    [Description("A SOAP BoolVariable")]
    [Keywords("Bool", "SOAP", "BoolVariable")]
    [Serializable]
    public class GetBoolVariable : PropertyTypeGetBool {

        [SerializeField]
        private BoolVariable boolVariable;

        public override bool Get(GameObject target) {
            return GetBoolVariableValue();
        }

        public override bool Get(Args args) {
            return GetBoolVariableValue();
        }

        public override string String => GetBoolVariableValue().ToString();

        private bool GetBoolVariableValue() {
            return boolVariable != null && boolVariable.Value;
        }
    }
}