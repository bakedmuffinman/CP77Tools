using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WeaponPositionComponent : gameScriptableComponent
	{
		[Ordinal(0)]  [RED("UILayerID0")] public CUInt32 UILayerID0 { get; set; }
		[Ordinal(1)]  [RED("UILayerID1")] public CUInt32 UILayerID1 { get; set; }
		[Ordinal(2)]  [RED("UILayerID2")] public CUInt32 UILayerID2 { get; set; }
		[Ordinal(3)]  [RED("UILayerID3")] public CUInt32 UILayerID3 { get; set; }
		[Ordinal(4)]  [RED("cameraCrouchHeight")] public CFloat CameraCrouchHeight { get; set; }
		[Ordinal(5)]  [RED("cameraHeightOffset")] public CFloat CameraHeightOffset { get; set; }
		[Ordinal(6)]  [RED("cameraResetPitch")] public CBool CameraResetPitch { get; set; }
		[Ordinal(7)]  [RED("cameraStandHeight")] public CFloat CameraStandHeight { get; set; }
		[Ordinal(8)]  [RED("fineTuneWeaponPose")] public CBool FineTuneWeaponPose { get; set; }
		[Ordinal(9)]  [RED("playerPuppet")] public wCHandle<PlayerPuppet> PlayerPuppet { get; set; }
		[Ordinal(10)]  [RED("positionSensitivity")] public CFloat PositionSensitivity { get; set; }
		[Ordinal(11)]  [RED("positionSensitivityFineTuning")] public CFloat PositionSensitivityFineTuning { get; set; }
		[Ordinal(12)]  [RED("rotationSensitivity")] public CFloat RotationSensitivity { get; set; }
		[Ordinal(13)]  [RED("rotationSensitivityFineTuning")] public CFloat RotationSensitivityFineTuning { get; set; }
		[Ordinal(14)]  [RED("tweakPoseState")] public CEnum<TweakWeaponPose> TweakPoseState { get; set; }
		[Ordinal(15)]  [RED("tweakPosition")] public CBool TweakPosition { get; set; }
		[Ordinal(16)]  [RED("tweakRotation")] public CBool TweakRotation { get; set; }
		[Ordinal(17)]  [RED("visSys")] public CHandle<gameVisionModeSystem> VisSys { get; set; }
		[Ordinal(18)]  [RED("visionSwitch")] public CBool VisionSwitch { get; set; }
		[Ordinal(19)]  [RED("weaponAimPosOffsetFromInput")] public Vector4 WeaponAimPosOffsetFromInput { get; set; }
		[Ordinal(20)]  [RED("weaponAimPosVec")] public Vector4 WeaponAimPosVec { get; set; }
		[Ordinal(21)]  [RED("weaponAimRotOffsetFromInput")] public Vector4 WeaponAimRotOffsetFromInput { get; set; }
		[Ordinal(22)]  [RED("weaponAimRotVec")] public Vector4 WeaponAimRotVec { get; set; }
		[Ordinal(23)]  [RED("weaponPosDeltaX")] public CFloat WeaponPosDeltaX { get; set; }
		[Ordinal(24)]  [RED("weaponPosDeltaY")] public CFloat WeaponPosDeltaY { get; set; }
		[Ordinal(25)]  [RED("weaponPosDeltaZ")] public CFloat WeaponPosDeltaZ { get; set; }
		[Ordinal(26)]  [RED("weaponPosOffsetFromInput")] public Vector4 WeaponPosOffsetFromInput { get; set; }
		[Ordinal(27)]  [RED("weaponPosVec")] public Vector4 WeaponPosVec { get; set; }
		[Ordinal(28)]  [RED("weaponRotDeltaX")] public CFloat WeaponRotDeltaX { get; set; }
		[Ordinal(29)]  [RED("weaponRotDeltaY")] public CFloat WeaponRotDeltaY { get; set; }
		[Ordinal(30)]  [RED("weaponRotDeltaZ")] public CFloat WeaponRotDeltaZ { get; set; }
		[Ordinal(31)]  [RED("weaponRotOffsetFromInput")] public Vector4 WeaponRotOffsetFromInput { get; set; }
		[Ordinal(32)]  [RED("weaponRotVec")] public Vector4 WeaponRotVec { get; set; }

		public WeaponPositionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}