using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Global List Variable")]
    [Category("Variables/Global List Variable")]
    
    [Description("Sets the Vector2 value of a Global List Variable")]
    [Image(typeof(IconListVariable), ColorTheme.Type.Teal, typeof(OverlayDot))]

    [Serializable]
    public class SetVector2GlobalList : PropertyTypeSetVector2
    {
        [SerializeField]
        protected FieldSetGlobalList m_Variable = new FieldSetGlobalList(ValueVector2.TYPE_ID);

        public override void Set(Vector2 value, Args args) => this.m_Variable.Set(value, args);
        public override Vector2 Get(Args args) => (Vector2) this.m_Variable.Get(args);

        public static PropertySetVector2 Create => new PropertySetVector2(
            new SetVector2GlobalList()
        );
        
        public override string String => this.m_Variable.ToString();
    }
}