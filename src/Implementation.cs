using System.Reflection;
using UnityEngine;
using MelonLoader;

namespace FreeLookInCars
{
    internal class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg($"[{Assembly.GetExecutingAssembly().GetName().Name}] Version {Assembly.GetExecutingAssembly().GetName().Version} loaded!");
        }
    }
}
