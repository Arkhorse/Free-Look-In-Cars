global using System.Reflection;
global using System.Runtime.InteropServices;
global using Il2Cpp;
global using HarmonyLib;
global using MelonLoader;
global using UnityEngine;

namespace FreeLookInCars
{
    internal class FreeLookInCars : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg($"[{Assembly.GetExecutingAssembly().GetName().Name}] Version {Assembly.GetExecutingAssembly().GetName().Version} loaded!");
        }
    }
}
