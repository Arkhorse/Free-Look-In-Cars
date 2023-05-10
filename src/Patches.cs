namespace FreeLookInCars
{
    [HarmonyPatch(typeof(PlayerInVehicle), nameof(PlayerInVehicle.EnterVehicle))]
    internal class PlayerInVehicle_EnterVehicle
    {
        private static void Postfix(PlayerInVehicle __instance)
        {
            __instance.m_YawLimitDegrees    = __instance.m_StartYawLimit;
            __instance.m_PitchLimitDegrees  = __instance.m_StartPitchLimit;
            //__instance.m_YawLimitDegrees = new Vector2(-180, 180);
            //__instance.m_PitchLimitDegrees = new Vector2(-90, 90);
        }
    }
}
