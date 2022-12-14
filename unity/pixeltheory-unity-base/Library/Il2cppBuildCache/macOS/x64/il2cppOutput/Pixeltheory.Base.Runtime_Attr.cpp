#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>



// System.Char[]
struct CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34;
// System.Runtime.CompilerServices.CompilationRelaxationsAttribute
struct CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF;
// System.Diagnostics.ConditionalAttribute
struct ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C;
// System.Diagnostics.DebuggableAttribute
struct DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B;
// UnityEngine.DefaultExecutionOrder
struct DefaultExecutionOrder_t8495D3D4ECDFC3590621D31C3677D234D8A9BB1F;
// UnityEngine.DisallowMultipleComponent
struct DisallowMultipleComponent_tDB3D3DBC9AC523A0BD11DA0B7D88F960FDB89E3E;
// UnityEngine.HeaderAttribute
struct HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB;
// System.ParamArrayAttribute
struct ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F;
// System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
struct RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80;
// UnityEngine.SerializeField
struct SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25;
// System.String
struct String_t;



IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object


// System.Attribute
struct Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71  : public RuntimeObject
{
public:

public:
};


// System.String
struct String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::m_stringLength
	int32_t ___m_stringLength_0;
	// System.Char System.String::m_firstChar
	Il2CppChar ___m_firstChar_1;

public:
	inline static int32_t get_offset_of_m_stringLength_0() { return static_cast<int32_t>(offsetof(String_t, ___m_stringLength_0)); }
	inline int32_t get_m_stringLength_0() const { return ___m_stringLength_0; }
	inline int32_t* get_address_of_m_stringLength_0() { return &___m_stringLength_0; }
	inline void set_m_stringLength_0(int32_t value)
	{
		___m_stringLength_0 = value;
	}

	inline static int32_t get_offset_of_m_firstChar_1() { return static_cast<int32_t>(offsetof(String_t, ___m_firstChar_1)); }
	inline Il2CppChar get_m_firstChar_1() const { return ___m_firstChar_1; }
	inline Il2CppChar* get_address_of_m_firstChar_1() { return &___m_firstChar_1; }
	inline void set_m_firstChar_1(Il2CppChar value)
	{
		___m_firstChar_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_5;

public:
	inline static int32_t get_offset_of_Empty_5() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_5)); }
	inline String_t* get_Empty_5() const { return ___Empty_5; }
	inline String_t** get_address_of_Empty_5() { return &___Empty_5; }
	inline void set_Empty_5(String_t* value)
	{
		___Empty_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___Empty_5), (void*)value);
	}
};


// System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52  : public RuntimeObject
{
public:

public:
};

// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52_marshaled_com
{
};

// System.Boolean
struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37, ___m_value_0)); }
	inline bool get_m_value_0() const { return ___m_value_0; }
	inline bool* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(bool value)
	{
		___m_value_0 = value;
	}
};

struct Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields
{
public:
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;

public:
	inline static int32_t get_offset_of_TrueString_5() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___TrueString_5)); }
	inline String_t* get_TrueString_5() const { return ___TrueString_5; }
	inline String_t** get_address_of_TrueString_5() { return &___TrueString_5; }
	inline void set_TrueString_5(String_t* value)
	{
		___TrueString_5 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___TrueString_5), (void*)value);
	}

	inline static int32_t get_offset_of_FalseString_6() { return static_cast<int32_t>(offsetof(Boolean_t07D1E3F34E4813023D64F584DFF7B34C9D922F37_StaticFields, ___FalseString_6)); }
	inline String_t* get_FalseString_6() const { return ___FalseString_6; }
	inline String_t** get_address_of_FalseString_6() { return &___FalseString_6; }
	inline void set_FalseString_6(String_t* value)
	{
		___FalseString_6 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___FalseString_6), (void*)value);
	}
};


// System.Runtime.CompilerServices.CompilationRelaxationsAttribute
struct CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Int32 System.Runtime.CompilerServices.CompilationRelaxationsAttribute::m_relaxations
	int32_t ___m_relaxations_0;

public:
	inline static int32_t get_offset_of_m_relaxations_0() { return static_cast<int32_t>(offsetof(CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF, ___m_relaxations_0)); }
	inline int32_t get_m_relaxations_0() const { return ___m_relaxations_0; }
	inline int32_t* get_address_of_m_relaxations_0() { return &___m_relaxations_0; }
	inline void set_m_relaxations_0(int32_t value)
	{
		___m_relaxations_0 = value;
	}
};


