using BepInEx;
using System;
using UnityEngine;
using TMPro;

namespace Cristalcomputer
{
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public GameObject sourceObject;
        public GameObject targetObject;
        public GameObject stand;
        public GameObject fistbump;
        public GameObject highfive;
        public GameObject cristal;

        void Start()
        {
            GorillaTagger.OnPlayerSpawned(Initialized);
        }

        void Initialized()
        {
            GameObject cristal = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToCave/C_Crystal_Chunk");
            if (cristal != null)
            {
                Material renderer = cristal.GetComponent<Renderer>().material;

                GameObject computer = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/GorillaComputerObject/ComputerUI/monitor");
                if (computer != null)
                    computer.GetComponent<Renderer>().material = renderer;

                GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
                if (plane != null)
                {
                    plane.GetComponent<Renderer>().material = renderer;
                    plane.transform.position = new Vector3(-65.4705f, 11.9719f, -80.004f);
                    plane.transform.rotation = Quaternion.Euler(275.1958f, 20.35f, -0.0005f);
                    plane.transform.localScale = new Vector3(0.07f, 0.1f, 0.04f);
                }

                GameObject plane2 = GameObject.CreatePrimitive(PrimitiveType.Plane);
                if (plane2 != null)
                {
                    plane2.GetComponent<Renderer>().material = renderer;
                    plane2.transform.position = new Vector3(-66.65f, 12.85f, -80.3f);
                    plane2.transform.rotation = Quaternion.Euler(330.056f, 182.7964f, 180.1f);
                    plane2.transform.localScale = new Vector3(0.09f, 0.1f, 0.042f);
                }

                GameObject plane3 = GameObject.CreatePrimitive(PrimitiveType.Plane);
                if (plane3 != null)
                {
                    plane3.GetComponent<Renderer>().material = renderer;
                    plane3.transform.position = new Vector3(-67.96f, 11.95f, -80.7f);
                    plane3.transform.rotation = Quaternion.Euler(276.3606f, 332.0349f, 0.1003f);
                    plane3.transform.localScale = new Vector3(0.106f, 0.1f, 0.106f);
                }

                GameObject plane4 = GameObject.CreatePrimitive(PrimitiveType.Plane);
                if (plane4 != null)
                {
                    plane4.GetComponent<Renderer>().material = renderer;
                    plane4.transform.position = new Vector3(-65.44f, 12.33f, -84.6f);
                    plane4.transform.rotation = Quaternion.Euler(0f, 48.998f, 90f);
                    plane4.transform.localScale = new Vector3(0.07f, 0.1f, 0.16f);
                }

                GameObject keyboard1 = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/GorillaComputerObject/ComputerUI/keyboard (1)");
                if (keyboard1 != null)
                    keyboard1.GetComponent<Renderer>().material = renderer;

                Transform keyboard = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/TreeRoomInteractables/GorillaComputerObject/ComputerUI/keyboard (1)/Buttons").transform;
                if (keyboard != null)
                {
                    MeshRenderer[] keys = keyboard.GetComponentsInChildren<MeshRenderer>();
                    foreach (MeshRenderer renderer1 in keys)
                    {
                        if (renderer1 != null)
                        {
                            renderer1.material = renderer;
                            renderer1.GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
                        }
                    }
                }

                GameObject screentext1 = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/FunctionSelect");
                if (screentext1 != null)
                    screentext1.GetComponent<TextMeshPro>().color = new Color(1, 0, 1, 1);

                GameObject screentext2 = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/Data");
                if (screentext2 != null)
                    screentext2.GetComponent<TextMeshPro>().color = new Color(1, 0, 1, 1);

                GameObject coc = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/CodeOfConduct");
                if (coc != null)
                    coc.transform.position = new Vector3(-67.93f, 11.9661f, -80.6928f);

                GameObject coctext = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom/COC Text");
                if (coctext != null)
                    coctext.transform.position = new Vector3(-68.29f, 11.4147f, -80.9588f);

                Transform treeroom = GameObject.Find("Environment Objects/LocalObjects_Prefab/TreeRoom").transform;
                if (treeroom != null)
                {
                    TextMeshPro[] key = treeroom.GetComponentsInChildren<TextMeshPro>();
                    foreach (TextMeshPro renderer2 in key)
                    {
                        if (renderer2 != null)
                            renderer2.color = new Color(1, 0, 1, 1);
                    }
                }
            }
        }

        void Update()
        {
            GameObject cristal = GameObject.Find("Environment Objects/LocalObjects_Prefab/ForestToCave/C_Crystal_Chunk");
            if (cristal != null)
            {
                Material renderer = cristal.GetComponent<Renderer>().material;

                GameObject mat = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/RigAnchor/rig/body/LBAGI./SamuraiArmor");
                if (mat != null)
                    mat.GetComponent<SkinnedMeshRenderer>().material = renderer;

                GameObject slingshot = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/RigAnchor/rig/body/CosmeticBodyAnchorOverrides/SlingshotAnchors/SlingshotAnchor_Tees/DropZoneAnchor/LMABB./HornsSlingshot/HornsSlingshot");
                if (slingshot != null)
                    slingshot.GetComponent<MeshRenderer>().material = renderer;

                GameObject claw = GameObject.Find("Player Objects/Local VRRig/Local Gorilla Player/RigAnchor/rig/body/LMAJO./DragonClaw");
                if (claw != null)
                    claw.GetComponent<SkinnedMeshRenderer>().material = renderer;
            }
        }
    }
}
