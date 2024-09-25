using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Global Name Variable")]
    [Category("Variables/Global Name Variable")]
    
    [Image(typeof(IconNameVariable), ColorTheme.Type.Purple, typeof(OverlayDot))]
    [Description("Returns the Vector2 value of a Global Name Variable")]

    [Serializable]
    public class GetVector2GlobalName : PropertyTypeGetVector2
    {
        [SerializeField]
        protected FieldGetGlobalName m_Variable = new FieldGetGlobalName(ValueVector2.TYPE_ID);

        public override Vector2 Get(Args args) => this.m_Variable.Get<Vector2>(args);

        public override string String => this.m_Variable.ToString();
    }
}