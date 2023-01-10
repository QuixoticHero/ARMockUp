using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.Audio;
using ScriptableObjectArchitecture;
using UnityEngine.Playables;

[Serializable]
public class StringStringDictionary : SerializableDictionary<string, string> {}

[Serializable]
public class ObjectColorDictionary : SerializableDictionary<UnityEngine.Object, Color> {}

[Serializable]
public class ColorArrayStorage : SerializableDictionary.Storage<Color[]> {}

[Serializable]
public class StringColorArrayDictionary : SerializableDictionary<string, Color[], ColorArrayStorage> {}

[Serializable]
public class StringAnimationCurveDictonary : SerializableDictionary<string, AnimationCurve> {}

[Serializable]
public class IntTransformDictionary : SerializableDictionary<int, Transform> { }

[Serializable]
public class StringGameObjectDictionary : SerializableDictionary<string, GameObject> { }

[Serializable]
public class StringIntGameEventDictionary : SerializableDictionary<string, IntGameEvent> { }


[Serializable]
public class StringStringGameEventDictionary : SerializableDictionary<string, StringGameEvent> { }
//BoolGameEventReference

[Serializable]
public class StringBoolGameEventDictionary : SerializableDictionary<string, BoolGameEvent> { }

[Serializable]
public class StringGameEventDictionary : SerializableDictionary<string, GameEvent> { }

[Serializable]
public class Vector3IntVector3Dictionary : SerializableDictionary<Vector3Int, Vector3> { }

[Serializable]
public class Vector3ArrayStorage : SerializableDictionary.Storage<Vector3[]> { }

[Serializable]
public class GameObjectArrayStorage : SerializableDictionary.Storage<GameObject[]> { }
[Serializable]
public class IntGameObjectArrayDictionary : SerializableDictionary<int, GameObject[], GameObjectArrayStorage> { }

[Serializable]
public class GameObjectListStorage : SerializableDictionary.Storage<List<GameObject>> { }

[Serializable]
public class GameObjectHashsetStorage : SerializableDictionary.Storage<HashSet<GameObject>> { }


[Serializable]
public class AudioClipArrayStorage : SerializableDictionary.Storage<AudioClip[]> { }

[Serializable]
public class IntAudioClipArrayDictionary : SerializableDictionary<int, AudioClip[], AudioClipArrayStorage> { }

[Serializable]
public class IntVector3ArrayStorage : SerializableDictionary<int, Vector3[], Vector3ArrayStorage> { }

[Serializable]
public class StringAudioSourceStorage : SerializableDictionary<string, AudioSource> { }

[Serializable]
public class StringPlayableDirectorStorage : SerializableDictionary<string, PlayableDirector> { }

[Serializable]
public class StringAudioMixerGroupStorage : SerializableDictionary<string, AudioMixerGroup> { }

#if NET_4_6 || NET_STANDARD_2_0
[Serializable]
public class StringHashSet : SerializableHashSet<string> {}
#endif
