using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.VisualScripting;
using Obvious.Soap;
using UnityEngine;
using Event = GameCreator.Runtime.VisualScripting.Event;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Soap Variable Change")]
    [Category("Soap/FloatVariable Changed")]
    [Description("Executed when the value of the FloatVariable changes")]

    [Image(typeof(IconNumber), ColorTheme.Type.Green)]

    [Keywords("Float", "SOAP", "FloatVariable", "Value", "Changed")]

    [Serializable]
    public class EventOnFloatVariableChange : Event {
        
        [SerializeField]
        private FloatVariable floatVariable;

        protected override void OnAwake(Trigger trigger) {
            base.OnAwake(trigger);
            floatVariable.OnValueChanged += OnChange;
        }

        protected override void OnDisable(Trigger trigger) {
            base.OnDisable(trigger);
            floatVariable.OnValueChanged -= OnChange;
        }

        private void OnChange(float value) {
            _ = this.m_Trigger.Execute(this.Self);
        }
    }
}