// System.Diagnostics.ConditionalAttribute
struct ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.String System.Diagnostics.ConditionalAttribute::m_conditionString
	String_t* ___m_conditionString_0;

public:
	inline static int32_t get_offset_of_m_conditionString_0() { return static_cast<int32_t>(offsetof(ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C, ___m_conditionString_0)); }
	inline String_t* get_m_conditionString_0() const { return ___m_conditionString_0; }
	inline String_t** get_address_of_m_conditionString_0() { return &___m_conditionString_0; }
	inline void set_m_conditionString_0(String_t* value)
	{
		___m_conditionString_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___m_conditionString_0), (void*)value);
	}
};


// UnityEngine.DefaultExecutionOrder
struct DefaultExecutionOrder_t8495D3D4ECDFC3590621D31C3677D234D8A9BB1F  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Int32 UnityEngine.DefaultExecutionOrder::m_Order
	int32_t ___m_Order_0;

public:
	inline static int32_t get_offset_of_m_Order_0() { return static_cast<int32_t>(offsetof(DefaultExecutionOrder_t8495D3D4ECDFC3590621D31C3677D234D8A9BB1F, ___m_Order_0)); }
	inline int32_t get_m_Order_0() const { return ___m_Order_0; }
	inline int32_t* get_address_of_m_Order_0() { return &___m_Order_0; }
	inline void set_m_Order_0(int32_t value)
	{
		___m_Order_0 = value;
	}
};


// UnityEngine.DisallowMultipleComponent
struct DisallowMultipleComponent_tDB3D3DBC9AC523A0BD11DA0B7D88F960FDB89E3E  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA  : public ValueType_tDBF999C1B75C48C68621878250DBF6CDBCF51E52
{
public:

public:
};

struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields
{
public:
	// System.Char[] System.Enum::enumSeperatorCharArray
	CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* ___enumSeperatorCharArray_0;

public:
	inline static int32_t get_offset_of_enumSeperatorCharArray_0() { return static_cast<int32_t>(offsetof(Enum_t23B90B40F60E677A8025267341651C94AE079CDA_StaticFields, ___enumSeperatorCharArray_0)); }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* get_enumSeperatorCharArray_0() const { return ___enumSeperatorCharArray_0; }
	inline CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34** get_address_of_enumSeperatorCharArray_0() { return &___enumSeperatorCharArray_0; }
	inline void set_enumSeperatorCharArray_0(CharU5BU5D_t7B7FC5BC8091AA3B9CB0B29CDD80B5EE9254AA34* value)
	{
		___enumSeperatorCharArray_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___enumSeperatorCharArray_0), (void*)value);
	}
};

// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t23B90B40F60E677A8025267341651C94AE079CDA_marshaled_com
{
};

// System.ParamArrayAttribute
struct ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// UnityEngine.PropertyAttribute
struct PropertyAttribute_t4A352471DF625C56C811E27AC86B7E1CE6444052  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Runtime.CompilerServices.RuntimeCompatibilityAttribute
struct RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Boolean System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::m_wrapNonExceptionThrows
	bool ___m_wrapNonExceptionThrows_0;

public:
	inline static int32_t get_offset_of_m_wrapNonExceptionThrows_0() { return static_cast<int32_t>(offsetof(RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80, ___m_wrapNonExceptionThrows_0)); }
	inline bool get_m_wrapNonExceptionThrows_0() const { return ___m_wrapNonExceptionThrows_0; }
	inline bool* get_address_of_m_wrapNonExceptionThrows_0() { return &___m_wrapNonExceptionThrows_0; }
	inline void set_m_wrapNonExceptionThrows_0(bool value)
	{
		___m_wrapNonExceptionThrows_0 = value;
	}
};


// UnityEngine.SerializeField
struct SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:

public:
};


// System.Void
struct Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5 
{
public:
	union
	{
		struct
		{
		};
		uint8_t Void_t700C6383A2A510C2CF4DD86DABD5CA9FF70ADAC5__padding[1];
	};

public:
};


// UnityEngine.HeaderAttribute
struct HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB  : public PropertyAttribute_t4A352471DF625C56C811E27AC86B7E1CE6444052
{
public:
	// System.String UnityEngine.HeaderAttribute::header
	String_t* ___header_0;

public:
	inline static int32_t get_offset_of_header_0() { return static_cast<int32_t>(offsetof(HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB, ___header_0)); }
	inline String_t* get_header_0() const { return ___header_0; }
	inline String_t** get_address_of_header_0() { return &___header_0; }
	inline void set_header_0(String_t* value)
	{
		___header_0 = value;
		Il2CppCodeGenWriteBarrier((void**)(&___header_0), (void*)value);
	}
};


