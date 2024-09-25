using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Local Name Variable")]
    [Category("Variables/Local Name Variable")]

    [Image(typeof(IconNameVariable), ColorTheme.Type.Purple)]
    [Description("Returns the Vector2 value of a Local Name Variable")]
    
    [Serializable]
    public class GetVector2LocalName : PropertyTypeGetVector2
    {
        [SerializeField]
        protected FieldGetLocalName m_Variable = new FieldGetLocalName(ValueVector2.TYPE_ID);

        public override Vector2 Get(Args args) => this.m_Variable.Get<Vector2>(args);

        public override string String => this.m_Variable.ToString();
    }
}