using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Local List Variable")]
    [Category("Variables/Local List Variable")]
    
    [Image(typeof(IconListVariable), ColorTheme.Type.Teal)]
    [Description("Returns the Vector2 value of a Local List Variable")]

    [Serializable]
    public class GetVector2LocalList : PropertyTypeGetVector2
    {
        [SerializeField]
        protected FieldGetLocalList m_Variable = new FieldGetLocalList(ValueVector2.TYPE_ID);

        public override Vector2 Get(Args args) => this.m_Variable.Get<Vector2>(args);

        public override string String => this.m_Variable.ToString();
    }
}