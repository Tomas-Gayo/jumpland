using UnityEngine;
using UnityEngine.Events;

namespace ScriptableObjectArchitecture
{
	[System.Serializable]
	public sealed class SceneRequestUnityEvent : UnityEvent<SceneRequest>
	{
	}
}