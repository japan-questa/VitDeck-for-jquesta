
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
using VRC.SDK3.Components;
#if !COMPILER_UDONSHARP && UNITY_EDITOR
using UnityEditor;
using UdonSharpEditor;
#endif

namespace Vket.VketPrefabs
{
    [UdonBehaviourSyncMode(BehaviourSyncMode.Continuous)]
    public class VketFollowPickup : UdonSharpBehaviour
    {
        [Space]
        public float attachRange = 0.3f;
        public int targetBone;
        public CapsuleCollider capsuleCollider;
        public VRCPickup vrcPickup;
        [SerializeField]
        private UdonBehaviour udonManager;

        private VRCPlayerApi localPlayer;
        private HumanBodyBones followBone;
        private Vector3 relativePosition;
        private Vector3 parentLocalAxis;
        private Vector3 positionOffset;
        private Vector3 rotationAngleOffset;
        private float rotationAngle;
        private bool isFollowing;
        private bool hasAttached;
        private bool isVR;
        
        private readonly float resetTime = 30.0f;
        private readonly float positionOffsetSpeed = 0.7f;
        private readonly float rotationOffsetSpeed = 45.0f;

        private Vector3 initPosition;
        private Quaternion initRotation;
        private float remainWaitTime = 30.0f;

        void Start()
        {
            initPosition = transform.position;
            initRotation = transform.rotation;
            localPlayer = Networking.LocalPlayer;
        }

        private void Update()
        {
            if (!Networking.IsOwner(localPlayer, gameObject))
                return;

            // Setup Following
            if (!vrcPickup.IsHeld && hasAttached)
            {
                hasAttached = false;

                if (isVR)
                {
                    SetupFakeParent(
                        transform.position, transform.rotation,
                        localPlayer.GetBonePosition(followBone), localPlayer.GetBoneRotation(followBone));
                }
                else
                {
                    positionOffset = Vector3.zero;
                    rotationAngleOffset = Vector3.zero;
                    SetupFakeParent(
                        localPlayer.GetBonePosition(followBone), transform.rotation,
                        localPlayer.GetBonePosition(followBone), localPlayer.GetBoneRotation(followBone));

                    udonManager.SendCustomEvent("_EnableFollowPickupUI");
                }
                isFollowing = true;
            }

            // Follow Object
            if (isFollowing)
            {
                var bonePos = localPlayer.GetBonePosition(followBone);
                var boneRot = localPlayer.GetBoneRotation(followBone);

                Matrix4x4 m = Matrix4x4.TRS(bonePos, boneRot, Vector3.one);
                var position = m.MultiplyPoint(relativePosition);
                var globalAxis = m.MultiplyVector(parentLocalAxis);
                var rotation = Quaternion.AngleAxis(rotationAngle, globalAxis) * boneRot;
                transform.SetPositionAndRotation(position, rotation);
                if (!isVR)
                {
                    DesktopInputs();
                    transform.rotation = transform.rotation * Quaternion.Euler(rotationAngleOffset);
                    transform.position += localPlayer.GetRotation() * positionOffset;
                }

                return;
            }

            // Reset Timer
            if (!vrcPickup.IsHeld && remainWaitTime > 0)
            {
                remainWaitTime -= Time.deltaTime;
                if (remainWaitTime <= 0)
                {
                    transform.position = initPosition;
                    transform.rotation = initRotation;
                }
            }
        }

