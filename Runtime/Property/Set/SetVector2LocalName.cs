using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Local Name Variable")]
    [Category("Variables/Local Name Variable")]
    
    [Description("Sets the Vector2 value of a Local Name Variable")]
    [Image(typeof(IconNameVariable), ColorTheme.Type.Purple)]

    [Serializable]
    public class SetVector2LocalName : PropertyTypeSetVector2
    {
        [SerializeField]
        protected FieldSetLocalName m_Variable = new FieldSetLocalName(ValueVector2.TYPE_ID);

        public override void Set(Vector2 value, Args args) => this.m_Variable.Set(value, args);
        public override Vector2 Get(Args args) => (Vector2) this.m_Variable.Get(args);

        public static PropertySetVector2 Create => new PropertySetVector2(
            new SetVector2LocalName()
        );
        
        public override string String => this.m_Variable.ToString();
    }
}