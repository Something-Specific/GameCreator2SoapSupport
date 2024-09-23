using System;
using System.Threading.Tasks;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.VisualScripting;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    
    [Version(0, 0, 1)]

    [Title("Set Vector3")]
    [Description("Sets the value of a Vector3")]

    [Category("Soap/Vectors/Set Vector3 value")]

    [Parameter("setTarget", "The target vector to change")]
    [Parameter("fromTarget", "The vector value to assign")]

    [Keywords("Soap", "Vector3", "Vector3Variable")]
    [Image(typeof(IconVector3), ColorTheme.Type.Green)]

    [Serializable]
    public class InstructionSetVector3 : Instruction {

        [SerializeField]
        private PropertySetVector3 setTarget = SetVector3None.Create;

        [SerializeField]
        private PropertyGetVector3 fromTarget = GetVector3Value.Create;
        
        public override string Title => $"Set {setTarget} to {fromTarget}";


        protected override Task Run(Args args) {
            setTarget.Set(fromTarget.Get(args), args);
            
            return DefaultResult;
        }
    }
}