        public override void OnPickup()
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(SendOnPickup));
        }

        public void SendOnPickup()
        {
            isFollowing = false;
            remainWaitTime = resetTime;
        }

        public override void OnPickupUseDown()
        {
            isVR = localPlayer.IsUserInVR();
            hasAttached = AttachBone(targetBone, isVR);
        }

        private void DesktopInputs()
        {
            if (Input.GetKeyDown("tab"))
            {
                udonManager.SendCustomEvent("_DisableFollowPickupUI");
                SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(SendOnPickup));
            }

            bool shift = Input.GetKey("left shift") || Input.GetKey("right shift");
            if (Input.GetKey("j"))
            {
                if (shift)
                    positionOffset.x -= Time.deltaTime * positionOffsetSpeed;
                else
                    rotationAngleOffset.y -= Time.deltaTime * rotationOffsetSpeed;
            }
            if (Input.GetKey("l"))
            {
                if (shift)
                    positionOffset.x += Time.deltaTime * positionOffsetSpeed;
                else
                    rotationAngleOffset.y += Time.deltaTime * rotationOffsetSpeed;
            }
            if (Input.GetKey("k"))
            {
                if (shift)
                    positionOffset.y -= Time.deltaTime * positionOffsetSpeed;
                else
                    rotationAngleOffset.x -= Time.deltaTime * rotationOffsetSpeed;
            }
            if (Input.GetKey("i"))
            {
                if (shift)
                    positionOffset.y += Time.deltaTime * positionOffsetSpeed;
                else
                    rotationAngleOffset.x += Time.deltaTime * rotationOffsetSpeed;
            }
            if (Input.GetKey("u"))
            {
                if (shift)
                    positionOffset.z -= Time.deltaTime * positionOffsetSpeed;
                else
                    rotationAngleOffset.z -= Time.deltaTime * rotationOffsetSpeed;
            }
            if (Input.GetKey("o"))
            {
                if (shift)
                    positionOffset.z += Time.deltaTime * positionOffsetSpeed;
                else
                    rotationAngleOffset.z += Time.deltaTime * rotationOffsetSpeed;
            }
        }

        private bool AttachBone(int targetBone, bool isVR)
        {
            HumanBodyBones bone;
            switch (targetBone)
            {
                case 0:
                    bone = HumanBodyBones.Head;
                    break;
                case 1:
                    bone = HumanBodyBones.Neck;
                    break;
                case 2:
                    bone = HumanBodyBones.Chest;
                    break;
                case 3:
                    bone = HumanBodyBones.Spine;
                    break;
                case 4:
                    bone = HumanBodyBones.Hips;
                    break;
                case 5:
                    if (vrcPickup == localPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right))
                        bone = HumanBodyBones.LeftShoulder;
                    else
                        bone = HumanBodyBones.RightShoulder;
                    break;
                case 6:
                    if (vrcPickup == localPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right))
                        bone = HumanBodyBones.LeftUpperArm;
                    else
                        bone = HumanBodyBones.RightUpperArm;
                    break;
                case 7:
                    if (vrcPickup == localPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right))
                        bone = HumanBodyBones.LeftLowerArm;
                    else
                        bone = HumanBodyBones.RightLowerArm;
                    break;
                case 8:
                    if (vrcPickup == localPlayer.GetPickupInHand(VRC_Pickup.PickupHand.Right))
                        bone = HumanBodyBones.LeftHand;
                    else
                        bone = HumanBodyBones.RightHand;
                    break;
                case 9:
                    if (IsAttachRightBone(localPlayer.GetBonePosition(HumanBodyBones.LeftUpperLeg), localPlayer.GetBonePosition(HumanBodyBones.RightUpperLeg)))
                        bone = HumanBodyBones.RightUpperLeg;
                    else
                        bone = HumanBodyBones.LeftUpperLeg;
                    break;
                case 10:
                    if (IsAttachRightBone(localPlayer.GetBonePosition(HumanBodyBones.LeftLowerLeg), localPlayer.GetBonePosition(HumanBodyBones.RightLowerLeg)))
                        bone = HumanBodyBones.RightLowerLeg;
                    else 
                        bone = HumanBodyBones.LeftLowerLeg;
                    break;
                case 11:
                    if (IsAttachRightBone(localPlayer.GetBonePosition(HumanBodyBones.LeftFoot), localPlayer.GetBonePosition(HumanBodyBones.RightFoot)))
                        bone = HumanBodyBones.RightFoot;
                    else
                        bone = HumanBodyBones.LeftFoot;
                    break;
                default:
                    bone = HumanBodyBones.Head;
                    break;
            }

            Vector3 bonePos = localPlayer.GetBonePosition(bone);
            if (bonePos == Vector3.zero)
                return false;

            if (Vector3.Distance(transform.position, bonePos) > attachRange && isVR)
            {
                return false;
            }
            else
            {
                followBone = bone;
                vrcPickup.Drop();

                return true;
            }
        }

        private bool IsAttachRightBone(Vector3 leftBonePos, Vector3 rightBonePos)
        {
            float leftDist = Vector3.SqrMagnitude(leftBonePos - transform.position);
            float rightDist = Vector3.SqrMagnitude(rightBonePos - transform.position);
            return rightDist < leftDist;
        }

        private void SetupFakeParent(Vector3 position, Quaternion rotation, Vector3 targetPos, Quaternion targetRot)
        {
            Matrix4x4 m1 = Matrix4x4.TRS(-targetPos, Quaternion.identity, Vector3.one);
            Matrix4x4 m2 = Matrix4x4.TRS(Vector3.zero, Quaternion.Inverse(targetRot), Vector3.one);
            Matrix4x4 m = m2 * m1;
            Vector4 p = new Vector4(position.x, position.y, position.z, 1f);
            relativePosition = m * p;
            var rotationMatrix = transform.rotation * Quaternion.Inverse(targetRot);
            Vector3 globalAxis;
            rotationMatrix.ToAngleAxis(out rotationAngle, out globalAxis);
            parentLocalAxis = m.MultiplyVector(globalAxis);
        }
