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
    [Image(typeof(IconDiskOutline), ColorTheme.Type.Red, typeof(OverlayCross))]

    [Serializable]
    public class InstructionSetVector3 : Instruction {

        [SerializeField]
        private Vector3 setTarget;

        [SerializeField]
        private PropertyGetVector3 fromTarget = new PropertyGetVector3();
        
        public override string Title => $"Set {setTarget} to {fromTarget}";


        protected override Task Run(Args args) {
            throw new NotImplementedException();
        }
    }
}