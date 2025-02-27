using System;
using UnityEngine;


namespace Pixeltheory
{
    [Serializable]
    public struct PixelKeyValuePair<TypeKey, TypeValue>
    {
        #region Fields
        #region Private
        [SerializeField] private TypeKey key;
        [SerializeField] private TypeValue value;
        #endregion //Private
        #endregion //Fields

        #region Properties
        #region Public
        public TypeKey Key => this.key;
        public TypeValue Value => this.value;
        #endregion //Public
        #endregion //Properties

        #region Constructor/Deconstructor
        public PixelKeyValuePair(TypeKey initKey, TypeValue initValue)
        {
            this.key = initKey;
            this.value = initValue;
        }
        
        public void Deconstruct(out TypeKey finalKey, out TypeValue finalValue)
        {
            finalKey = this.key;
            finalValue = this.value;
        }
        #endregion //Constructor/Deconstructor

        #region Methods
        #region Public
        public override string ToString()
        {
            return $"Key = {this.key}, Value = {this.value}";
        }
        #endregion //Public
        #endregion //Methods
    }
}