#if !COMPILER_UDONSHARP && UNITY_EDITOR
        private void OnDrawGizmosSelected()
        {
            this.UpdateProxy();
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, attachRange);
        }
#endif
    }
    
#if !COMPILER_UDONSHARP && UNITY_EDITOR
    [CustomEditor(typeof(VketFollowPickup))]
    public class VketFollowPickupEditor : Editor
    {
        private Vector2 scrollPosition = Vector2.zero;

        public override void OnInspectorGUI()
        {
            if (UdonSharpGUI.DrawDefaultUdonSharpBehaviourHeader(target)) return;

            VketFollowPickup vketFollowPickup = (VketFollowPickup)target;

            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Height(108));
            EditorGUILayout.TextArea(
                "** ReadMe **\n" +
                "- Useすると体に追従するPickupです\n" +
                "　位置同期し、誰も持っていない状態で30秒経過すると位置がリセットされます\n" +
                "- \"Target Bone\"で指定したBoneに追従します\n" +
                "- Useした時、\"Attach Range\"の範囲内にBoneがあれば追従を開始します\n" +
                "- オブジェクトの子に見た目に設定したいオブジェクトを配置して、\n" +
                "　CapsuleColliderを適度な大きさに調整してください\n" +
                "- This Pickup will follow the player when Used.\n" +
                "  It's location is synced and reset when left for 30 seconds without being held.\n" +
                "- When Used, the object will start following a Bone within the range of \"Attach Range\".\n" +
                "- Set the object for appearance as a child of \"ModeController\" object\n" +
                "　and adjust the size of CapsuleCollider as you see fit.");
            EditorGUILayout.EndScrollView();
            EditorGUILayout.Space();

            // Draw Field of Attach Range
            EditorGUI.BeginChangeCheck();
            float attachRange = EditorGUILayout.FloatField("Attach Range", vketFollowPickup.attachRange);
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(vketFollowPickup, "Modify attach range");
                vketFollowPickup.attachRange = attachRange;
            }

            // Draw Field of Target Bone
            EditorGUI.BeginChangeCheck();
            int bone = EditorGUILayout.Popup("Target Bone", vketFollowPickup.targetBone,
                new string[] { "Head", "Neck", "Chest", "Spine", "Hips", "Shoulder", "UpperArm", "LowerArm", "Hand", "UpperLeg", "LowerLeg", "Foot" });
            if (EditorGUI.EndChangeCheck())
            {
                Undo.RecordObject(vketFollowPickup, "Modifi target bone");
                vketFollowPickup.targetBone = bone;
            }

            //base.OnInspectorGUI();
        }
    }
#endif
    
}