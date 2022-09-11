
using System.Collections.Generic;
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
    public class VketPickup : UdonSharpBehaviour
    {
        [SerializeField]
        private AnimatorOverrideController overrideController;

        [SerializeField]
        private Animator animator;
        [SerializeField]
        private AnimatorOverrideController overrideControllerBase;
        [SerializeField]
        private VRCPickup vrcPickup;
        [SerializeField]
        private VRCObjectSync objectSync;

        private readonly float resetTime = 30.0f;

        private bool isPickup;
        private float remainWaitTime = 30.0f;

        private void Update()
        {
            if (!vrcPickup.IsHeld && remainWaitTime > 0)
            {
                remainWaitTime -= Time.deltaTime;
                if (remainWaitTime <= 0)
                    objectSync.Respawn();
            }
        }

        public void SendOnDrop()
        {
            animator.SetBool("Pickup", false);
            animator.SetBool("Use", false);
        }
        
        public void SendOnPickup()
        {
            remainWaitTime = resetTime;

            if (overrideController != null)
                animator.SetBool("Pickup", true);
        }

        public void SendOnPickupUseDown()
        {
            animator.SetBool("Use", true);
        }

        public void SendOnPickupUseUp()
        {
            animator.SetBool("Use", false);
        }

        public override void OnDrop()
        {
            if (overrideController != null)
                SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(SendOnDrop));
        }
        public override void OnPickup()
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(SendOnPickup));
        }
        public override void OnPickupUseDown()
        {
            if (overrideController != null)
                SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(SendOnPickupUseDown));
        }
        public override void OnPickupUseUp()
        {
            if (overrideController != null)
                SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.All, nameof(SendOnPickupUseUp));
        }
    }
    
