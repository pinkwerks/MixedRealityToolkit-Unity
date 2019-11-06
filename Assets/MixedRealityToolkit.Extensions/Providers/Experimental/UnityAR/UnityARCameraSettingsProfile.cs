﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Copyright(c) 2019 Takahiro Miyaura
// Licensed under the MIT License. See LICENSE in the project root for license information.﻿

using Microsoft.MixedReality.Toolkit.CameraSystem;
using UnityEngine;
using UnityEngine.SpatialTracking;

namespace Microsoft.MixedReality.Toolkit.Experimental.UnityAR
{
    /// <summary>
    /// Configuration profile for the XR Camera settings provider.
    /// </summary>
    [CreateAssetMenu(menuName = "Mixed Reality Toolkit/Profiles/Unity AR Foundation Camera Settings Profile", fileName = "DefaultUnityARCameraSettingsProfile", order = 100)]
    [MixedRealityServiceProfile(typeof(UnityARCameraSettings))]
    public class UnityARCameraSettingsProfile : BaseCameraSettingsProfile
    {
#if !(WINDOWS_UWP && !ENABLE_IL2CPP)

#region Tracked Pose Driver settings

        [SerializeField]
        [Tooltip("The portion of the device (ex: color camera) from which to read the pose.")]
        private TrackedPoseDriver.TrackedPose poseSource = TrackedPoseDriver.TrackedPose.ColorCamera;

        /// <summary>
        /// The portion of the device (ex: color camera) from which to read the pose.
        /// </summary>
        public TrackedPoseDriver.TrackedPose PoseSource => poseSource;

        [SerializeField]
        [Tooltip("The type of tracking (position and/or rotation) to apply.")]
        private TrackedPoseDriver.TrackingType trackingType = TrackedPoseDriver.TrackingType.RotationAndPosition;

        /// <summary>
        /// The type of tracking (position and/or rotation) to apply.
        /// </summary>
        public TrackedPoseDriver.TrackingType TrackingType => trackingType;

        [SerializeField]
        [Tooltip("Specifies when (during Update and/or just before rendering) to update the tracking of the pose.")]
        private TrackedPoseDriver.UpdateType updateType = TrackedPoseDriver.UpdateType.UpdateAndBeforeRender;

        /// <summary>
        /// Specifies when (during Update and/or just before rendering) to update the tracking of the pose.
        /// </summary>
        public TrackedPoseDriver.UpdateType UpdateType => updateType;

#endregion Tracked Pose Driver settings

#endif // !(WINDOWS_UWP && !ENABLE_IL2CPP)
    }
}
