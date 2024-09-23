﻿using System;
using System.Threading.Tasks;
using GameCreator.Runtime.Common;
using GameCreator.Runtime.VisualScripting;
using UnityEngine;

namespace SomethingSpecific.Ext.GameCreator.SOAP {
    
    [Version(0, 0, 1)]

    [Title("Set Vector2")]
    [Description("Sets the value of a Vector2")]

    [Category("Soap/Vectors/Set Vector2 value")]

    [Parameter("setTarget", "The target vector to change")]
    [Parameter("fromTarget", "The vector value to assign")]

    [Keywords("Soap", "Vector2", "Vector2Variable")]
    [Image(typeof(IconDiskOutline), ColorTheme.Type.Red, typeof(OverlayCross))]

    [Serializable]
    public class InstructionSetVector2 : Instruction {

        [SerializeField]
        private Vector2 setTarget;

        [SerializeField]
        private PropertyGetVector2 fromTarget = new PropertyGetVector2();
        
        public override string Title => $"Set {setTarget} to {fromTarget}";


        protected override Task Run(Args args) {
            throw new NotImplementedException();
        }
    }
}