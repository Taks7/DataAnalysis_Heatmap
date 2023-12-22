using Gamekit3D.Message;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA;

namespace Gamekit3D
{
    [RequireComponent(typeof(CharacterController))]
    [RequireComponent(typeof(Animator))]

    public class PlayerDataClass : MonoBehaviour, IMessageReceiver
    {
        public void OnReceiveMessage(MessageType type, object sender, object msg)
        {
            throw new System.NotImplementedException();
        }

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

