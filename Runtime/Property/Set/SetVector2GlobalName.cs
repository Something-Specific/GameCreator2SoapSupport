using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Global Name Variable")]
    [Category("Variables/Global Name Variable")]
    
    [Description("Sets the Vector2 value of a Global Name Variable")]
    [Image(typeof(IconNameVariable), ColorTheme.Type.Purple, typeof(OverlayDot))]

    [Serializable]
    public class SetVector2GlobalName : PropertyTypeSetVector2
    {
        [SerializeField]
        protected FieldSetGlobalName m_Variable = new FieldSetGlobalName(ValueVector2.TYPE_ID);

        public override void Set(Vector2 value, Args args) => this.m_Variable.Set(value, args);
        public override Vector2 Get(Args args) => (Vector2) this.m_Variable.Get(args);

        public static PropertySetVector2 Create => new PropertySetVector2(
            new SetVector2GlobalName()
        );
        
        public override string String => this.m_Variable.ToString();
    }
}