// System.Diagnostics.DebuggableAttribute/DebuggingModes
struct DebuggingModes_t279D5B9C012ABA935887CB73C5A63A1F46AF08A8 
{
public:
	// System.Int32 System.Diagnostics.DebuggableAttribute/DebuggingModes::value__
	int32_t ___value___2;

public:
	inline static int32_t get_offset_of_value___2() { return static_cast<int32_t>(offsetof(DebuggingModes_t279D5B9C012ABA935887CB73C5A63A1F46AF08A8, ___value___2)); }
	inline int32_t get_value___2() const { return ___value___2; }
	inline int32_t* get_address_of_value___2() { return &___value___2; }
	inline void set_value___2(int32_t value)
	{
		___value___2 = value;
	}
};


// System.Diagnostics.DebuggableAttribute
struct DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B  : public Attribute_t037CA9D9F3B742C063DB364D2EEBBF9FC5772C71
{
public:
	// System.Diagnostics.DebuggableAttribute/DebuggingModes System.Diagnostics.DebuggableAttribute::m_debuggingModes
	int32_t ___m_debuggingModes_0;

public:
	inline static int32_t get_offset_of_m_debuggingModes_0() { return static_cast<int32_t>(offsetof(DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B, ___m_debuggingModes_0)); }
	inline int32_t get_m_debuggingModes_0() const { return ___m_debuggingModes_0; }
	inline int32_t* get_address_of_m_debuggingModes_0() { return &___m_debuggingModes_0; }
	inline void set_m_debuggingModes_0(int32_t value)
	{
		___m_debuggingModes_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif



// System.Void System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * __this, int32_t ___relaxations0, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, const RuntimeMethod* method);
// System.Void System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::set_WrapNonExceptionThrows(System.Boolean)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method);
// System.Void System.Diagnostics.DebuggableAttribute::.ctor(System.Diagnostics.DebuggableAttribute/DebuggingModes)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550 (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * __this, int32_t ___modes0, const RuntimeMethod* method);
// System.Void UnityEngine.DisallowMultipleComponent::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DisallowMultipleComponent__ctor_mDCA4B0F84AB4B3E17D216DB29318032547AB7F0D (DisallowMultipleComponent_tDB3D3DBC9AC523A0BD11DA0B7D88F960FDB89E3E * __this, const RuntimeMethod* method);
// System.Void UnityEngine.DefaultExecutionOrder::.ctor(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void DefaultExecutionOrder__ctor_m18F4188D26702C2E3EC0AB3C1FF4AA4F5329E7A9 (DefaultExecutionOrder_t8495D3D4ECDFC3590621D31C3677D234D8A9BB1F * __this, int32_t ___order0, const RuntimeMethod* method);
// System.Void UnityEngine.SerializeField::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3 (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * __this, const RuntimeMethod* method);
// System.Void UnityEngine.HeaderAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void HeaderAttribute__ctor_m601319E0BCE8C44A9E79B2C0ABAAD0FEF46A9F1E (HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB * __this, String_t* ___header0, const RuntimeMethod* method);
// System.Void System.Diagnostics.ConditionalAttribute::.ctor(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ConditionalAttribute__ctor_m43C71F47F8ED8FDF9A11FB20E8916C3737DD66AF (ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C * __this, String_t* ___conditionString0, const RuntimeMethod* method);
// System.Void System.ParamArrayAttribute::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719 (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * __this, const RuntimeMethod* method);
static void Pixeltheory_Base_Runtime_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF * tmp = (CompilationRelaxationsAttribute_t661FDDC06629BDA607A42BD660944F039FE03AFF *)cache->attributes[0];
		CompilationRelaxationsAttribute__ctor_mAC3079EBC4EEAB474EED8208EF95DB39C922333B(tmp, 8LL, NULL);
	}
	{
		RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * tmp = (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 *)cache->attributes[1];
		RuntimeCompatibilityAttribute__ctor_m551DDF1438CE97A984571949723F30F44CF7317C(tmp, NULL);
		RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline(tmp, true, NULL);
	}
	{
		DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B * tmp = (DebuggableAttribute_tA8054EBD0FC7511695D494B690B5771658E3191B *)cache->attributes[2];
		DebuggableAttribute__ctor_m7FF445C8435494A4847123A668D889E692E55550(tmp, 263LL, NULL);
	}
}
static void DataManager_1_t6383AA44ABD7100CAB0126FFAA79B7F7A914EC6A_CustomAttributesCacheGenerator(CustomAttributesCache* cache)
{
	{
		DisallowMultipleComponent_tDB3D3DBC9AC523A0BD11DA0B7D88F960FDB89E3E * tmp = (DisallowMultipleComponent_tDB3D3DBC9AC523A0BD11DA0B7D88F960FDB89E3E *)cache->attributes[0];
		DisallowMultipleComponent__ctor_mDCA4B0F84AB4B3E17D216DB29318032547AB7F0D(tmp, NULL);
	}
	{
		DefaultExecutionOrder_t8495D3D4ECDFC3590621D31C3677D234D8A9BB1F * tmp = (DefaultExecutionOrder_t8495D3D4ECDFC3590621D31C3677D234D8A9BB1F *)cache->attributes[1];
		DefaultExecutionOrder__ctor_m18F4188D26702C2E3EC0AB3C1FF4AA4F5329E7A9(tmp, -2147483648LL, NULL);
	}
}
static void DataManager_1_t6383AA44ABD7100CAB0126FFAA79B7F7A914EC6A_CustomAttributesCacheGenerator_runtimeDataOverride(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void PixelBehaviour_1_t303CB24BA64E3914080E7B2105C0D0ED1B878046_CustomAttributesCacheGenerator_onlyAllowSingleInstance(CustomAttributesCache* cache)
{
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[0];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
	{
		HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB * tmp = (HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB *)cache->attributes[1];
		HeaderAttribute__ctor_m601319E0BCE8C44A9E79B2C0ABAAD0FEF46A9F1E(tmp, il2cpp_codegen_string_new_wrapper("\x50\x69\x78\x65\x6C\x42\x65\x68\x61\x76\x69\x6F\x75\x72\x20\x53\x69\x6E\x67\x6C\x65\x20\x49\x6E\x73\x74\x61\x6E\x63\x65"), NULL);
	}
}
static void PixelBehaviour_2_t88378B3C6EDDB4573EC34DBE76187EA153F2344B_CustomAttributesCacheGenerator_runtimeDataInjector(CustomAttributesCache* cache)
{
	{
		HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB * tmp = (HeaderAttribute_t9B431E6BA0524D46406D9C413D6A71CB5F2DD1AB *)cache->attributes[0];
		HeaderAttribute__ctor_m601319E0BCE8C44A9E79B2C0ABAAD0FEF46A9F1E(tmp, il2cpp_codegen_string_new_wrapper("\x50\x69\x78\x65\x6C\x42\x65\x68\x61\x76\x69\x6F\x75\x72\x20\x44\x61\x74\x61\x20\x49\x6E\x6A\x65\x63\x74\x69\x6F\x6E"), NULL);
	}
	{
		SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 * tmp = (SerializeField_t6B23EE6CC99B21C3EBD946352112832A70E67E25 *)cache->attributes[1];
		SerializeField__ctor_mDE6A7673BA2C1FAD03CFEC65C6D473CC37889DD3(tmp, NULL);
	}
}
static void Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Log_m14F40B40C246E65C9B218C73F2037C33134B40AB(CustomAttributesCache* cache)
{
	{
		ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C * tmp = (ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C *)cache->attributes[0];
		ConditionalAttribute__ctor_m43C71F47F8ED8FDF9A11FB20E8916C3737DD66AF(tmp, il2cpp_codegen_string_new_wrapper("\x44\x45\x56\x45\x4C\x4F\x50\x4D\x45\x4E\x54\x5F\x42\x55\x49\x4C\x44"), NULL);
	}
	{
		ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C * tmp = (ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C *)cache->attributes[1];
		ConditionalAttribute__ctor_m43C71F47F8ED8FDF9A11FB20E8916C3737DD66AF(tmp, il2cpp_codegen_string_new_wrapper("\x55\x4E\x49\x54\x59\x5F\x45\x44\x49\x54\x4F\x52"), NULL);
	}
}
static void Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Log_m14F40B40C246E65C9B218C73F2037C33134B40AB____args1(CustomAttributesCache* cache)
{
	{
		ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * tmp = (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F *)cache->attributes[0];
		ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719(tmp, NULL);
	}
}
static void Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Warn_m5CB2CD1576EFB6152021A5F842EA91875AD6543C(CustomAttributesCache* cache)
{
	{
		ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C * tmp = (ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C *)cache->attributes[0];
		ConditionalAttribute__ctor_m43C71F47F8ED8FDF9A11FB20E8916C3737DD66AF(tmp, il2cpp_codegen_string_new_wrapper("\x55\x4E\x49\x54\x59\x5F\x45\x44\x49\x54\x4F\x52"), NULL);
	}
	{
		ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C * tmp = (ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C *)cache->attributes[1];
		ConditionalAttribute__ctor_m43C71F47F8ED8FDF9A11FB20E8916C3737DD66AF(tmp, il2cpp_codegen_string_new_wrapper("\x44\x45\x56\x45\x4C\x4F\x50\x4D\x45\x4E\x54\x5F\x42\x55\x49\x4C\x44"), NULL);
	}
}
static void Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Warn_m5CB2CD1576EFB6152021A5F842EA91875AD6543C____args1(CustomAttributesCache* cache)
{
	{
		ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F * tmp = (ParamArrayAttribute_t9DCEB4CDDB8EDDB1124171D4C51FA6069EEA5C5F *)cache->attributes[0];
		ParamArrayAttribute__ctor_mCC72AFF718185BA7B87FD8D9471F1274400C5719(tmp, NULL);
	}
}
static void Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Exception_mC90850772C2E12C4709D942BA5A0A59CF0368706(CustomAttributesCache* cache)
{
	{
		ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C * tmp = (ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C *)cache->attributes[0];
		ConditionalAttribute__ctor_m43C71F47F8ED8FDF9A11FB20E8916C3737DD66AF(tmp, il2cpp_codegen_string_new_wrapper("\x55\x4E\x49\x54\x59\x5F\x45\x44\x49\x54\x4F\x52"), NULL);
	}
	{
		ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C * tmp = (ConditionalAttribute_t5DD558ED67ECF65952A82B94A75C6E8E121B2D8C *)cache->attributes[1];
		ConditionalAttribute__ctor_m43C71F47F8ED8FDF9A11FB20E8916C3737DD66AF(tmp, il2cpp_codegen_string_new_wrapper("\x44\x45\x56\x45\x4C\x4F\x50\x4D\x45\x4E\x54\x5F\x42\x55\x49\x4C\x44"), NULL);
	}
}
IL2CPP_EXTERN_C const CustomAttributesCacheGenerator g_Pixeltheory_Base_Runtime_AttributeGenerators[];
const CustomAttributesCacheGenerator g_Pixeltheory_Base_Runtime_AttributeGenerators[10] = 
{
	DataManager_1_t6383AA44ABD7100CAB0126FFAA79B7F7A914EC6A_CustomAttributesCacheGenerator,
	DataManager_1_t6383AA44ABD7100CAB0126FFAA79B7F7A914EC6A_CustomAttributesCacheGenerator_runtimeDataOverride,
	PixelBehaviour_1_t303CB24BA64E3914080E7B2105C0D0ED1B878046_CustomAttributesCacheGenerator_onlyAllowSingleInstance,
	PixelBehaviour_2_t88378B3C6EDDB4573EC34DBE76187EA153F2344B_CustomAttributesCacheGenerator_runtimeDataInjector,
	Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Log_m14F40B40C246E65C9B218C73F2037C33134B40AB,
	Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Warn_m5CB2CD1576EFB6152021A5F842EA91875AD6543C,
	Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Exception_mC90850772C2E12C4709D942BA5A0A59CF0368706,
	Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Log_m14F40B40C246E65C9B218C73F2037C33134B40AB____args1,
	Logging_t0CC01FA87F617FFE97ADF54F47E30D99C8C6519F_CustomAttributesCacheGenerator_Logging_Warn_m5CB2CD1576EFB6152021A5F842EA91875AD6543C____args1,
	Pixeltheory_Base_Runtime_CustomAttributesCacheGenerator,
};
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void RuntimeCompatibilityAttribute_set_WrapNonExceptionThrows_m8562196F90F3EBCEC23B5708EE0332842883C490_inline (RuntimeCompatibilityAttribute_tFF99AB2963098F9CBCD47A20D9FD3D51C17C1C80 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		bool L_0 = ___value0;
		__this->set_m_wrapNonExceptionThrows_0(L_0);
		return;
	}
}