#if !COMPILER_UDONSHARP && UNITY_EDITOR
    [CustomEditor(typeof(VketPickup))]
    public class VketPickupEditor : Editor
    {
        private Vector2 scrollPosition = Vector2.zero;

        public override void OnInspectorGUI()
        {
            if (UdonSharpGUI.DrawDefaultUdonSharpBehaviourHeader(target)) return;

            // Draw Title and Summary
            var style = new GUIStyle();
            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.LabelField("  Vket Pickup", new GUIStyle(EditorStyles.boldLabel));
            EditorGUILayout.EndVertical();
            scrollPosition = EditorGUILayout.BeginScrollView(scrollPosition, GUILayout.Height(108));
            EditorGUILayout.TextArea(
                "** ReadMe **\n" +
                "- 位置同期するPickupです。誰も持っていない状態で30秒経過すると位置がリセットされます\n" +
                "- \"ModeController\"オブジェクトの子に見た目に設定したいオブジェクトを配置して、\n" +
                "　CapsuleColliderを適度な大きさに調整してください\n" +
                "- Animationさせたい場合は\"Create new override controller\"ボタンを押して\n" +
                "　新しいOverrideControllerを保存してからAnimationClipを登録してください\n" +
                "- This is a synced Pickup whose location will be reset when left for 30 seconds without being held.\n" +
                "- Set the object for appearance as a child of \"ModeController\" object\n" +
                "　and adjust the size of CapsuleCollider as you see fit.\n" +
                "- If you want to have Animation, press \"Create new override controller\" button and\n" +
                "　save the new OverrideController, to which you can register your AnimationClip.");
            EditorGUILayout.EndScrollView();
            EditorGUILayout.Space();

            serializedObject.Update();

            var overrideControllerProperty = serializedObject.FindProperty("overrideController");
            var overrideControllerBaseProperty = serializedObject.FindProperty("overrideControllerBase");
            var animator = (Animator)serializedObject.FindProperty("animator").objectReferenceValue;

            // Draw Field of Override Controller
            EditorGUI.BeginChangeCheck();
            var overrideController = (AnimatorOverrideController)EditorGUILayout.ObjectField("Override Controller", overrideControllerProperty.objectReferenceValue, typeof(AnimatorOverrideController), false);
            if (EditorGUI.EndChangeCheck())
            {
                if (overrideController == serializedObject.FindProperty("overrideControllerBase").objectReferenceValue)
                    return;

                overrideControllerProperty.objectReferenceValue = overrideController;
                Undo.RecordObject(animator, "Modify animator");
                animator.runtimeAnimatorController = overrideController;

                serializedObject.ApplyModifiedProperties();
                return;
            }

            if (overrideController == null)
            {
                // Create New Override Controller
                if (GUILayout.Button("Create new override controller"))
                {
                    var newController = CreateOverrideController((AnimatorOverrideController)overrideControllerBaseProperty.objectReferenceValue);
                    if (newController != null)
                    {
                        overrideControllerProperty.objectReferenceValue = newController;
                        Undo.RecordObject(animator, "Modify animator");
                        animator.runtimeAnimatorController = newController;

                        serializedObject.ApplyModifiedProperties();
                        return;
                    }
                }
            }
            else
            {
                // If Attach Override Controller Base Then Detach
                if (overrideControllerProperty.objectReferenceValue == overrideControllerBaseProperty.objectReferenceValue)
                {
                    overrideControllerProperty.objectReferenceValue = null;
                    animator.runtimeAnimatorController = null;
                    EditorUtility.SetDirty(animator);

                    serializedObject.ApplyModifiedProperties();
                    return;
                }

                // Draw Field of Override Animation Clips
                List<KeyValuePair<AnimationClip, AnimationClip>> overrides = new List<KeyValuePair<AnimationClip, AnimationClip>>();
                overrideController.GetOverrides(overrides);

                EditorGUI.indentLevel++;
                EditorGUI.BeginChangeCheck();
                var clips = new AnimationClip[4];
                clips[0] = (AnimationClip)EditorGUILayout.ObjectField(overrides[0].Key.name, overrides[0].Value, typeof(AnimationClip), false);
                clips[1] = (AnimationClip)EditorGUILayout.ObjectField(overrides[1].Key.name, overrides[1].Value, typeof(AnimationClip), false);
                clips[2] = (AnimationClip)EditorGUILayout.ObjectField(overrides[2].Key.name, overrides[2].Value, typeof(AnimationClip), false);
                clips[3] = (AnimationClip)EditorGUILayout.ObjectField(overrides[3].Key.name, overrides[3].Value, typeof(AnimationClip), false);
                if (EditorGUI.EndChangeCheck())
                {
                    for (int i = 0; i < 4; i++)
                        overrides[i] = new KeyValuePair<AnimationClip, AnimationClip>(overrides[i].Key, clips[i]);

                    Undo.RecordObject(overrideController, "Modify override clip");
                    overrideController.ApplyOverrides(overrides);
                }
                EditorGUI.indentLevel--;
            }
            /*
            EditorGUILayout.Space();

            EditorGUI.BeginDisabledGroup(true);
            EditorGUILayout.ObjectField("OverrideControllerEmpty", serializedObject.FindProperty("overrideControllerBase").objectReferenceValue, typeof(AnimatorOverrideController), false);
            EditorGUI.EndDisabledGroup();
            */
            //base.OnInspectorGUI();
        }

        private AnimatorOverrideController CreateOverrideController(AnimatorOverrideController overrideControllerBase)
        {
            var path = EditorUtility.SaveFilePanelInProject("Save new override controller", "NewOverrideController.overrideController", "overrideController", "");
            if (!string.IsNullOrEmpty(path))
            {
                if (overrideControllerBase == null)
                {
                    Debug.Log("Error! Not found override controller empty");
                    return null;
                }

                var newController = new AnimatorOverrideController(overrideControllerBase);
                AssetDatabase.CreateAsset(newController, path);
                AssetDatabase.Refresh();
                Undo.RegisterCreatedObjectUndo(newController, "Create override controller");

                return newController;
            }

            return null;
        }
    }
#endif
}