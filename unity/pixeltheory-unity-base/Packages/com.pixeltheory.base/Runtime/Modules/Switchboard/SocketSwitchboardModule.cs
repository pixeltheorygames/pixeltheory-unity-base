using System.Collections.Generic;
using UnityEngine;
using Pixeltheory.Blackboard;


namespace Pixeltheory.Switchboard
{
    [CreateAssetMenu(fileName = "SocketSwitchboardModule", menuName = "Pixeltheory/Blackboard/Modules/SocketSwitchboard")]
    public class SocketSwitchboardModule : PixelBlackboardModule
    {
        #region Fields
        #region Inspector
        #if UNITY_EDITOR
        [SerializeField] private List<PixelMessage> pixelMessages;
        #endif //UNITY_EDITOR
        #endregion //Inspector
        #endregion //Fields
    }
}