using System;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.Variables;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    [Image(typeof(IconVector2), ColorTheme.Type.Green)]
    [Title("Soap Vector2 Variable")]
    [Category("Soap/Vector2")]
    [Serializable]
    public class ValueVector2Variable : TValue {
        public static readonly IdString TYPE_ID = new("vector2");

        // EXPOSED MEMBERS: -----------------------------------------------------------------------

        [SerializeField]
        private Vector2 m_Value = Vector2.zero;

        // PROPERTIES: ----------------------------------------------------------------------------

        public override IdString TypeID => TYPE_ID;
        public override Type Type => typeof(Vector2);

        public override bool CanSave => true;

        public override TValue Copy =>
            new ValueVector2Variable {
                m_Value = m_Value
            };

        // CONSTRUCTORS: --------------------------------------------------------------------------

        public ValueVector2Variable() : base() { }

        public ValueVector2Variable(Vector2 value) : this() {
            m_Value = value;
        }

        public ValueVector2Variable(Vector3 value) : this() {
            m_Value = value;
        }

        // OVERRIDE METHODS: ----------------------------------------------------------------------

        protected override object Get() {
            return m_Value;
        }

        protected override void Set(object value) {
            m_Value = value is Vector2 cast ? cast : Vector2.zero;
        }

        public override string ToString() {
            return m_Value.ToString();
        }

        // REGISTRATION METHODS: ------------------------------------------------------------------

        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
        private static void RuntimeInit() {
            RegisterValueType(
                TYPE_ID,
                new TypeData(typeof(ValueVector2Variable), CreateValue),
                typeof(Vector2)
            );
        }

#if UNITY_EDITOR

        [UnityEditor.InitializeOnLoadMethod]
        private static void EditorInit() {
            RegisterValueType(
                TYPE_ID,
                new TypeData(typeof(ValueVector2Variable), CreateValue),
                typeof(Vector2)
            );
        }

#endif

        private static ValueVector2Variable CreateValue(object value) {
            return new ValueVector2Variable(value is Vector2 castVector2 ? castVector2 : default);
        }
    }
}