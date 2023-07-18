; ModuleID = 'obj/Debug/android/marshal_methods.x86.ll'
source_filename = "obj/Debug/android/marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [160 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 42
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 68
	i32 101534019, ; 2: Xamarin.AndroidX.SlidingPaneLayout => 0x60d4943 => 56
	i32 120558881, ; 3: Xamarin.AndroidX.SlidingPaneLayout.dll => 0x72f9521 => 56
	i32 134690465, ; 4: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 72
	i32 165246403, ; 5: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 23
	i32 182336117, ; 6: Xamarin.AndroidX.SwipeRefreshLayout.dll => 0xade3a75 => 58
	i32 209399409, ; 7: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 21
	i32 230216969, ; 8: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 38
	i32 280482487, ; 9: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 36
	i32 318968648, ; 10: Xamarin.AndroidX.Activity.dll => 0x13031348 => 12
	i32 321597661, ; 11: System.Numerics => 0x132b30dd => 8
	i32 342366114, ; 12: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 39
	i32 442521989, ; 13: Xamarin.Essentials => 0x1a605985 => 66
	i32 450948140, ; 14: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 34
	i32 465846621, ; 15: mscorlib => 0x1bc4415d => 4
	i32 469710990, ; 16: System.dll => 0x1bff388e => 7
	i32 476646585, ; 17: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 36
	i32 486930444, ; 18: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 48
	i32 527452488, ; 19: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 72
	i32 627609679, ; 20: Xamarin.AndroidX.CustomView => 0x2568904f => 30
	i32 663517072, ; 21: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 63
	i32 666292255, ; 22: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 18
	i32 675104682, ; 23: AndroidApp => 0x283d47aa => 0
	i32 691348768, ; 24: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 74
	i32 700284507, ; 25: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 69
	i32 720511267, ; 26: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 73
	i32 790371945, ; 27: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 31
	i32 807930345, ; 28: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx.dll => 0x302809e9 => 41
	i32 809851609, ; 29: System.Drawing.Common.dll => 0x30455ad9 => 77
	i32 843511501, ; 30: Xamarin.AndroidX.Print => 0x3246f6cd => 51
	i32 928116545, ; 31: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 68
	i32 956575887, ; 32: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 73
	i32 967690846, ; 33: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 39
	i32 1012816738, ; 34: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 54
	i32 1035644815, ; 35: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 17
	i32 1052210849, ; 36: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 44
	i32 1084122840, ; 37: Xamarin.Kotlin.StdLib => 0x409e66d8 => 71
	i32 1098259244, ; 38: System => 0x41761b2c => 7
	i32 1121599056, ; 39: Xamarin.AndroidX.Lifecycle.Runtime.Ktx.dll => 0x42da3e50 => 43
	i32 1149092582, ; 40: Xamarin.AndroidX.Window => 0x447dc2e6 => 65
	i32 1175144683, ; 41: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 61
	i32 1204270330, ; 42: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 18
	i32 1264511973, ; 43: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 57
	i32 1267360935, ; 44: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 62
	i32 1273260888, ; 45: Xamarin.AndroidX.Collection.Ktx => 0x4be46b58 => 24
	i32 1275534314, ; 46: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 74
	i32 1293217323, ; 47: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 33
	i32 1322716291, ; 48: Xamarin.AndroidX.Window.dll => 0x4ed70c83 => 65
	i32 1376866003, ; 49: Xamarin.AndroidX.SavedState => 0x52114ed3 => 54
	i32 1406073936, ; 50: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 26
	i32 1469204771, ; 51: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 16
	i32 1490025113, ; 52: Xamarin.AndroidX.SavedState.SavedState.Ktx.dll => 0x58cffa99 => 55
	i32 1582372066, ; 53: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 32
	i32 1622152042, ; 54: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 47
	i32 1636350590, ; 55: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 29
	i32 1639515021, ; 56: System.Net.Http.dll => 0x61b9038d => 76
	i32 1657153582, ; 57: System.Runtime => 0x62c6282e => 10
	i32 1658241508, ; 58: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 59
	i32 1658251792, ; 59: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 67
	i32 1698840827, ; 60: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 70
	i32 1720223769, ; 61: Xamarin.AndroidX.Lifecycle.LiveData.Core.Ktx => 0x66888819 => 41
	i32 1729485958, ; 62: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 22
	i32 1766324549, ; 63: Xamarin.AndroidX.SwipeRefreshLayout => 0x6947f945 => 58
	i32 1776026572, ; 64: System.Core.dll => 0x69dc03cc => 6
	i32 1788241197, ; 65: Xamarin.AndroidX.Fragment => 0x6a96652d => 34
	i32 1808609942, ; 66: Xamarin.AndroidX.Loader => 0x6bcd3296 => 47
	i32 1813058853, ; 67: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 71
	i32 1813201214, ; 68: Xamarin.Google.Android.Material => 0x6c13413e => 67
	i32 1826720441, ; 69: Com.Getkeepsafe.Relinker.dll => 0x6ce18ab9 => 1
	i32 1867746548, ; 70: Xamarin.Essentials.dll => 0x6f538cf4 => 66
	i32 1885316902, ; 71: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 19
	i32 1907988412, ; 72: AndroidApp.dll => 0x71b997bc => 0
	i32 1919157823, ; 73: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 49
	i32 1983156543, ; 74: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 70
	i32 2019465201, ; 75: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 44
	i32 2055257422, ; 76: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 40
	i32 2079903147, ; 77: System.Runtime.dll => 0x7bf8cdab => 10
	i32 2090596640, ; 78: System.Numerics.Vectors => 0x7c9bf920 => 9
	i32 2097448633, ; 79: Xamarin.AndroidX.Legacy.Support.Core.UI => 0x7d0486b9 => 37
	i32 2201107256, ; 80: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 75
	i32 2201231467, ; 81: System.Net.Http => 0x8334206b => 76
	i32 2217644978, ; 82: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 61
	i32 2244775296, ; 83: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 48
	i32 2256548716, ; 84: Xamarin.AndroidX.MultiDex => 0x8680336c => 49
	i32 2279755925, ; 85: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 53
	i32 2315684594, ; 86: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 14
	i32 2409053734, ; 87: Xamarin.AndroidX.Preference.dll => 0x8f973e26 => 50
	i32 2423080555, ; 88: Xamarin.AndroidX.Collection.Ktx.dll => 0x906d466b => 24
	i32 2475788418, ; 89: Java.Interop.dll => 0x93918882 => 2
	i32 2505896520, ; 90: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 42
	i32 2581783588, ; 91: Xamarin.AndroidX.Lifecycle.Runtime.Ktx => 0x99e2e424 => 43
	i32 2581819634, ; 92: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 62
	i32 2605712449, ; 93: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 75
	i32 2615233544, ; 94: Xamarin.AndroidX.Fragment.Ktx => 0x9be14c08 => 35
	i32 2620871830, ; 95: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 29
	i32 2701096212, ; 96: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 59
	i32 2732626843, ; 97: Xamarin.AndroidX.Activity => 0xa2e0939b => 12
	i32 2737747696, ; 98: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 16
	i32 2755563058, ; 99: ShieldFraud_Android.dll => 0xa43e8e32 => 5
	i32 2770495804, ; 100: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 69
	i32 2778768386, ; 101: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 64
	i32 2788224221, ; 102: Xamarin.AndroidX.Fragment.Ktx.dll => 0xa630ecdd => 35
	i32 2810250172, ; 103: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 26
	i32 2819470561, ; 104: System.Xml.dll => 0xa80db4e1 => 11
	i32 2838993487, ; 105: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx.dll => 0xa9379a4f => 45
	i32 2853208004, ; 106: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 64
	i32 2855708567, ; 107: Xamarin.AndroidX.Transition => 0xaa36a797 => 60
	i32 2870099610, ; 108: Xamarin.AndroidX.Activity.Ktx.dll => 0xab123e9a => 13
	i32 2903344695, ; 109: System.ComponentModel.Composition => 0xad0d8637 => 79
	i32 2905242038, ; 110: mscorlib.dll => 0xad2a79b6 => 4
	i32 2919462931, ; 111: System.Numerics.Vectors.dll => 0xae037813 => 9
	i32 2921128767, ; 112: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 15
	i32 2978675010, ; 113: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 33
	i32 3016983068, ; 114: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 57
	i32 3024354802, ; 115: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 38
	i32 3056245963, ; 116: Xamarin.AndroidX.SavedState.SavedState.Ktx => 0xb62a9ccb => 55
	i32 3211777861, ; 117: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 32
	i32 3247949154, ; 118: Mono.Security => 0xc197c562 => 78
	i32 3258312781, ; 119: Xamarin.AndroidX.CardView => 0xc235e84d => 22
	i32 3267021929, ; 120: Xamarin.AndroidX.AsyncLayoutInflater => 0xc2bacc69 => 20
	i32 3317135071, ; 121: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 30
	i32 3340431453, ; 122: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 19
	i32 3345895724, ; 123: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 52
	i32 3353484488, ; 124: Xamarin.AndroidX.Legacy.Support.Core.UI.dll => 0xc7e21cc8 => 37
	i32 3362336904, ; 125: Xamarin.AndroidX.Activity.Ktx => 0xc8693088 => 13
	i32 3362522851, ; 126: Xamarin.AndroidX.Core => 0xc86c06e3 => 28
	i32 3366347497, ; 127: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 128: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 53
	i32 3405233483, ; 129: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 31
	i32 3429136800, ; 130: System.Xml => 0xcc6479a0 => 11
	i32 3476120550, ; 131: Mono.Android => 0xcf3163e6 => 3
	i32 3493954962, ; 132: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 25
	i32 3501239056, ; 133: Xamarin.AndroidX.AsyncLayoutInflater.dll => 0xd0b0ab10 => 20
	i32 3567349600, ; 134: System.ComponentModel.Composition.dll => 0xd4a16f60 => 79
	i32 3618140916, ; 135: Xamarin.AndroidX.Preference => 0xd7a872f4 => 50
	i32 3627220390, ; 136: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 51
	i32 3633644679, ; 137: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 15
	i32 3641597786, ; 138: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 40
	i32 3672681054, ; 139: Mono.Android.dll => 0xdae8aa5e => 3
	i32 3682565725, ; 140: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 21
	i32 3684561358, ; 141: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 25
	i32 3689375977, ; 142: System.Drawing.Common => 0xdbe768e9 => 77
	i32 3706696989, ; 143: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 27
	i32 3718780102, ; 144: Xamarin.AndroidX.Annotation => 0xdda814c6 => 14
	i32 3786282454, ; 145: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 23
	i32 3821914142, ; 146: Com.Getkeepsafe.Relinker => 0xe3cdc81e => 1
	i32 3829621856, ; 147: System.Numerics.dll => 0xe4436460 => 8
	i32 3885922214, ; 148: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 60
	i32 3888767677, ; 149: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 52
	i32 3896760992, ; 150: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 28
	i32 3921031405, ; 151: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 63
	i32 3955647286, ; 152: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 17
	i32 3958374065, ; 153: ShieldFraud_Android => 0xebeffeb1 => 5
	i32 4105002889, ; 154: Mono.Security.dll => 0xf4ad5f89 => 78
	i32 4151237749, ; 155: System.Core => 0xf76edc75 => 6
	i32 4182413190, ; 156: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 46
	i32 4256097574, ; 157: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 27
	i32 4258378803, ; 158: Xamarin.AndroidX.Lifecycle.ViewModel.Ktx => 0xfdd1b433 => 45
	i32 4292120959 ; 159: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 46
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [160 x i32] [
	i32 42, i32 68, i32 56, i32 56, i32 72, i32 23, i32 58, i32 21, ; 0..7
	i32 38, i32 36, i32 12, i32 8, i32 39, i32 66, i32 34, i32 4, ; 8..15
	i32 7, i32 36, i32 48, i32 72, i32 30, i32 63, i32 18, i32 0, ; 16..23
	i32 74, i32 69, i32 73, i32 31, i32 41, i32 77, i32 51, i32 68, ; 24..31
	i32 73, i32 39, i32 54, i32 17, i32 44, i32 71, i32 7, i32 43, ; 32..39
	i32 65, i32 61, i32 18, i32 57, i32 62, i32 24, i32 74, i32 33, ; 40..47
	i32 65, i32 54, i32 26, i32 16, i32 55, i32 32, i32 47, i32 29, ; 48..55
	i32 76, i32 10, i32 59, i32 67, i32 70, i32 41, i32 22, i32 58, ; 56..63
	i32 6, i32 34, i32 47, i32 71, i32 67, i32 1, i32 66, i32 19, ; 64..71
	i32 0, i32 49, i32 70, i32 44, i32 40, i32 10, i32 9, i32 37, ; 72..79
	i32 75, i32 76, i32 61, i32 48, i32 49, i32 53, i32 14, i32 50, ; 80..87
	i32 24, i32 2, i32 42, i32 43, i32 62, i32 75, i32 35, i32 29, ; 88..95
	i32 59, i32 12, i32 16, i32 5, i32 69, i32 64, i32 35, i32 26, ; 96..103
	i32 11, i32 45, i32 64, i32 60, i32 13, i32 79, i32 4, i32 9, ; 104..111
	i32 15, i32 33, i32 57, i32 38, i32 55, i32 32, i32 78, i32 22, ; 112..119
	i32 20, i32 30, i32 19, i32 52, i32 37, i32 13, i32 28, i32 2, ; 120..127
	i32 53, i32 31, i32 11, i32 3, i32 25, i32 20, i32 79, i32 50, ; 128..135
	i32 51, i32 15, i32 40, i32 3, i32 21, i32 25, i32 77, i32 27, ; 136..143
	i32 14, i32 23, i32 1, i32 8, i32 60, i32 52, i32 28, i32 63, ; 144..151
	i32 17, i32 5, i32 78, i32 6, i32 46, i32 27, i32 45, i32 46 ; 160..159
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 797e2e13d1706ace607da43703769c5a55c4de60"}
!llvm.linker.options = !{}
