using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.VisualScripting;
using Obvious.Soap;
using UnityEngine;
using Event = GameCreator.Runtime.VisualScripting.Event;

namespace SomethingSpecific.Ext.GameCreator.SOAP {

    [Title("Soap Variable Change")]
    [Category("Soap/StringVariable Changed")]
    [Description("Executed when the value of the StringVariable changes")]

    [Image(typeof(IconString), ColorTheme.Type.Green)]

    [Keywords("String", "SOAP", "StringVariable", "Value", "Changed")]

    [Serializable]
    public class EventOnStringVariableChange : Event {
        
        [SerializeField]
        private StringVariable stringVariable;

        protected override void OnAwake(Trigger trigger) {
            base.OnAwake(trigger);
            stringVariable.OnValueChanged += OnChange;
        }

        protected override void OnDisable(Trigger trigger) {
            base.OnDisable(trigger);
            stringVariable.OnValueChanged -= OnChange;
        }

        private void OnChange(string value) {
            _ = this.m_Trigger.Execute(this.Self);
        }
    }
}