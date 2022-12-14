#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.String UnityEngine.JsonUtility::ToJsonInternal(System.Object,System.Boolean)
extern void JsonUtility_ToJsonInternal_mFF47E01456F54247452898B77F4FDADF2E546C45 (void);
// 0x00000002 System.String UnityEngine.JsonUtility::ToJson(System.Object)
extern void JsonUtility_ToJson_m491DC338B9CEC36588C29B13673484B9B22348A8 (void);
// 0x00000003 System.String UnityEngine.JsonUtility::ToJson(System.Object,System.Boolean)
extern void JsonUtility_ToJson_m8A3321288D36CE4383BE7F22C4DACFAF1DEE9ABF (void);
static Il2CppMethodPointer s_methodPointers[3] = 
{
	JsonUtility_ToJsonInternal_mFF47E01456F54247452898B77F4FDADF2E546C45,
	JsonUtility_ToJson_m491DC338B9CEC36588C29B13673484B9B22348A8,
	JsonUtility_ToJson_m8A3321288D36CE4383BE7F22C4DACFAF1DEE9ABF,
};
static const int32_t s_InvokerIndices[3] = 
{
	1859,
	2066,
	1859,
};
extern const CustomAttributesCacheGenerator g_UnityEngine_JSONSerializeModule_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_UnityEngine_JSONSerializeModule_CodeGenModule;
const Il2CppCodeGenModule g_UnityEngine_JSONSerializeModule_CodeGenModule = 
{
	"UnityEngine.JSONSerializeModule.dll",
	3,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	0,
	NULL,
	0,
	NULL,
	NULL,
	g_UnityEngine_JSONSerializeModule_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
