
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;
#if !COMPILER_UDONSHARP && UNITY_EDITOR
using UnityEditor;
using UdonSharpEditor;
#endif

[UdonBehaviourSyncMode(BehaviourSyncMode.Manual)]
public class GlobalToggleSwitch : UdonSharpBehaviour
{
    [SerializeField] GameObject _toggleObject;

    [UdonSynced, FieldChangeCallback(nameof(SyncedVariable))] private bool _syncedState;

    private void Start()
    {
        if(_toggleObject == null) { return; }
        if(!Networking.IsOwner(Networking.LocalPlayer, this.gameObject)) { return; }
        _syncedState = _toggleObject.activeInHierarchy;
    }

    public bool SyncedVariable
    {
        get => _syncedState;
        set
        {
            _syncedState = value;
            UpdateObjState_Sync();
        }
    }

    public override void Interact()
    {
        if (Networking.LocalPlayer.IsOwner(this.gameObject))
        {
            ToggleState();
        }
        else
        {
            SendCustomNetworkEvent(VRC.Udon.Common.Interfaces.NetworkEventTarget.Owner, nameof(ToggleState));
        }
    }

    public void ToggleState()
    {
        _syncedState = !_syncedState;
        RequestSerialization();
        UpdateObjState_Sync();
    }

    public void UpdateObjState_Sync()
    {
        if (_toggleObject == null) { return; }
        _toggleObject.SetActive(_syncedState);
    }


#if !COMPILER_UDONSHARP && UNITY_EDITOR
    [CustomEditor(typeof(GlobalToggleSwitch))]
    public class GlobalToggleSwitchEditor : Editor
    {
        public override void OnInspectorGUI()
        {
            if (UdonSharpGUI.DrawDefaultUdonSharpBehaviourHeader(target)) return;

            // Draw Title and Summary
            var style = new GUIStyle();
            EditorGUILayout.BeginVertical(GUI.skin.box);
            EditorGUILayout.LabelField("  GlobalToggleSwitch", new GUIStyle(EditorStyles.boldLabel));
            EditorGUILayout.EndVertical();
            EditorGUILayout.TextArea(
                "** ReadMe **\n" +
                "- 同期するObjectオンオフのトグルスイッチです\n" +
                "- 本Prefabの子に見た目に設定したいオブジェクトを配置して、\n" +
                "　BoxColliderを適度な大きさに調整してください\n" +
                "- 切り替え対象のObjectをToggle Objectに登録してください");
            EditorGUILayout.Space();

            serializedObject.Update();

            var objectProperty = serializedObject.FindProperty("_toggleObject");
            EditorGUILayout.PropertyField(objectProperty);

            serializedObject.ApplyModifiedProperties();
        }
    }
#endif
}
