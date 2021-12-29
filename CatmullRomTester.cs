using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JPBotelho;

namespace Curve.Tester {
    [AddComponentMenu(CurveTesterPath + "CatmullRomTester")]
    public class CatmullRomTester : BaseCurveTester {
        [SerializeField, Min(2)] int resolution = 1;
        [SerializeField] bool closeLoop = false;
        private void OnValidate() => base.SetCurve(new CatmullRom(base.points, this.resolution, this.closeLoop));
    }
}