using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(RainbowTrail.Core), "RainbowTrail", "1.0.0", "EchoTyler", null)]
[assembly: MelonGame("Slope Plus", "Slope Plus")]

namespace RainbowTrail
{
    public class Core : MelonMod
    {
        public override void OnInitializeMelon()
        {
            TrailRenderer trail = GameObject.Find("Sphere").GetComponentInChildren<TrailRenderer>();
            Gradient gradient = new();
            gradient.SetKeys(
            [
                new GradientColorKey(new Color32(255,0,0,255), 0f),
                new GradientColorKey(new Color32(255,139,0,255), 0.132f),
                new GradientColorKey(new Color32(255,255,0,255), 0.282f),
                new GradientColorKey(new Color32(0,255,0,255), 0.456f),
                new GradientColorKey(new Color32(0,255,255,255), 0.615f),
                new GradientColorKey(new Color32(125,0,255,255), 0.776f),
            ],
            [
                new GradientAlphaKey(1f, 0f),
                new GradientAlphaKey(0f, 1f),
            ]);
            trail.colorGradient = gradient;
            LoggerInstance.Msg("Loaded Rainbow Trail");
        }
    }
}