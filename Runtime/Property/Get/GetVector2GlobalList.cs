using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Global List Variable")]
    [Category("Variables/Global List Variable")]
    
    [Image(typeof(IconListVariable), ColorTheme.Type.Teal, typeof(OverlayDot))]
    [Description("Returns the Vector2 value of a Global List Variable")]

    [Serializable]
    public class GetVector2GlobalList : PropertyTypeGetVector2
    {
        [SerializeField]
        protected FieldGetGlobalList m_Variable = new FieldGetGlobalList(ValueVector2.TYPE_ID);

        public override Vector2 Get(Args args) => this.m_Variable.Get<Vector2>(args);

        public override string String => this.m_Variable.ToString();
    }
}