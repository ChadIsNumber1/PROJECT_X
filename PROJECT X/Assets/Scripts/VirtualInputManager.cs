using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


namespace projectX
{

    public class VirtualInputManager : MonoBehaviour
    {
        [Header("Player 1 Inputs")]
        [SerializeField] private bool WalkFwdP1;
        [SerializeField] private bool WalkBackP1;
        [SerializeField] private bool LightAttkP1;
        [SerializeField] private bool HeavyAttkP1;
        [Header("Player 2 Inputs")]
        [SerializeField] private bool WalkFwdP2;
        [SerializeField] private bool WalkBackP2;
        [SerializeField] private bool LightAttkP2;
        [SerializeField] private bool HeavyAttkP2;

        static string[] keyMaps = new string[8]
        {
        "WalkFwdP1",
        "WalkBackP1",
        "LightAttkP1",
        "HeavyAttkP1",

        "WalkFwdP2",
        "WalkBackP2",
        "LightAttkP2",
        "HeavyAttkP2",
        };

        static KeyCode[] defaults = new KeyCode[8]
        {
        KeyCode.A, //P1Fwd
        KeyCode.D, //P1Back
        KeyCode.S, //P1Light
        KeyCode.C, //P1Heavy

        KeyCode.L, //P2Fwd
        KeyCode.J, //P2Back
        KeyCode.K, //P2Light
        KeyCode.N, //P2Heavy
        };

        static Dictionary<string, KeyCode> keyMapping;

        public static VirtualInputManager Instance { get; private set; }

        private void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
                InitKeyMapping();
            }
        }

        private static void InitKeyMapping()
        {
            keyMapping = new Dictionary<string, KeyCode>();
            for (int i = 0; i < keyMaps.Length; ++i)
            {
                keyMapping.Add(keyMaps[i], defaults[i]);
            }
        }

        public void SetKeyMap(string keyMap, KeyCode key)
        {
            if (!keyMapping.ContainsKey(keyMap))
                throw new ArgumentException("Invalid KeyMap in SetKeyMap: " + keyMap);
            keyMapping[keyMap] = key;
        }

        public bool GetKeyDown(string keyMap)
        {
            return Input.GetKeyDown(keyMapping[keyMap]);
        }

        public bool GetKey(string keyMap)
        {
            return Input.GetKey(keyMapping[keyMap]);
        }

        //Getters and Setters for P1
        public bool GetWalkFwdP1()
        {
            return WalkFwdP1;
        }
        public bool GetWalkBackP1() 
        {  
            return WalkBackP1; 
        }
        public bool GetLightNeutralP1()
        {
            return LightAttkP1 && !WalkFwdP1;
        }
        public bool GetLightFwdP1()
        {
            return LightAttkP1 && WalkFwdP1;
        }

        public void SetWalkFwdP1(bool newState)
        {
            WalkFwdP1 = newState;
        }

        public void SetWalkBackP1(bool newState)
        {
            WalkBackP1 = newState;
        }

        public void SetLightAttkP1(bool newState)
        {
            LightAttkP1 = newState;
        }
        public void SetHeavyAttkP1(bool newState)
        {
            HeavyAttkP1 = newState;
        }
        //Getters and setter for P2
        public bool GetWalkFwdP2()
        {
            return WalkFwdP2;
        }
        public bool GetWalkBackP2()
        {
            return WalkBackP2;
        }
        public bool GetLightNeutralP2()
        {
            return LightAttkP2 && !WalkFwdP2;
        }
        public bool GetLightFwdP2()
        {
            return LightAttkP2 && WalkFwdP2;
        }
        public void SetWalkFwdP2(bool newState)
        {
            WalkFwdP2 = newState;
        }
        public void SetWalkBackP2(bool newState)
        {
            WalkBackP2 = newState;
        }
        public void SetLightAttkP2(bool newState)
        {
            LightAttkP2 = newState;
        }
        public void SetHeavyAttkP2(bool newState)
        {
            HeavyAttkP2 = newState;
        }
    }
}
