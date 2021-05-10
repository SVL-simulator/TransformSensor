/**
 * Copyright (c) 2020 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using Simulator.Bridge;
using Simulator.Sensors.UI;
using Simulator.Utilities;

namespace Simulator.Sensors
{
    [SensorType("Transform", new System.Type[] { })]
    public class TransformSensor : SensorBase
    {
        public override SensorDistributionType DistributionType => SensorDistributionType.MainOrClient;
        public override float PerformanceLoad { get; } = 0.05f;

        protected override void Initialize()
        {
        }

        protected override void Deinitialize()
        {
        }

        public override void OnBridgeSetup(BridgeInstance bridge)
        {
        }

        public override void OnVisualize(Visualizer visualizer)
        {
        }

        public override void OnVisualizeToggle(bool state)
        {
        }
    }
}