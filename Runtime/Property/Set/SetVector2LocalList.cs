using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP
{
    [Title("Local List Variable")]
    [Category("Variables/Local List Variable")]
    
    [Description("Sets the Vector2 value of a Local List Variable")]
    [Image(typeof(IconListVariable), ColorTheme.Type.Teal)]

    [Serializable]
    public class SetVector2LocalList : PropertyTypeSetVector2
    {
        [SerializeField]
        protected FieldSetLocalList m_Variable = new FieldSetLocalList(ValueVector2.TYPE_ID);

        public override void Set(Vector2 value, Args args) => this.m_Variable.Set(value, args);
        public override Vector2 Get(Args args) => (Vector2) this.m_Variable.Get(args);

        public static PropertySetVector2 Create => new PropertySetVector2(
            new SetVector2LocalList()
        );
        
        public override string String => this.m_Variable.ToString();
    }
}