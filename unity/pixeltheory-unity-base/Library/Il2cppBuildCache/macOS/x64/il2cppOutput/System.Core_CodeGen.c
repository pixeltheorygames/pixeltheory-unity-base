#include "pch-c.h"
#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include "codegen/il2cpp-codegen-metadata.h"





// 0x00000001 System.Exception System.Linq.Error::ArgumentNull(System.String)
extern void Error_ArgumentNull_mC405D19505CA250B5C731803400D8DAF963F0DCD (void);
// 0x00000002 System.Exception System.Linq.Error::ArgumentOutOfRange(System.String)
extern void Error_ArgumentOutOfRange_mBF9354F0EDEE6E4BA57F3DA1663A91A5B61CEB9D (void);
// 0x00000003 System.Exception System.Linq.Error::MoreThanOneMatch()
extern void Error_MoreThanOneMatch_mEC48ECB89552B91EFD9669763848BA1DB97E991D (void);
// 0x00000004 System.Exception System.Linq.Error::NoElements()
extern void Error_NoElements_mE25C4D4F2FE86A32704624613D751BE305953E49 (void);
// 0x00000005 System.Exception System.Linq.Error::NoMatch()
extern void Error_NoMatch_m6CFB29419B6AA641B9684009696F318F19AFBE4B (void);
// 0x00000006 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Where(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000007 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Select(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,TResult>)
// 0x00000008 System.Func`2<TSource,System.Boolean> System.Linq.Enumerable::CombinePredicates(System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,System.Boolean>)
// 0x00000009 System.Func`2<TSource,TResult> System.Linq.Enumerable::CombineSelectors(System.Func`2<TSource,TMiddle>,System.Func`2<TMiddle,TResult>)
// 0x0000000A System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectMany(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::SelectManyIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Collections.Generic.IEnumerable`1<TResult>>)
// 0x0000000C System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Take(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x0000000D System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::TakeIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Int32)
// 0x0000000E System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Distinct(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000000F System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::DistinctIterator(System.Collections.Generic.IEnumerable`1<TSource>,System.Collections.Generic.IEqualityComparer`1<TSource>)
// 0x00000010 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::Reverse(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000011 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable::ReverseIterator(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000012 TSource[] System.Linq.Enumerable::ToArray(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000013 System.Collections.Generic.List`1<TSource> System.Linq.Enumerable::ToList(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000014 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::OfType(System.Collections.IEnumerable)
// 0x00000015 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::OfTypeIterator(System.Collections.IEnumerable)
// 0x00000016 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Cast(System.Collections.IEnumerable)
// 0x00000017 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::CastIterator(System.Collections.IEnumerable)
// 0x00000018 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000019 TSource System.Linq.Enumerable::First(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001A TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x0000001B TSource System.Linq.Enumerable::FirstOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001C TSource System.Linq.Enumerable::SingleOrDefault(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000001D System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::Repeat(TResult,System.Int32)
// 0x0000001E System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable::RepeatIterator(TResult,System.Int32)
// 0x0000001F System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>)
// 0x00000020 System.Boolean System.Linq.Enumerable::Any(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000021 System.Boolean System.Linq.Enumerable::All(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000022 System.Void System.Linq.Enumerable/Iterator`1::.ctor()
// 0x00000023 TSource System.Linq.Enumerable/Iterator`1::get_Current()
// 0x00000024 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/Iterator`1::Clone()
// 0x00000025 System.Void System.Linq.Enumerable/Iterator`1::Dispose()
// 0x00000026 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/Iterator`1::GetEnumerator()
// 0x00000027 System.Boolean System.Linq.Enumerable/Iterator`1::MoveNext()
// 0x00000028 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/Iterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000029 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/Iterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000002A System.Object System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.get_Current()
// 0x0000002B System.Collections.IEnumerator System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000002C System.Void System.Linq.Enumerable/Iterator`1::System.Collections.IEnumerator.Reset()
// 0x0000002D System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x0000002E System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Clone()
// 0x0000002F System.Void System.Linq.Enumerable/WhereEnumerableIterator`1::Dispose()
// 0x00000030 System.Boolean System.Linq.Enumerable/WhereEnumerableIterator`1::MoveNext()
// 0x00000031 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereEnumerableIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000032 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereEnumerableIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000033 System.Void System.Linq.Enumerable/WhereArrayIterator`1::.ctor(TSource[],System.Func`2<TSource,System.Boolean>)
// 0x00000034 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Clone()
// 0x00000035 System.Boolean System.Linq.Enumerable/WhereArrayIterator`1::MoveNext()
// 0x00000036 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereArrayIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x00000037 System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereArrayIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x00000038 System.Void System.Linq.Enumerable/WhereListIterator`1::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>)
// 0x00000039 System.Linq.Enumerable/Iterator`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Clone()
// 0x0000003A System.Boolean System.Linq.Enumerable/WhereListIterator`1::MoveNext()
// 0x0000003B System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereListIterator`1::Select(System.Func`2<TSource,TResult>)
// 0x0000003C System.Collections.Generic.IEnumerable`1<TSource> System.Linq.Enumerable/WhereListIterator`1::Where(System.Func`2<TSource,System.Boolean>)
// 0x0000003D System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::.ctor(System.Collections.Generic.IEnumerable`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x0000003E System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Clone()
// 0x0000003F System.Void System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Dispose()
// 0x00000040 System.Boolean System.Linq.Enumerable/WhereSelectEnumerableIterator`2::MoveNext()
// 0x00000041 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000042 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectEnumerableIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000043 System.Void System.Linq.Enumerable/WhereSelectArrayIterator`2::.ctor(TSource[],System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000044 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Clone()
// 0x00000045 System.Boolean System.Linq.Enumerable/WhereSelectArrayIterator`2::MoveNext()
// 0x00000046 System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectArrayIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x00000047 System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectArrayIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x00000048 System.Void System.Linq.Enumerable/WhereSelectListIterator`2::.ctor(System.Collections.Generic.List`1<TSource>,System.Func`2<TSource,System.Boolean>,System.Func`2<TSource,TResult>)
// 0x00000049 System.Linq.Enumerable/Iterator`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Clone()
// 0x0000004A System.Boolean System.Linq.Enumerable/WhereSelectListIterator`2::MoveNext()
// 0x0000004B System.Collections.Generic.IEnumerable`1<TResult2> System.Linq.Enumerable/WhereSelectListIterator`2::Select(System.Func`2<TResult,TResult2>)
// 0x0000004C System.Collections.Generic.IEnumerable`1<TResult> System.Linq.Enumerable/WhereSelectListIterator`2::Where(System.Func`2<TResult,System.Boolean>)
// 0x0000004D System.Void System.Linq.Enumerable/<>c__DisplayClass6_0`1::.ctor()
// 0x0000004E System.Boolean System.Linq.Enumerable/<>c__DisplayClass6_0`1::<CombinePredicates>b__0(TSource)
// 0x0000004F System.Void System.Linq.Enumerable/<>c__DisplayClass7_0`3::.ctor()
// 0x00000050 TResult System.Linq.Enumerable/<>c__DisplayClass7_0`3::<CombineSelectors>b__0(TSource)
// 0x00000051 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::.ctor(System.Int32)
// 0x00000052 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.IDisposable.Dispose()
// 0x00000053 System.Boolean System.Linq.Enumerable/<SelectManyIterator>d__17`2::MoveNext()
// 0x00000054 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally1()
// 0x00000055 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::<>m__Finally2()
// 0x00000056 TResult System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000057 System.Void System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.Reset()
// 0x00000058 System.Object System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerator.get_Current()
// 0x00000059 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x0000005A System.Collections.IEnumerator System.Linq.Enumerable/<SelectManyIterator>d__17`2::System.Collections.IEnumerable.GetEnumerator()
// 0x0000005B System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::.ctor(System.Int32)
// 0x0000005C System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::System.IDisposable.Dispose()
// 0x0000005D System.Boolean System.Linq.Enumerable/<TakeIterator>d__25`1::MoveNext()
// 0x0000005E System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::<>m__Finally1()
// 0x0000005F TSource System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000060 System.Void System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerator.Reset()
// 0x00000061 System.Object System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerator.get_Current()
// 0x00000062 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000063 System.Collections.IEnumerator System.Linq.Enumerable/<TakeIterator>d__25`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000064 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::.ctor(System.Int32)
// 0x00000065 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.IDisposable.Dispose()
// 0x00000066 System.Boolean System.Linq.Enumerable/<DistinctIterator>d__68`1::MoveNext()
// 0x00000067 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::<>m__Finally1()
// 0x00000068 TSource System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000069 System.Void System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.Reset()
// 0x0000006A System.Object System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerator.get_Current()
// 0x0000006B System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x0000006C System.Collections.IEnumerator System.Linq.Enumerable/<DistinctIterator>d__68`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000006D System.Void System.Linq.Enumerable/<ReverseIterator>d__79`1::.ctor(System.Int32)
// 0x0000006E System.Void System.Linq.Enumerable/<ReverseIterator>d__79`1::System.IDisposable.Dispose()
// 0x0000006F System.Boolean System.Linq.Enumerable/<ReverseIterator>d__79`1::MoveNext()
// 0x00000070 TSource System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.Generic.IEnumerator<TSource>.get_Current()
// 0x00000071 System.Void System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.IEnumerator.Reset()
// 0x00000072 System.Object System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.IEnumerator.get_Current()
// 0x00000073 System.Collections.Generic.IEnumerator`1<TSource> System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.Generic.IEnumerable<TSource>.GetEnumerator()
// 0x00000074 System.Collections.IEnumerator System.Linq.Enumerable/<ReverseIterator>d__79`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000075 System.Void System.Linq.Enumerable/<OfTypeIterator>d__97`1::.ctor(System.Int32)
// 0x00000076 System.Void System.Linq.Enumerable/<OfTypeIterator>d__97`1::System.IDisposable.Dispose()
// 0x00000077 System.Boolean System.Linq.Enumerable/<OfTypeIterator>d__97`1::MoveNext()
// 0x00000078 System.Void System.Linq.Enumerable/<OfTypeIterator>d__97`1::<>m__Finally1()
// 0x00000079 TResult System.Linq.Enumerable/<OfTypeIterator>d__97`1::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x0000007A System.Void System.Linq.Enumerable/<OfTypeIterator>d__97`1::System.Collections.IEnumerator.Reset()
// 0x0000007B System.Object System.Linq.Enumerable/<OfTypeIterator>d__97`1::System.Collections.IEnumerator.get_Current()
// 0x0000007C System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<OfTypeIterator>d__97`1::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x0000007D System.Collections.IEnumerator System.Linq.Enumerable/<OfTypeIterator>d__97`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000007E System.Void System.Linq.Enumerable/<CastIterator>d__99`1::.ctor(System.Int32)
// 0x0000007F System.Void System.Linq.Enumerable/<CastIterator>d__99`1::System.IDisposable.Dispose()
// 0x00000080 System.Boolean System.Linq.Enumerable/<CastIterator>d__99`1::MoveNext()
// 0x00000081 System.Void System.Linq.Enumerable/<CastIterator>d__99`1::<>m__Finally1()
// 0x00000082 TResult System.Linq.Enumerable/<CastIterator>d__99`1::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x00000083 System.Void System.Linq.Enumerable/<CastIterator>d__99`1::System.Collections.IEnumerator.Reset()
// 0x00000084 System.Object System.Linq.Enumerable/<CastIterator>d__99`1::System.Collections.IEnumerator.get_Current()
// 0x00000085 System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<CastIterator>d__99`1::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x00000086 System.Collections.IEnumerator System.Linq.Enumerable/<CastIterator>d__99`1::System.Collections.IEnumerable.GetEnumerator()
// 0x00000087 System.Void System.Linq.Enumerable/<RepeatIterator>d__117`1::.ctor(System.Int32)
// 0x00000088 System.Void System.Linq.Enumerable/<RepeatIterator>d__117`1::System.IDisposable.Dispose()
// 0x00000089 System.Boolean System.Linq.Enumerable/<RepeatIterator>d__117`1::MoveNext()
// 0x0000008A TResult System.Linq.Enumerable/<RepeatIterator>d__117`1::System.Collections.Generic.IEnumerator<TResult>.get_Current()
// 0x0000008B System.Void System.Linq.Enumerable/<RepeatIterator>d__117`1::System.Collections.IEnumerator.Reset()
// 0x0000008C System.Object System.Linq.Enumerable/<RepeatIterator>d__117`1::System.Collections.IEnumerator.get_Current()
// 0x0000008D System.Collections.Generic.IEnumerator`1<TResult> System.Linq.Enumerable/<RepeatIterator>d__117`1::System.Collections.Generic.IEnumerable<TResult>.GetEnumerator()
// 0x0000008E System.Collections.IEnumerator System.Linq.Enumerable/<RepeatIterator>d__117`1::System.Collections.IEnumerable.GetEnumerator()
// 0x0000008F System.Void System.Linq.Set`1::.ctor(System.Collections.Generic.IEqualityComparer`1<TElement>)
// 0x00000090 System.Boolean System.Linq.Set`1::Add(TElement)
// 0x00000091 System.Boolean System.Linq.Set`1::Find(TElement,System.Boolean)
// 0x00000092 System.Void System.Linq.Set`1::Resize()
// 0x00000093 System.Int32 System.Linq.Set`1::InternalGetHashCode(TElement)
// 0x00000094 System.Void System.Linq.Buffer`1::.ctor(System.Collections.Generic.IEnumerable`1<TElement>)
// 0x00000095 TElement[] System.Linq.Buffer`1::ToArray()
static Il2CppMethodPointer s_methodPointers[149] = 
{
	Error_ArgumentNull_mC405D19505CA250B5C731803400D8DAF963F0DCD,
	Error_ArgumentOutOfRange_mBF9354F0EDEE6E4BA57F3DA1663A91A5B61CEB9D,
	Error_MoreThanOneMatch_mEC48ECB89552B91EFD9669763848BA1DB97E991D,
	Error_NoElements_mE25C4D4F2FE86A32704624613D751BE305953E49,
	Error_NoMatch_m6CFB29419B6AA641B9684009696F318F19AFBE4B,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
	NULL,
};
static const int32_t s_InvokerIndices[149] = 
{
	2066,
	2066,
	2175,
	2175,
	2175,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
	-1,
};
static const Il2CppTokenRangePair s_rgctxIndices[52] = 
{
	{ 0x02000004, { 81, 4 } },
	{ 0x02000005, { 85, 9 } },
	{ 0x02000006, { 96, 7 } },
	{ 0x02000007, { 105, 10 } },
	{ 0x02000008, { 117, 11 } },
	{ 0x02000009, { 131, 9 } },
	{ 0x0200000A, { 143, 12 } },
	{ 0x0200000B, { 158, 1 } },
	{ 0x0200000C, { 159, 2 } },
	{ 0x0200000D, { 161, 12 } },
	{ 0x0200000E, { 173, 8 } },
	{ 0x0200000F, { 181, 11 } },
	{ 0x02000010, { 192, 6 } },
	{ 0x02000011, { 198, 6 } },
	{ 0x02000012, { 204, 6 } },
	{ 0x02000013, { 210, 4 } },
	{ 0x02000014, { 214, 8 } },
	{ 0x02000016, { 222, 4 } },
	{ 0x06000006, { 0, 10 } },
	{ 0x06000007, { 10, 10 } },
	{ 0x06000008, { 20, 5 } },
	{ 0x06000009, { 25, 5 } },
	{ 0x0600000A, { 30, 1 } },
	{ 0x0600000B, { 31, 2 } },
	{ 0x0600000C, { 33, 1 } },
	{ 0x0600000D, { 34, 2 } },
	{ 0x0600000E, { 36, 1 } },
	{ 0x0600000F, { 37, 2 } },
	{ 0x06000010, { 39, 1 } },
	{ 0x06000011, { 40, 2 } },
	{ 0x06000012, { 42, 3 } },
	{ 0x06000013, { 45, 2 } },
	{ 0x06000014, { 47, 1 } },
	{ 0x06000015, { 48, 2 } },
	{ 0x06000016, { 50, 2 } },
	{ 0x06000017, { 52, 2 } },
	{ 0x06000018, { 54, 4 } },
	{ 0x06000019, { 58, 3 } },
	{ 0x0600001A, { 61, 4 } },
	{ 0x0600001B, { 65, 3 } },
	{ 0x0600001C, { 68, 3 } },
	{ 0x0600001D, { 71, 1 } },
	{ 0x0600001E, { 72, 2 } },
	{ 0x0600001F, { 74, 1 } },
	{ 0x06000020, { 75, 3 } },
	{ 0x06000021, { 78, 3 } },
	{ 0x06000031, { 94, 2 } },
	{ 0x06000036, { 103, 2 } },
	{ 0x0600003B, { 115, 2 } },
	{ 0x06000041, { 128, 3 } },
	{ 0x06000046, { 140, 3 } },
	{ 0x0600004B, { 155, 3 } },
};
static const Il2CppRGCTXDefinition s_rgctxValues[226] = 
{
	{ (Il2CppRGCTXDataType)2, 1289 },
	{ (Il2CppRGCTXDataType)3, 3141 },
	{ (Il2CppRGCTXDataType)2, 1933 },
	{ (Il2CppRGCTXDataType)2, 1650 },
	{ (Il2CppRGCTXDataType)3, 5098 },
	{ (Il2CppRGCTXDataType)2, 1345 },
	{ (Il2CppRGCTXDataType)2, 1657 },
	{ (Il2CppRGCTXDataType)3, 5116 },
	{ (Il2CppRGCTXDataType)2, 1652 },
	{ (Il2CppRGCTXDataType)3, 5105 },
	{ (Il2CppRGCTXDataType)2, 1290 },
	{ (Il2CppRGCTXDataType)3, 3142 },
	{ (Il2CppRGCTXDataType)2, 1944 },
	{ (Il2CppRGCTXDataType)2, 1659 },
	{ (Il2CppRGCTXDataType)3, 5123 },
	{ (Il2CppRGCTXDataType)2, 1347 },
	{ (Il2CppRGCTXDataType)2, 1667 },
	{ (Il2CppRGCTXDataType)3, 5153 },
	{ (Il2CppRGCTXDataType)2, 1663 },
	{ (Il2CppRGCTXDataType)3, 5137 },
	{ (Il2CppRGCTXDataType)2, 416 },
	{ (Il2CppRGCTXDataType)3, 23 },
	{ (Il2CppRGCTXDataType)3, 24 },
	{ (Il2CppRGCTXDataType)2, 728 },
	{ (Il2CppRGCTXDataType)3, 2458 },
	{ (Il2CppRGCTXDataType)2, 417 },
	{ (Il2CppRGCTXDataType)3, 27 },
	{ (Il2CppRGCTXDataType)3, 28 },
	{ (Il2CppRGCTXDataType)2, 736 },
	{ (Il2CppRGCTXDataType)3, 2462 },
	{ (Il2CppRGCTXDataType)3, 6247 },
	{ (Il2CppRGCTXDataType)2, 432 },
	{ (Il2CppRGCTXDataType)3, 134 },
	{ (Il2CppRGCTXDataType)3, 6253 },
	{ (Il2CppRGCTXDataType)2, 434 },
	{ (Il2CppRGCTXDataType)3, 150 },
	{ (Il2CppRGCTXDataType)3, 6201 },
	{ (Il2CppRGCTXDataType)2, 421 },
	{ (Il2CppRGCTXDataType)3, 51 },
	{ (Il2CppRGCTXDataType)3, 6228 },
	{ (Il2CppRGCTXDataType)2, 430 },
	{ (Il2CppRGCTXDataType)3, 123 },
	{ (Il2CppRGCTXDataType)2, 507 },
	{ (Il2CppRGCTXDataType)3, 519 },
	{ (Il2CppRGCTXDataType)3, 520 },
	{ (Il2CppRGCTXDataType)2, 1346 },
	{ (Il2CppRGCTXDataType)3, 3499 },
	{ (Il2CppRGCTXDataType)3, 6218 },
	{ (Il2CppRGCTXDataType)2, 426 },
	{ (Il2CppRGCTXDataType)3, 90 },
	{ (Il2CppRGCTXDataType)2, 931 },
	{ (Il2CppRGCTXDataType)3, 6188 },
	{ (Il2CppRGCTXDataType)2, 419 },
	{ (Il2CppRGCTXDataType)3, 37 },
	{ (Il2CppRGCTXDataType)2, 1219 },
	{ (Il2CppRGCTXDataType)2, 846 },
	{ (Il2CppRGCTXDataType)2, 945 },
	{ (Il2CppRGCTXDataType)2, 1045 },
	{ (Il2CppRGCTXDataType)2, 946 },
	{ (Il2CppRGCTXDataType)2, 1046 },
	{ (Il2CppRGCTXDataType)3, 2459 },
	{ (Il2CppRGCTXDataType)2, 1220 },
	{ (Il2CppRGCTXDataType)2, 847 },
	{ (Il2CppRGCTXDataType)2, 947 },
	{ (Il2CppRGCTXDataType)2, 1047 },
	{ (Il2CppRGCTXDataType)2, 948 },
	{ (Il2CppRGCTXDataType)2, 1048 },
	{ (Il2CppRGCTXDataType)3, 2460 },
	{ (Il2CppRGCTXDataType)2, 949 },
	{ (Il2CppRGCTXDataType)2, 1049 },
	{ (Il2CppRGCTXDataType)3, 2461 },
	{ (Il2CppRGCTXDataType)3, 6223 },
	{ (Il2CppRGCTXDataType)2, 428 },
	{ (Il2CppRGCTXDataType)3, 104 },
	{ (Il2CppRGCTXDataType)2, 929 },
	{ (Il2CppRGCTXDataType)2, 930 },
	{ (Il2CppRGCTXDataType)2, 1044 },
	{ (Il2CppRGCTXDataType)3, 2457 },
	{ (Il2CppRGCTXDataType)2, 928 },
	{ (Il2CppRGCTXDataType)2, 1043 },
	{ (Il2CppRGCTXDataType)3, 2456 },
	{ (Il2CppRGCTXDataType)3, 3143 },
	{ (Il2CppRGCTXDataType)3, 3145 },
	{ (Il2CppRGCTXDataType)2, 294 },
	{ (Il2CppRGCTXDataType)3, 3144 },
	{ (Il2CppRGCTXDataType)3, 3153 },
	{ (Il2CppRGCTXDataType)2, 1293 },
	{ (Il2CppRGCTXDataType)2, 1653 },
	{ (Il2CppRGCTXDataType)3, 5106 },
	{ (Il2CppRGCTXDataType)3, 3154 },
	{ (Il2CppRGCTXDataType)2, 994 },
	{ (Il2CppRGCTXDataType)2, 1078 },
	{ (Il2CppRGCTXDataType)3, 2468 },
	{ (Il2CppRGCTXDataType)3, 6191 },
	{ (Il2CppRGCTXDataType)2, 1664 },
	{ (Il2CppRGCTXDataType)3, 5138 },
	{ (Il2CppRGCTXDataType)3, 3146 },
	{ (Il2CppRGCTXDataType)2, 1292 },
	{ (Il2CppRGCTXDataType)2, 1651 },
	{ (Il2CppRGCTXDataType)3, 5099 },
	{ (Il2CppRGCTXDataType)3, 2467 },
	{ (Il2CppRGCTXDataType)3, 3147 },
	{ (Il2CppRGCTXDataType)3, 6190 },
	{ (Il2CppRGCTXDataType)2, 1660 },
	{ (Il2CppRGCTXDataType)3, 5124 },
	{ (Il2CppRGCTXDataType)3, 3160 },
	{ (Il2CppRGCTXDataType)2, 1294 },
	{ (Il2CppRGCTXDataType)2, 1658 },
	{ (Il2CppRGCTXDataType)3, 5117 },
	{ (Il2CppRGCTXDataType)3, 3522 },
	{ (Il2CppRGCTXDataType)3, 1864 },
	{ (Il2CppRGCTXDataType)3, 2469 },
	{ (Il2CppRGCTXDataType)3, 1863 },
	{ (Il2CppRGCTXDataType)3, 3161 },
	{ (Il2CppRGCTXDataType)3, 6192 },
	{ (Il2CppRGCTXDataType)2, 1668 },
	{ (Il2CppRGCTXDataType)3, 5154 },
	{ (Il2CppRGCTXDataType)3, 3174 },
	{ (Il2CppRGCTXDataType)2, 1296 },
	{ (Il2CppRGCTXDataType)2, 1666 },
	{ (Il2CppRGCTXDataType)3, 5140 },
	{ (Il2CppRGCTXDataType)3, 3175 },
	{ (Il2CppRGCTXDataType)2, 997 },
	{ (Il2CppRGCTXDataType)2, 1081 },
	{ (Il2CppRGCTXDataType)3, 2473 },
	{ (Il2CppRGCTXDataType)3, 2472 },
	{ (Il2CppRGCTXDataType)2, 1655 },
	{ (Il2CppRGCTXDataType)3, 5108 },
	{ (Il2CppRGCTXDataType)3, 6195 },
	{ (Il2CppRGCTXDataType)2, 1665 },
	{ (Il2CppRGCTXDataType)3, 5139 },
	{ (Il2CppRGCTXDataType)3, 3167 },
	{ (Il2CppRGCTXDataType)2, 1295 },
	{ (Il2CppRGCTXDataType)2, 1662 },
	{ (Il2CppRGCTXDataType)3, 5126 },
	{ (Il2CppRGCTXDataType)3, 2471 },
	{ (Il2CppRGCTXDataType)3, 2470 },
	{ (Il2CppRGCTXDataType)3, 3168 },
	{ (Il2CppRGCTXDataType)2, 1654 },
	{ (Il2CppRGCTXDataType)3, 5107 },
	{ (Il2CppRGCTXDataType)3, 6194 },
	{ (Il2CppRGCTXDataType)2, 1661 },
	{ (Il2CppRGCTXDataType)3, 5125 },
	{ (Il2CppRGCTXDataType)3, 3181 },
	{ (Il2CppRGCTXDataType)2, 1297 },
	{ (Il2CppRGCTXDataType)2, 1670 },
	{ (Il2CppRGCTXDataType)3, 5156 },
	{ (Il2CppRGCTXDataType)3, 3523 },
	{ (Il2CppRGCTXDataType)3, 1866 },
	{ (Il2CppRGCTXDataType)3, 2475 },
	{ (Il2CppRGCTXDataType)3, 2474 },
	{ (Il2CppRGCTXDataType)3, 1865 },
	{ (Il2CppRGCTXDataType)3, 3182 },
	{ (Il2CppRGCTXDataType)2, 1656 },
	{ (Il2CppRGCTXDataType)3, 5109 },
	{ (Il2CppRGCTXDataType)3, 6196 },
	{ (Il2CppRGCTXDataType)2, 1669 },
	{ (Il2CppRGCTXDataType)3, 5155 },
	{ (Il2CppRGCTXDataType)3, 2464 },
	{ (Il2CppRGCTXDataType)3, 2465 },
	{ (Il2CppRGCTXDataType)3, 2476 },
	{ (Il2CppRGCTXDataType)3, 137 },
	{ (Il2CppRGCTXDataType)3, 136 },
	{ (Il2CppRGCTXDataType)2, 986 },
	{ (Il2CppRGCTXDataType)2, 1072 },
	{ (Il2CppRGCTXDataType)3, 2466 },
	{ (Il2CppRGCTXDataType)2, 1003 },
	{ (Il2CppRGCTXDataType)2, 1090 },
	{ (Il2CppRGCTXDataType)3, 139 },
	{ (Il2CppRGCTXDataType)2, 379 },
	{ (Il2CppRGCTXDataType)2, 433 },
	{ (Il2CppRGCTXDataType)3, 135 },
	{ (Il2CppRGCTXDataType)3, 138 },
	{ (Il2CppRGCTXDataType)3, 152 },
	{ (Il2CppRGCTXDataType)2, 989 },
	{ (Il2CppRGCTXDataType)2, 1074 },
	{ (Il2CppRGCTXDataType)3, 154 },
	{ (Il2CppRGCTXDataType)2, 292 },
	{ (Il2CppRGCTXDataType)2, 435 },
	{ (Il2CppRGCTXDataType)3, 151 },
	{ (Il2CppRGCTXDataType)3, 153 },
	{ (Il2CppRGCTXDataType)3, 53 },
	{ (Il2CppRGCTXDataType)2, 1568 },
	{ (Il2CppRGCTXDataType)3, 4683 },
	{ (Il2CppRGCTXDataType)2, 978 },
	{ (Il2CppRGCTXDataType)2, 1067 },
	{ (Il2CppRGCTXDataType)3, 4684 },
	{ (Il2CppRGCTXDataType)3, 55 },
	{ (Il2CppRGCTXDataType)2, 282 },
	{ (Il2CppRGCTXDataType)2, 422 },
	{ (Il2CppRGCTXDataType)3, 52 },
	{ (Il2CppRGCTXDataType)3, 54 },
	{ (Il2CppRGCTXDataType)2, 508 },
	{ (Il2CppRGCTXDataType)3, 521 },
	{ (Il2CppRGCTXDataType)2, 289 },
	{ (Il2CppRGCTXDataType)2, 431 },
	{ (Il2CppRGCTXDataType)3, 124 },
	{ (Il2CppRGCTXDataType)3, 125 },
	{ (Il2CppRGCTXDataType)3, 92 },
	{ (Il2CppRGCTXDataType)2, 284 },
	{ (Il2CppRGCTXDataType)3, 94 },
	{ (Il2CppRGCTXDataType)2, 427 },
	{ (Il2CppRGCTXDataType)3, 91 },
	{ (Il2CppRGCTXDataType)3, 93 },
	{ (Il2CppRGCTXDataType)3, 39 },
	{ (Il2CppRGCTXDataType)2, 280 },
	{ (Il2CppRGCTXDataType)3, 41 },
	{ (Il2CppRGCTXDataType)2, 420 },
	{ (Il2CppRGCTXDataType)3, 38 },
	{ (Il2CppRGCTXDataType)3, 40 },
	{ (Il2CppRGCTXDataType)2, 286 },
	{ (Il2CppRGCTXDataType)2, 429 },
	{ (Il2CppRGCTXDataType)3, 105 },
	{ (Il2CppRGCTXDataType)3, 106 },
	{ (Il2CppRGCTXDataType)3, 2281 },
	{ (Il2CppRGCTXDataType)2, 691 },
	{ (Il2CppRGCTXDataType)2, 2000 },
	{ (Il2CppRGCTXDataType)3, 4680 },
	{ (Il2CppRGCTXDataType)3, 4681 },
	{ (Il2CppRGCTXDataType)2, 1133 },
	{ (Il2CppRGCTXDataType)3, 4682 },
	{ (Il2CppRGCTXDataType)2, 234 },
	{ (Il2CppRGCTXDataType)2, 849 },
	{ (Il2CppRGCTXDataType)2, 1951 },
	{ (Il2CppRGCTXDataType)2, 962 },
	{ (Il2CppRGCTXDataType)2, 1051 },
};
extern const CustomAttributesCacheGenerator g_System_Core_AttributeGenerators[];
IL2CPP_EXTERN_C const Il2CppCodeGenModule g_System_Core_CodeGenModule;
const Il2CppCodeGenModule g_System_Core_CodeGenModule = 
{
	"System.Core.dll",
	149,
	s_methodPointers,
	0,
	NULL,
	s_InvokerIndices,
	0,
	NULL,
	52,
	s_rgctxIndices,
	226,
	s_rgctxValues,
	NULL,
	g_System_Core_AttributeGenerators,
	NULL, // module initializer,
	NULL,
	NULL,
	NULL,
};
